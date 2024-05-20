namespace WinFormsLoginka
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(0, -9);
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
            pictureBox2.Location = new Point(0, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(258, 239);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(275, 9);
            label1.Name = "label1";
            label1.Size = new Size(402, 63);
            label1.TabIndex = 3;
            label1.Text = "Create an account";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(384, 123);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(277, 37);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(384, 96);
            label3.Name = "label3";
            label3.Size = new Size(181, 24);
            label3.TabIndex = 7;
            label3.Text = "*Create a username:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(384, 204);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 37);
            textBox2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(384, 177);
            label2.Name = "label2";
            label2.Size = new Size(176, 24);
            label2.TabIndex = 9;
            label2.Text = "*Create a password:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(384, 287);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(277, 37);
            textBox3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(384, 260);
            label4.Name = "label4";
            label4.Size = new Size(215, 24);
            label4.TabIndex = 11;
            label4.Text = "*Password Confirmation:";
            // 
            // button1
            // 
            button1.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(603, 355);
            button1.Name = "button1";
            button1.Size = new Size(122, 55);
            button1.TabIndex = 12;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Impact", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(55, 355);
            button2.Name = "button2";
            button2.Size = new Size(149, 55);
            button2.TabIndex = 13;
            button2.Text = "Back to Log In";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            ForeColor = Color.Black;
            Name = "SignUpForm";
            Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}