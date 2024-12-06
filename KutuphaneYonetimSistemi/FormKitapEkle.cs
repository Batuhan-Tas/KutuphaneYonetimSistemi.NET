using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace KutuphaneYonetimSistemi
{

    public partial class FormKitapEkle : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=LMSDb;Integrated Security=True;Trust Server Certificate=True");

        public FormKitapEkle()
        {
            InitializeComponent();



        }

        public FormKitapEkle(string kitapId, string kitapAd, string kitapYazar, string ISBN, string kitapTur)
        {
            InitializeComponent();
            labelKitapID.Text = kitapId;
            textBoxKitapAdi.Text = kitapAd;
            textBoxYazarAdi.Text = kitapYazar;
            textBoxISBN.Text = ISBN;
            textBoxKitapTurKodu.Text = kitapTur;



        }

        private void buttonKitapKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                SqlCommand cmdKaydet = new SqlCommand("INSERT INTO TableKitaplar (KitapAdi, YazarAdi, ISBN, Durum, KitapTurKodu) VALUES (@P1,@P2,@P3,@P4,@P5)", baglanti);
                cmdKaydet.Parameters.AddWithValue("@P1", textBoxKitapAdi.Text);
                cmdKaydet.Parameters.AddWithValue("@P2", textBoxYazarAdi.Text);
                cmdKaydet.Parameters.AddWithValue("@P3", textBoxISBN.Text);
                cmdKaydet.Parameters.AddWithValue("@P4", true);
                cmdKaydet.Parameters.AddWithValue("@P5", textBoxKitapTurKodu.Text);

                cmdKaydet.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hatalı Giriş!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                baglanti.Close();


            }

            this.Close();


        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand2 = new SqlCommand("UPDATE TableKitaplar SET KitapAdi = @P1,YazarAdi = @P2,ISBN = @P3 ,Durum = @P4 ,KitapTurKodu = @P5 WHERE ID = @P0", baglanti);

                sqlCommand2.Parameters.AddWithValue("@P0", labelKitapID.Text);
                sqlCommand2.Parameters.AddWithValue("@P1", textBoxKitapAdi.Text);
                sqlCommand2.Parameters.AddWithValue("@P2", textBoxYazarAdi.Text);
                sqlCommand2.Parameters.AddWithValue("@P3", textBoxISBN.Text);
                sqlCommand2.Parameters.AddWithValue("@P4", true);
                sqlCommand2.Parameters.AddWithValue("@P5", textBoxKitapTurKodu.Text);

                sqlCommand2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncellerken Hata Oluştu"+ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                baglanti.Close();
                
            }

            this.Close ();
        }
    }
}
