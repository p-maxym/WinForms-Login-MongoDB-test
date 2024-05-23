﻿namespace WinFormsLoginka
{
    partial class LoginWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            LoginBox = new TextBox();
            label2 = new Label();
            PasswordBox = new TextBox();
            label3 = new Label();
            LogIn = new Button();
            SignUp = new Button();
            panel1 = new Panel();
            CreateButton = new Button();
            PasswordConfBox = new TextBox();
            label7 = new Label();
            PasswordCreateBox = new TextBox();
            label6 = new Label();
            CreateUsernameBox = new TextBox();
            label5 = new Label();
            AccCreateLabel = new Label();
            BackToLoginButton = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.InactiveCaptionText;
            pictureBox1.Location = new Point(-2, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 461);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(-2, 37);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(258, 239);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(287, 9);
            label1.Name = "label1";
            label1.Size = new Size(314, 63);
            label1.TabIndex = 2;
            label1.Text = "Login Account";
            // 
            // LoginBox
            // 
            LoginBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LoginBox.BackColor = Color.White;
            LoginBox.BorderStyle = BorderStyle.FixedSingle;
            LoginBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBox.Location = new Point(407, 157);
            LoginBox.Multiline = true;
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(239, 34);
            LoginBox.TabIndex = 3;
            LoginBox.TextChanged += LoginBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(407, 215);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // PasswordBox
            // 
            PasswordBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PasswordBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordBox.Location = new Point(407, 242);
            PasswordBox.Multiline = true;
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '●';
            PasswordBox.Size = new Size(239, 34);
            PasswordBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(407, 130);
            label3.Name = "label3";
            label3.Size = new Size(98, 24);
            label3.TabIndex = 6;
            label3.Text = "Username:";
            // 
            // LogIn
            // 
            LogIn.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LogIn.Location = new Point(591, 341);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(129, 54);
            LogIn.TabIndex = 7;
            LogIn.Text = "Log In";
            LogIn.UseVisualStyleBackColor = true;
            LogIn.Click += LogIn_Click;
            // 
            // SignUp
            // 
            SignUp.BackColor = Color.Transparent;
            SignUp.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SignUp.Location = new Point(64, 339);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(123, 58);
            SignUp.TabIndex = 8;
            SignUp.Text = "Sign Up";
            SignUp.UseVisualStyleBackColor = false;
            SignUp.Click += SignUp_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(CreateButton);
            panel1.Controls.Add(PasswordConfBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(PasswordCreateBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(CreateUsernameBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(AccCreateLabel);
            panel1.Controls.Add(BackToLoginButton);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 453);
            panel1.TabIndex = 9;
            panel1.Visible = false;
            // 
            // CreateButton
            // 
            CreateButton.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CreateButton.Location = new Point(591, 343);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(122, 55);
            CreateButton.TabIndex = 22;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            // 
            // PasswordConfBox
            // 
            PasswordConfBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordConfBox.Location = new Point(369, 251);
            PasswordConfBox.Multiline = true;
            PasswordConfBox.Name = "PasswordConfBox";
            PasswordConfBox.Size = new Size(277, 37);
            PasswordConfBox.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(369, 224);
            label7.Name = "label7";
            label7.Size = new Size(215, 24);
            label7.TabIndex = 20;
            label7.Text = "*Password Confirmation:";
            // 
            // PasswordCreateBox
            // 
            PasswordCreateBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordCreateBox.Location = new Point(369, 184);
            PasswordCreateBox.Multiline = true;
            PasswordCreateBox.Name = "PasswordCreateBox";
            PasswordCreateBox.Size = new Size(277, 37);
            PasswordCreateBox.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(369, 157);
            label6.Name = "label6";
            label6.Size = new Size(176, 24);
            label6.TabIndex = 18;
            label6.Text = "*Create a password:";
            // 
            // CreateUsernameBox
            // 
            CreateUsernameBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CreateUsernameBox.Location = new Point(369, 114);
            CreateUsernameBox.Multiline = true;
            CreateUsernameBox.Name = "CreateUsernameBox";
            CreateUsernameBox.Size = new Size(277, 37);
            CreateUsernameBox.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(369, 87);
            label5.Name = "label5";
            label5.Size = new Size(181, 24);
            label5.TabIndex = 16;
            label5.Text = "*Create a username:";
            // 
            // AccCreateLabel
            // 
            AccCreateLabel.AutoSize = true;
            AccCreateLabel.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point);
            AccCreateLabel.Location = new Point(262, 9);
            AccCreateLabel.Name = "AccCreateLabel";
            AccCreateLabel.Size = new Size(402, 63);
            AccCreateLabel.TabIndex = 15;
            AccCreateLabel.Text = "Create an account";
            // 
            // BackToLoginButton
            // 
            BackToLoginButton.Font = new Font("Impact", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BackToLoginButton.Location = new Point(54, 343);
            BackToLoginButton.Name = "BackToLoginButton";
            BackToLoginButton.Size = new Size(149, 55);
            BackToLoginButton.TabIndex = 14;
            BackToLoginButton.Text = "Back to Log In";
            BackToLoginButton.UseVisualStyleBackColor = true;
            BackToLoginButton.Click += BackToLoginButton_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ActiveCaptionText;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(-2, 37);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(258, 239);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Black;
            pictureBox3.Location = new Point(-2, -8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(258, 461);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(SignUp);
            Controls.Add(LogIn);
            Controls.Add(label3);
            Controls.Add(PasswordBox);
            Controls.Add(label2);
            Controls.Add(LoginBox);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "LoginWindow";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox LoginBox;
        private Label label2;
        private TextBox PasswordBox;
        private Label label3;
        private Button LogIn;
        private Button SignUp;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button BackToLoginButton;
        private Label AccCreateLabel;
        private Label label5;
        private TextBox CreateUsernameBox;
        private Label label6;
        private TextBox PasswordCreateBox;
        private Label label7;
        private TextBox PasswordConfBox;
        private Button CreateButton;
    }
}