using System;
using System.Collections;
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
    public partial class FrmMasterJP : Form
    {
        ComboBoxFunc cb = new ComboBoxFunc();
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterJP()
        {
            InitializeComponent();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmMasterJP_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();

            //Menampilkan Data Negara dari database dan dimasukkan ke ComboBox
            string negaraQuery = "SELECT * FROM public.tbl_negara";
            combDari.DataSource = cb.getData(negaraQuery);
            combDari.DisplayMember = "nama";
            combDari.ValueMember = "id";
            combKe.DataSource = cb.getData(negaraQuery);
            combKe.DisplayMember = "nama";
            combKe.ValueMember = "id";

            // Query untuk combMaskapai
            string maskapaiQuery = "SELECT * FROM public.tbl_maskapai";
            combMaskapai.DataSource = cb.getData(maskapaiQuery);
            combMaskapai.DisplayMember = "nama";
            combMaskapai.ValueMember = "id";
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String sql = "INSERT INTO public.tbl_jadwalpenerbangan" +
                    "(id,kodepenerbangan,bandarakeberangkatanid,bandaratujuanid,maskapaiid,tanggalkeberangkatan,waktukeberangkatan,durasipenerbangan,hargapertiket)" +
                    "VALUES" +
                    "('" + id.Text + "'," +
                    "'" + txtKodePen.Text + "'," +
                    "'" + combDari.SelectedValue + "'," +
                    "'" + combKe.SelectedValue + "'," +
                    "'" + combMaskapai.SelectedValue + "'," +
                    "'" + dateTanggal.Text + "'," +
                    "'" + timeWaktuBer.Text + "'," +
                    "'" + txtDurasiPen.Text + "'," +
                    "'" + numHargaPer.Text + "')";
                cmd = new NpgsqlCommand(sql, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Menyimpan Data Jadwal Penerbangan");
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
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM public.tbl_jadwalpenerbangan", Koneksi.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "public.tbl_jadwalpenerbangan");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            Koneksi.conn.Open();
            String sql = "SELECT id FROM public.tbl_jadwalpenerbangan " + "where id in(select max(id) FROM public.tbl_jadwalpenerbangan) " + "order by id desc";
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

        private void TimeWaktuBer_ValueChanged(object sender, EventArgs e)
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
                    String sql = "DELETE FROM public.tbl_jadwalpenerbangan WHERE id=@id";
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
        }
    }
}
