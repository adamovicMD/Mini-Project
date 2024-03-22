namespace MiniProject
{
    partial class logIn
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
            username = new TextBox();
            password = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // username
            // 
            username.ForeColor = SystemColors.WindowFrame;
            username.Location = new Point(56, 239);
            username.Name = "username";
            username.Size = new Size(161, 23);
            username.TabIndex = 0;
            username.Text = "username";
            // 
            // password
            // 
            password.ForeColor = SystemColors.WindowFrame;
            password.Location = new Point(56, 286);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(161, 23);
            password.TabIndex = 1;
            password.Text = "password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 47);
            label1.Name = "label1";
            label1.Size = new Size(212, 37);
            label1.TabIndex = 2;
            label1.Text = "Welcome back!";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.alt_1567913_448b4a214bc1e4e954a0292f7f411d06;
            pictureBox1.Location = new Point(77, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(109, 323);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // logIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(269, 367);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(username);
            Name = "logIn";
            Text = "logIn";
            Load += logIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox password;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}