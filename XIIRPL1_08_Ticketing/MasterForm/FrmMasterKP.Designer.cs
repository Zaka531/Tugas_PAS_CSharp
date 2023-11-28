namespace XIIRPL1_08_Ticketing.MasterForm
{
    partial class FrmMasterKP
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
            txtKodePro = new TextBox();
            btnSimpan = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            dateBerlaku = new DateTimePicker();
            numPersentaseDis = new NumericUpDown();
            numMaksimumDis = new NumericUpDown();
            id = new TextBox();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPersentaseDis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaksimumDis).BeginInit();
            SuspendLayout();
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(390, 252);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(151, 99);
            txtDeskripsi.TabIndex = 34;
            txtDeskripsi.Text = "";
            // 
            // txtKodePro
            // 
            txtKodePro.Location = new Point(90, 252);
            txtKodePro.Name = "txtKodePro";
            txtKodePro.Size = new Size(169, 23);
            txtKodePro.TabIndex = 29;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(330, 255);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 24;
            label7.Text = "Deskripsi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 367);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 23;
            label6.Text = "Maksimum Diskon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 330);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 22;
            label5.Text = "Persentase Diskon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 291);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 21;
            label4.Text = "Berlaku Sampai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 255);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 20;
            label3.Text = "Kode Promo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 46);
            label2.Name = "label2";
            label2.Size = new Size(294, 15);
            label2.TabIndex = 19;
            label2.Text = "Semua kode promo yang terdaftar akan muncul di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(209, 30);
            label1.TabIndex = 18;
            label1.Text = "Master Kode Promo";
            // 
            // dateBerlaku
            // 
            dateBerlaku.Location = new Point(110, 285);
            dateBerlaku.Name = "dateBerlaku";
            dateBerlaku.Size = new Size(149, 23);
            dateBerlaku.TabIndex = 35;
            // 
            // numPersentaseDis
            // 
            numPersentaseDis.Location = new Point(124, 328);
            numPersentaseDis.Name = "numPersentaseDis";
            numPersentaseDis.Size = new Size(135, 23);
            numPersentaseDis.TabIndex = 36;
            // 
            // numMaksimumDis
            // 
            numMaksimumDis.Location = new Point(124, 365);
            numMaksimumDis.Name = "numMaksimumDis";
            numMaksimumDis.Size = new Size(135, 23);
            numMaksimumDis.TabIndex = 37;
            // 
            // id
            // 
            id.Location = new Point(373, 23);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 38;
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
            // FrmMasterKP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 416);
            Controls.Add(id);
            Controls.Add(numMaksimumDis);
            Controls.Add(numPersentaseDis);
            Controls.Add(dateBerlaku);
            Controls.Add(txtDeskripsi);
            Controls.Add(txtKodePro);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmMasterKP";
            Load += FrmMasterKP_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPersentaseDis).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaksimumDis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtDeskripsi;
        private TextBox txtKodePro;
        private Button btnSimpan;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private DateTimePicker dateBerlaku;
        private NumericUpDown numPersentaseDis;
        private NumericUpDown numMaksimumDis;
        private TextBox id;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}
