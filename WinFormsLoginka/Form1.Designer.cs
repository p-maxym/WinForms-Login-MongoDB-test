namespace WinFormsLoginka
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
            SignIn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            pictureBox2.Location = new Point(-2, 30);
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
            LoginBox.Location = new Point(407, 157);
            LoginBox.Multiline = true;
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(239, 34);
            LoginBox.TabIndex = 3;
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
            PasswordBox.Location = new Point(407, 242);
            PasswordBox.Multiline = true;
            PasswordBox.Name = "PasswordBox";
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
            LogIn.Font = new Font("Impact", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LogIn.Location = new Point(603, 347);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(120, 46);
            LogIn.TabIndex = 7;
            LogIn.Text = "Log In";
            LogIn.UseVisualStyleBackColor = true;
            // 
            // SignIn
            // 
            SignIn.BackColor = Color.Transparent;
            SignIn.Font = new Font("Impact", 13F, FontStyle.Regular, GraphicsUnit.Point);
            SignIn.Location = new Point(67, 350);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(120, 47);
            SignIn.TabIndex = 8;
            SignIn.Text = "Sign In";
            SignIn.UseVisualStyleBackColor = false;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(SignIn);
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
        private Button SignIn;
    }
}