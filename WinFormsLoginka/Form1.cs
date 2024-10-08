﻿using MongoDB.Driver;
using MongoDB.Bson;
using System.Text.Json;
using System.Diagnostics;
using System.Linq.Expressions;

namespace WinFormsLoginka
{
    public partial class LoginWindow : Form
    {
        private readonly MongoClient _client;
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<BsonDocument> _collection;

        private System.Threading.CancellationTokenSource? _ctoken;
        private bool isAvailable = false;

        public LoginWindow()
        {
            InitializeComponent();
            _client = new MongoClient("mongodb+srv://maxymdb:maxymdb@datab.0sego7m.mongodb.net/\r\n");
            _database = _client.GetDatabase("DataB");
            _collection = _database.GetCollection<BsonDocument>("WinFormLoginUsers");

        }

        private void ShowPanel(Panel panel)
        {
            panel.Visible = true;
            panel.BringToFront();
        }

        private void HidePanel(Panel panel) => panel.Visible = false;

        protected void ConnectToDataBase()
        {
            const string connectionUri = "mongodb+srv://maxymdb:maxymdb@datab.0sego7m.mongodb.net/?retryWrites=true&w=majority&appName=DataB";
            var settings = MongoClientSettings.FromConnectionString(connectionUri);
            // Set the ServerApi field of the settings object to set the version of the Stable API on the client
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            // Create a new client and connect to the server
            var client = new MongoClient(settings);
            // Send a ping to confirm a successful connection
            try
            {
                var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
                Debug.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public void AddUserToDataBase(string username, string password)
        {
            try
            {
                var document = new BsonDocument
                {
                    {"username", username},
                    {"password", password}
                };
                _collection.InsertOne(document);
                Debug.WriteLine("User successfully added.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void LogIn_Click(object sender, EventArgs e)
        {
            string username = LoginBox.Text;
            string password = PasswordBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username or password cannot be empty.");
                return;
            }

            try
            {
                var usernameFilter = Builders<BsonDocument>.Filter.Eq("username", username);

                var usernameFind = await _collection.Find(usernameFilter).FirstOrDefaultAsync();

                if (usernameFind != null)
                {
                    string storedHashedPassword = usernameFind["password"].AsString;

                    if (BCrypt.Net.BCrypt.Verify(password, storedHashedPassword))
                    {
                        MessageBox.Show($"Login successfull.\nWelcome {username}");
                    }
                    else
                    {
                        MessageBox.Show("Login or password is not correct.");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred: {ex.Message}.");
                MessageBox.Show($"An error occurred: {ex.Message}.");
            }
        }

        private void ClearAllFields()
        {
            LoginBox.Text = string.Empty;
            PasswordBox.Text = string.Empty;

            CreateUsernameBox.Text = string.Empty;
            PasswordCreateBox.Text = string.Empty;
            PasswordConfirmBox.Text = string.Empty;

            TermsCondConfirm.Checked = false;
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            ShowPanel(panel1);
        }

        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            HidePanel(panel1);
        }

        private async Task<bool> IsUsernameAvailableAsync(string username)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("username", username.ToLower());
            var user = await _collection.Find(filter).FirstOrDefaultAsync();
            return user == null;
        }

        private async void CreateUsernameBox_TextChanged(object sender, EventArgs e)
        {
            if (_ctoken != null)
            {
                _ctoken.Cancel();
                _ctoken.Dispose();
            }

            _ctoken = new System.Threading.CancellationTokenSource();
            var token = _ctoken.Token;

            try { await Task.Delay(300, token); }

            catch (TaskCanceledException) { return; }

            string username = CreateUsernameBox.Text;

            if (string.IsNullOrEmpty(username))
            {
                AvailabilityLabel.Text = String.Empty;
                return;
            }

            AvailabilityLabel.Text = "Checking...";

            isAvailable = await IsUsernameAvailableAsync(username);

            if (isAvailable)
            {
                AvailabilityLabel.Text = "Available";
                AvailabilityLabel.ForeColor = Color.Green;
            }
            else
            {
                AvailabilityLabel.Text = "Taken";
                AvailabilityLabel.ForeColor = Color.Red;
            }
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            string username = CreateUsernameBox.Text;
            string createdPassword = PasswordCreateBox.Text;
            string confirmedPassword = PasswordConfirmBox.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty.");
                return;
            }

            if (createdPassword != confirmedPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (string.IsNullOrEmpty(createdPassword) || string.IsNullOrEmpty(confirmedPassword))
            {
                MessageBox.Show("Password fields cannot be empty.");
                return;
            }

            if (!TermsCondConfirm.Checked)
            {
                MessageBox.Show("You must accept the Terms and Conditions.");
                return;
            }

            isAvailable = await IsUsernameAvailableAsync(username);

            if (!isAvailable)
            {
                MessageBox.Show("Nickname is already taken.");
                return;
            }

            try
            {
                var document = new BsonDocument
                {
                    {"username", username},
                    {"password", BCrypt.Net.BCrypt.HashPassword(confirmedPassword)}
                };
                await _collection.InsertOneAsync(document);
                MessageBox.Show("Account created successfully\nTry to log in.");
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void TogglePasswordVisibility(bool showPassword, string boxName)
        {
            switch (boxName)
            {
                case "createPassword":
                    showPassPic1.Visible = !showPassword;
                    hidePassPic1.Visible = showPassword;
                    PasswordCreateBox.PasswordChar = showPassword ? '\0' : '●';
                    break;
                case "confirmPassword":
                    showPassPic2.Visible = !showPassword;
                    hidePassPic2.Visible = showPassword;
                    PasswordConfirmBox.PasswordChar = showPassword ? '\0' : '●';
                    break;
                case "LogInPassword":
                    showPassLogIn.Visible = !showPassword;
                    hidePassLogIn.Visible = showPassword;
                    PasswordBox.PasswordChar = showPassword ? '\0' : '●';
                    break;
            }
        }

        private void hidePassPic1_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(false, "createPassword");
        }

        private void showPassPic1_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(true, "createPassword");
        }

        private void hidePassPic2_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(false, "confirmPassword");
        }

        private void showPassPic2_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(true, "confirmPassword");
        }

        private void hidePassLogIn_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(false, "LogInPassword");
        }

        private void showPassLogIn_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(true, "LogInPassword");
        }
    }
}
