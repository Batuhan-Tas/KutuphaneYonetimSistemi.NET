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
    public partial class FormOduncAl : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=LMSDb;Integrated Security=True;Trust Server Certificate=True");
        public FormOduncAl()
        {
            InitializeComponent();
        }

        public FormOduncAl(string kitapId)
        {
            InitializeComponent();
            textBoxKitapID.Text = kitapId;

        }

        private void buttonOduncAl_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand3 = new SqlCommand("UPDATE TableKitaplar SET OduncAlan = @P1,OduncAlmaTarihi = @P2,Durum = @P3 WHERE ID = @P0", baglanti);
                sqlCommand3.Parameters.AddWithValue("@P0", textBoxKitapID.Text);
                sqlCommand3.Parameters.AddWithValue("@P1", textBoxOduncAlan.Text);
                sqlCommand3.Parameters.Add("@P2", SqlDbType.Date).Value = dateTimePickerTarih.Value.Date;
                sqlCommand3.Parameters.AddWithValue("@P3", "False");

                

                sqlCommand3.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ödünç Alırken Hata Oluştu" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                baglanti.Close();

            }
            this.Close();
        }
    }
}
