namespace XIIRPL1_08_Ticketing.MasterForm
{
    partial class FrmMasterBD
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btnBatal = new Button();
            btnSimpan = new Button();
            txtNama = new TextBox();
            txtKodeIATA = new TextBox();
            txtKota = new TextBox();
            combNegara = new ComboBox();
            numJumlahTer = new NumericUpDown();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtAlamat = new RichTextBox();
            id = new TextBox();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJumlahTer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 13);
            label1.Name = "label1";
            label1.Size = new Size(166, 30);
            label1.TabIndex = 0;
            label1.Text = "Master Bandara";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 45);
            label2.Name = "label2";
            label2.Size = new Size(272, 15);
            label2.TabIndex = 1;
            label2.Text = "Semua bandara yang terdaftar akan muncul di sini";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 254);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 290);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 4;
            label4.Text = "Kode IATA";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 329);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 5;
            label5.Text = "Kota";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 366);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 6;
            label6.Text = "Negara";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(288, 254);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 7;
            label7.Text = "Jumlah Terminal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(288, 287);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 8;
            label8.Text = "Alamat";
            label8.Click += label8_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(15, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(550, 150);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
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
            // btnBatal
            // 
            btnBatal.Location = new Point(382, 370);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 23);
            btnBatal.TabIndex = 10;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += button1_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(463, 370);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 11;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(87, 251);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(169, 23);
            txtNama.TabIndex = 12;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // txtKodeIATA
            // 
            txtKodeIATA.Location = new Point(87, 287);
            txtKodeIATA.Name = "txtKodeIATA";
            txtKodeIATA.Size = new Size(169, 23);
            txtKodeIATA.TabIndex = 13;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(87, 326);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(169, 23);
            txtKota.TabIndex = 14;
            // 
            // combNegara
            // 
            combNegara.FormattingEnabled = true;
            combNegara.Location = new Point(87, 362);
            combNegara.Name = "combNegara";
            combNegara.Size = new Size(169, 23);
            combNegara.TabIndex = 15;
            // 
            // numJumlahTer
            // 
            numJumlahTer.Location = new Point(387, 251);
            numJumlahTer.Name = "numJumlahTer";
            numJumlahTer.Size = new Size(151, 23);
            numJumlahTer.TabIndex = 16;
            numJumlahTer.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(387, 287);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(151, 74);
            txtAlamat.TabIndex = 17;
            txtAlamat.Text = "";
            // 
            // id
            // 
            id.Location = new Point(357, 22);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 18;
            id.TextChanged += id_TextChanged;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(301, 370);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FrmMasterBD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 408);
            Controls.Add(btnEdit);
            Controls.Add(id);
            Controls.Add(txtAlamat);
            Controls.Add(numJumlahTer);
            Controls.Add(combNegara);
            Controls.Add(txtKota);
            Controls.Add(txtKodeIATA);
            Controls.Add(txtNama);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterBD";
            Load += FrmMasterBD_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJumlahTer).EndInit();
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
        private Label label8;
        private DataGridView dataGridView1;
        private Button btnBatal;
        private Button btnSimpan;
        private TextBox txtNama;
        private TextBox txtKodeIATA;
        private TextBox txtKota;
        private ComboBox combNegara;
        private NumericUpDown numJumlahTer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RichTextBox txtAlamat;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnEdit;
    }
}
