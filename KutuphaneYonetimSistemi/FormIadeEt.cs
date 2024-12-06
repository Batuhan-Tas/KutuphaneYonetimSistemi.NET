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
    public partial class FormIadeEt : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=LMSDb;Integrated Security=True;Trust Server Certificate=True");
        public FormIadeEt()
        {
            InitializeComponent();
        }

        public FormIadeEt(string kitapId,DateTime dateTime)
        {
            InitializeComponent();
            textBoxKitapId.Text = kitapId;            
            labelAlinmaTarihi.Text = dateTime.ToString();
            
            


        }

        private void buttonIadeEt_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand4 = new SqlCommand("UPDATE TableKitaplar SET OduncAlan = @P1,OduncAlmaTarihi = @P2,Durum = @P3 WHERE ID = @P0", baglanti);
                sqlCommand4.Parameters.AddWithValue("@P0", textBoxKitapId.Text);
                sqlCommand4.Parameters.AddWithValue("@P1", DBNull.Value);
                sqlCommand4.Parameters.Add("@P2", SqlDbType.Date).Value = DBNull.Value;
                sqlCommand4.Parameters.AddWithValue("@P3", "True");



                sqlCommand4.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İade Edilirken Hata Oluştu" + ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                baglanti.Close();

            }
            this.Close();

        }

        private void buttonGecikmeBedeli_Click(object sender, EventArgs e)
        {



            if (textBoxKitapId.Text != "-")
            {
                
                    DateTime today = DateTime.Now;
                    int gunFarki = (int)(today - DateTime.Parse(labelAlinmaTarihi.Text)).TotalDays;
                    int gecikmeFarki = 0;

                    if (gunFarki > 30)
                    {
                        gecikmeFarki = (gunFarki - 30) * 5;

                    }
                    else
                    {
                        gecikmeFarki = 0;
                    }

                    labelGecikmeUcreti.Text = gecikmeFarki.ToString();
                
                
            }






            }
    }
}
