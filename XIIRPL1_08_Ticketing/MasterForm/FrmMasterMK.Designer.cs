namespace XIIRPL1_08_Ticketing.MasterForm
{
    partial class FrmMasterMK
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDeskripsi = new RichTextBox();
            numJumlahKru = new NumericUpDown();
            txtPerusahaan = new TextBox();
            txtNama = new TextBox();
            btnSimpan = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            id = new TextBox();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)numJumlahKru).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(357, 257);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(184, 92);
            txtDeskripsi.TabIndex = 34;
            txtDeskripsi.Text = "";
            txtDeskripsi.TextChanged += txtDeskripsi_TextChanged;
            // 
            // numJumlahKru
            // 
            numJumlahKru.Location = new Point(90, 326);
            numJumlahKru.Name = "numJumlahKru";
            numJumlahKru.Size = new Size(169, 23);
            numJumlahKru.TabIndex = 33;
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(90, 288);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(169, 23);
            txtPerusahaan.TabIndex = 30;
            txtPerusahaan.TextChanged += textBox2_TextChanged;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(90, 252);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(169, 23);
            txtNama.TabIndex = 29;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(466, 371);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 28;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(385, 371);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(18, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(550, 150);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(291, 257);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 25;
            label8.Text = "Deskripsi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 328);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 22;
            label5.Text = "Jumlah Kru";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 291);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 21;
            label4.Text = "Perusahaan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 255);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 20;
            label3.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 46);
            label2.Name = "label2";
            label2.Size = new Size(279, 15);
            label2.TabIndex = 19;
            label2.Text = "Semua maskapai yang terdaftar akan muncul di sini";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(179, 30);
            label1.TabIndex = 18;
            label1.Text = "Master Maskapai";
            // 
            // id
            // 
            id.Location = new Point(412, 23);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 35;
            id.TextChanged += id_TextChanged;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // FrmMasterMK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 407);
            Controls.Add(id);
            Controls.Add(txtDeskripsi);
            Controls.Add(numJumlahKru);
            Controls.Add(txtPerusahaan);
            Controls.Add(txtNama);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterMK";
            Load += FrmMasterMK_Load;
            ((System.ComponentModel.ISupportInitialize)numJumlahKru).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtDeskripsi;
        private NumericUpDown numJumlahKru;
        private TextBox txtPerusahaan;
        private TextBox txtNama;
        private Button btnSimpan;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}
