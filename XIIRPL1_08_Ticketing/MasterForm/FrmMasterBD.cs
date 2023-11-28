using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace XIIRPL1_08_Ticketing.MasterForm
{
    public partial class FrmMasterBD : Form
    {
        ComboBoxFunc cb = new ComboBoxFunc();
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterBD()
        {
            InitializeComponent();
        }

        private void FrmMasterBD_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();

            //Menampilkan Data Negara dari database dan dimasukkan ke ComboBox
            string query = "SELECT * FROM public.tbl_negara";

            combNegara.DataSource = cb.getData(query);
            combNegara.DisplayMember = "nama";
            combNegara.ValueMember = "id";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String sql = "INSERT INTO public.tbl_bandara" +
                    "(id,nama,kode_iata,kota,negara_id,jumlah_terminal,alamat)" +
                    "VALUES" +
                    "('" + id.Text + "'," +
                    "'" + txtNama.Text + "'," +
                    "'" + txtKodeIATA.Text + "'," +
                    "'" + txtKota.Text + "'," +
                    "'" + combNegara.SelectedValue + "'," +
                    "'" + numJumlahTer.Text + "'," +
                    "'" + txtAlamat.Text + "')";
                cmd = new NpgsqlCommand(sql, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Menyimpan Data Bandara");
                view_data();
                Koneksi.conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void view_data()
        {
            string sql = "SELECT public.tbl_bandara.id, " +
                "public.tbl_bandara.nama, " +
                "public.tbl_bandara.kode_iata, " +
                "public.tbl_bandara.kota, " +
                "public.tbl_negara.nama, " +
                "public.tbl_bandara.jumlah_terminal " +
                "FROM public.tbl_bandara INNER JOIN " +
                "public.tbl_negara ON public.tbl_bandara.negara_id = public.tbl_negara.id";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, Koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[2].HeaderText = "ID";
            dataGridView1.Columns[3].HeaderText = "Nama Bandara";
            dataGridView1.Columns[4].HeaderText = "Kode IATA";
            dataGridView1.Columns[5].HeaderText = "Kota";
            dataGridView1.Columns[6].HeaderText = "Negara";
            dataGridView1.Columns[7].HeaderText = "Jumlah Terminal";
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            Koneksi.conn.Open();
            String sql = "SELECT id FROM public.tbl_bandara " + "where id in(select max(id) FROM public.tbl_bandara) " + "order by id desc";
            cmd = new NpgsqlCommand(sql, Koneksi.conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                nomor = Convert.ToInt32(dr[0]);
                hitung = nomor + 1;
            }
            else
            {
                hitung = 1;
            }
            dr.Close();
            id.Text = Convert.ToString(hitung);
            Koneksi.conn.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    Koneksi.conn.Open();
                    String sql = "DELETE FROM public.tbl_bandara WHERE id=@id";
                    cmd = new NpgsqlCommand(sql, Koneksi.conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Berhasil Dihapus");
                        view_data();
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Berhasil Dihapus");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Koneksi.conn.Close();
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                id.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                txtNama.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["nama"].Value);
                txtKodeIATA.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["kode_iata"].Value);
                txtKota.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["kota"].Value);
                combNegara.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["negara_id"].Value);
                numJumlahTer.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["jumlah_terminal"].Value);
                txtAlamat.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["alamat"].Value);
                btnSimpan.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String sql = "UPDATE public.tbl_bandara SET " +
                    "nama = '"+ txtNama.Text +"', " +
                    "kode_iata = '"+ txtKodeIATA.Text +"', " +
                    "kota = '"+ txtKota.Text +"', " +
                    "negara_id = '"+ combNegara.Text +"', " +
                    "jumlah_terminal = '"+ numJumlahTer.Text +"', " +
                    "alamat = '"+ txtAlamat.Text +"'" +
                    "WHERE id = '"+ id.Text +"'";
                cmd = new NpgsqlCommand(sql, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Ubah Data Bandara");
                view_data();
                Koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
