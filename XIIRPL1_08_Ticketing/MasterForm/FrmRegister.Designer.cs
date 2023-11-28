namespace XIIRPL1_08_Ticketing.MasterForm
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtUsername = new TextBox();
            txtNama = new TextBox();
            txtNomorTlp = new TextBox();
            txtPassword = new TextBox();
            txtTglLahir = new DateTimePicker();
            btnDaftar = new Button();
            label8 = new Label();
            txtLinkLabel = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(133, 30);
            label1.TabIndex = 0;
            label1.Text = "Daftar Akun";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 54);
            label2.Name = "label2";
            label2.Size = new Size(304, 15);
            label2.TabIndex = 1;
            label2.Text = "Daftarkan diri Anda untuk menggunakan Bromo Airlines";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 87);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 132);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Nama";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 184);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 4;
            label5.Text = "Tanggal Lahir";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 228);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 5;
            label6.Text = "Nomor Telepon";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 277);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 6;
            label7.Text = "Password";
            label7.Click += label7_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(119, 84);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 7;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(119, 129);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(200, 23);
            txtNama.TabIndex = 8;
            txtNama.TextChanged += textBox2_TextChanged;
            // 
            // txtNomorTlp
            // 
            txtNomorTlp.Location = new Point(119, 225);
            txtNomorTlp.Name = "txtNomorTlp";
            txtNomorTlp.Size = new Size(200, 23);
            txtNomorTlp.TabIndex = 9;
            txtNomorTlp.TextChanged += textBox3_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(119, 274);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 10;
            txtPassword.TextChanged += textBox4_TextChanged;
            // 
            // txtTglLahir
            // 
            txtTglLahir.Location = new Point(119, 178);
            txtTglLahir.Name = "txtTglLahir";
            txtTglLahir.Size = new Size(200, 23);
            txtTglLahir.TabIndex = 11;
            txtTglLahir.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnDaftar
            // 
            btnDaftar.Location = new Point(244, 322);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(75, 23);
            btnDaftar.TabIndex = 12;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 372);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 13;
            label8.Text = "Sudah punya akun?";
            // 
            // txtLinkLabel
            // 
            txtLinkLabel.AutoSize = true;
            txtLinkLabel.Location = new Point(133, 372);
            txtLinkLabel.Name = "txtLinkLabel";
            txtLinkLabel.Size = new Size(37, 15);
            txtLinkLabel.TabIndex = 14;
            txtLinkLabel.TabStop = true;
            txtLinkLabel.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(357, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 284);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txtLinkLabel);
            Controls.Add(label8);
            Controls.Add(btnDaftar);
            Controls.Add(txtTglLahir);
            Controls.Add(txtPassword);
            Controls.Add(txtNomorTlp);
            Controls.Add(txtNama);
            Controls.Add(txtUsername);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegister";
            Text = "FrmRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtUsername;
        private TextBox txtNama;
        private TextBox txtNomorTlp;
        private TextBox txtPassword;
        private DateTimePicker txtTglLahir;
        private Button btnDaftar;
        private Label label8;
        private LinkLabel txtLinkLabel;
        private PictureBox pictureBox1;
    }
}