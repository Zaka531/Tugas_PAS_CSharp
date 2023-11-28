namespace XIIRPL1_08_Ticketing.MasterForm
{
    partial class FrmMasterJP
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
            numHargaPer = new NumericUpDown();
            combMaskapai = new ComboBox();
            txtKodePen = new TextBox();
            btnSimpan = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            combDari = new ComboBox();
            combKe = new ComboBox();
            txtDurasiPen = new TextBox();
            dateTanggal = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            id = new TextBox();
            timeWaktuBer = new DateTimePicker();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)numHargaPer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // numHargaPer
            // 
            numHargaPer.Location = new Point(438, 364);
            numHargaPer.Name = "numHargaPer";
            numHargaPer.Size = new Size(109, 23);
            numHargaPer.TabIndex = 33;
            numHargaPer.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // combMaskapai
            // 
            combMaskapai.FormattingEnabled = true;
            combMaskapai.Location = new Point(127, 364);
            combMaskapai.Name = "combMaskapai";
            combMaskapai.Size = new Size(154, 23);
            combMaskapai.TabIndex = 32;
            // 
            // txtKodePen
            // 
            txtKodePen.Location = new Point(127, 252);
            txtKodePen.Name = "txtKodePen";
            txtKodePen.Size = new Size(154, 23);
            txtKodePen.TabIndex = 29;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(472, 408);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 28;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(391, 408);
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
            label8.Location = new Point(309, 258);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 25;
            label8.Text = "Tanggal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(309, 294);
            label7.Name = "label7";
            label7.Size = new Size(123, 15);
            label7.TabIndex = 24;
            label7.Text = "Waktu Keberangkatan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 367);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 23;
            label6.Text = "Maskapai";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 330);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 22;
            label5.Text = "Ke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 291);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 21;
            label4.Text = "Dari";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 255);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 20;
            label3.Text = "Kode Penerbangan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 46);
            label2.Name = "label2";
            label2.Size = new Size(259, 15);
            label2.TabIndex = 19;
            label2.Text = "Semua jadwal penerbangan akan muncul di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(288, 30);
            label1.TabIndex = 18;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // combDari
            // 
            combDari.FormattingEnabled = true;
            combDari.Location = new Point(127, 288);
            combDari.Name = "combDari";
            combDari.Size = new Size(154, 23);
            combDari.TabIndex = 35;
            // 
            // combKe
            // 
            combKe.FormattingEnabled = true;
            combKe.Location = new Point(127, 327);
            combKe.Name = "combKe";
            combKe.Size = new Size(154, 23);
            combKe.TabIndex = 36;
            // 
            // txtDurasiPen
            // 
            txtDurasiPen.Location = new Point(438, 324);
            txtDurasiPen.Name = "txtDurasiPen";
            txtDurasiPen.Size = new Size(109, 23);
            txtDurasiPen.TabIndex = 37;
            txtDurasiPen.TextChanged += textBox2_TextChanged;
            // 
            // dateTanggal
            // 
            dateTanggal.Location = new Point(363, 252);
            dateTanggal.Name = "dateTanggal";
            dateTanggal.Size = new Size(184, 23);
            dateTanggal.TabIndex = 39;
            dateTanggal.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(309, 327);
            label9.Name = "label9";
            label9.Size = new Size(113, 15);
            label9.TabIndex = 40;
            label9.Text = "Durasi Penerbangan";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(309, 367);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 41;
            label10.Text = "Harga per Tiket";
            // 
            // id
            // 
            id.Location = new Point(332, 23);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 43;
            // 
            // timeWaktuBer
            // 
            timeWaktuBer.CustomFormat = "HH:mm";
            timeWaktuBer.Format = DateTimePickerFormat.Custom;
            timeWaktuBer.Location = new Point(438, 291);
            timeWaktuBer.Name = "timeWaktuBer";
            timeWaktuBer.ShowUpDown = true;
            timeWaktuBer.Size = new Size(109, 23);
            timeWaktuBer.TabIndex = 44;
            timeWaktuBer.Value = new DateTime(2023, 11, 7, 10, 58, 49, 289);
            timeWaktuBer.ValueChanged += TimeWaktuBer_ValueChanged;
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
            // FrmMasterJP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 472);
            Controls.Add(timeWaktuBer);
            Controls.Add(id);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dateTanggal);
            Controls.Add(txtDurasiPen);
            Controls.Add(combKe);
            Controls.Add(combDari);
            Controls.Add(numHargaPer);
            Controls.Add(combMaskapai);
            Controls.Add(txtKodePen);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterJP";
            Load += FrmMasterJP_Load;
            ((System.ComponentModel.ISupportInitialize)numHargaPer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numHargaPer;
        private ComboBox combMaskapai;
        private TextBox txtKodePen;
        private Button btnSimpan;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private ComboBox combDari;
        private ComboBox combKe;
        private TextBox txtDurasiPen;
        private TextBox txtWaktu;
        private DateTimePicker dateTanggal;
        private Label label9;
        private Label label10;
        private TextBox id;
        private DateTimePicker timeWaktuBer;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}
