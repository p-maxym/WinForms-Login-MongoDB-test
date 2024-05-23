using MongoDB.Driver;
using MongoDB.Bson;
using System.Text.Json;
using System.Diagnostics;

namespace WinFormsLoginka
{
    public partial class LoginWindow : Form
    {
        private readonly MongoClient _client;
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<BsonDocument> _collection;

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

        private void LogIn_Click(object sender, EventArgs e)
        {
            string username = LoginBox.Text;
            string password = PasswordBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username or password cannot be empty.");
                return;
            }

            var usernameFilter = Builders<BsonDocument>.Filter.Eq("username", username);

            var usernameFind = _collection.Find(usernameFilter).FirstOrDefault();
            string? passwordFind = usernameFind.GetValue("password").ToString();

            try
            {

                if (passwordFind != null && passwordFind == password)
                {
                    MessageBox.Show($"Login successfull.\nWelcome {username}");
                }
                else
                {
                    MessageBox.Show("Login or password is not correct.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An error occurred: {ex.Message}.");
                MessageBox.Show($"An error occurred: {ex.Message}.");
            }
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            ShowPanel(panel1);
        }

        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
            HidePanel(panel1);
        }
    }
}
