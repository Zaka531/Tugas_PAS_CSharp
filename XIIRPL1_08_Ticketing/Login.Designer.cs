namespace XIIRPL1_08_Ticketing
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtLinkLabel = new LinkLabel();
            btnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtLinkLabel
            // 
            txtLinkLabel.AutoSize = true;
            txtLinkLabel.Location = new Point(428, 397);
            txtLinkLabel.Name = "txtLinkLabel";
            txtLinkLabel.Size = new Size(96, 15);
            txtLinkLabel.TabIndex = 15;
            txtLinkLabel.TabStop = true;
            txtLinkLabel.Text = "Daftar Sekarang !";
            txtLinkLabel.LinkClicked += txtLinkLabel_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(559, 348);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 397);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 13;
            label3.Text = "Belum punya akun ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 304);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 251);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 11;
            label1.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(289, 301);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(345, 23);
            txtPassword.TabIndex = 10;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(289, 248);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(345, 23);
            txtUsername.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(149, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(502, 159);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLinkLabel);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel txtLinkLabel;
        private Button btnLogin;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private PictureBox pictureBox1;
    }
}