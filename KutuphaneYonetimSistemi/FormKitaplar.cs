using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimSistemi
{
    public partial class FormKitaplar : Form
    {
        public static FormKitaplar instance;
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=LMSDb;Integrated Security=True;Trust Server Certificate=True");


        FormKitapEkle formKitapEkle;
        FormOduncAl formOduncAl;
        FormIadeEt formIadeEt;

        public FormKitaplar()
        {
            InitializeComponent();
            instance = this;
        }

        private void onYukleme()
        {
            string q = "SELECT * FROM TableKitaplar";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(q, baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                dataGridViewKitaplar.DataSource = dataTable;
            }
        }

        private void FormKitaplar_Load(object sender, EventArgs e)
        {
            onYukleme();
        }

        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            formKitapEkle = new FormKitapEkle();
            formKitapEkle.Show();
            formKitapEkle.FormClosed += delegate
            {
                onYukleme();
            };


        }

        private void buttonOduncAl_Click(object sender, EventArgs e)
        {
            int secilenSatir = dataGridViewKitaplar.SelectedCells[0].RowIndex;
            string kitapId = dataGridViewKitaplar.Rows[secilenSatir].Cells[0].Value.ToString();
            formOduncAl = new FormOduncAl(kitapId);
            formOduncAl.Show();
            formOduncAl.FormClosed += delegate
            {
                onYukleme();
            };
        }

        private void buttonIadeEt_Click(object sender, EventArgs e)
        {
            int secilenSatir = dataGridViewKitaplar.SelectedCells[0].RowIndex;
            string kitapId = dataGridViewKitaplar.Rows[secilenSatir].Cells[0].Value.ToString();
            try
            {
                DateTime dateTime = DateTime.Parse(dataGridViewKitaplar.Rows[secilenSatir].Cells[6].Value.ToString());
                formIadeEt = new FormIadeEt(kitapId, dateTime);
                formIadeEt.Show();
                formIadeEt.FormClosed += delegate
                {
                    onYukleme();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap henüz ödünç alınmamış ve iade edilemez.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            onYukleme();
        }

        private void dataGridViewKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilenSatir = dataGridViewKitaplar.SelectedCells[0].RowIndex;
            string kitapId = dataGridViewKitaplar.Rows[secilenSatir].Cells[0].Value.ToString();
            string kitapAd = dataGridViewKitaplar.Rows[secilenSatir].Cells[1].Value.ToString();
            string yazarAd = dataGridViewKitaplar.Rows[secilenSatir].Cells[2].Value.ToString();
            string ISBN = dataGridViewKitaplar.Rows[secilenSatir].Cells[3].Value.ToString();
            string kitapTur = dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value.ToString();

            formKitapEkle = new FormKitapEkle(kitapId, kitapAd, yazarAd, ISBN, kitapTur);

            formKitapEkle.Show();
        }


        private void aramaSonuclari()
        {
            try
            {
                string q = "SELECT * FROM TableKitaplar WHERE KitapAdi LIKE '" + textBoxAra.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }
        private void buttonAra_Click(object sender, EventArgs e)
        {
            aramaSonuclari();

        }

        private void buttonKitapSil_Click(object sender, EventArgs e)
        {

            int secilenSatir = dataGridViewKitaplar.SelectedCells[0].RowIndex;
            string kitapId = dataGridViewKitaplar.Rows[secilenSatir].Cells[0].Value.ToString();

            try
            {
                baglanti.Open();
                SqlCommand sqlCommand5 = new SqlCommand("DELETE FROM TableKitaplar WHERE ID = @P0 ", baglanti);

                sqlCommand5.Parameters.AddWithValue("@P0", kitapId);


                sqlCommand5.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncellerken Hata Oluştu" + ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                baglanti.Close();

            }

            onYukleme();

        }

        private void FormKitaplar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
