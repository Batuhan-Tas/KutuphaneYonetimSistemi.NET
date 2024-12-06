using Microsoft.Data.SqlClient;

namespace KutuphaneYonetimSistemi
{
    public partial class FormLogin : Form
    {

        FormKitaplar formKitaplar;
        public FormLogin()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=LMSDb;Integrated Security=True;Trust Server Certificate=True");
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string sifre = "";

            try
            {
                baglanti.Open();
                SqlCommand sqlkomut = new SqlCommand("SELECT Sifre FROM TableKutuphaneYoneticileri WHERE KullaniciAdi = @p1", baglanti);
                sqlkomut.Parameters.AddWithValue("@p1", textBoxKullaniciAdi.Text);
                SqlDataReader reader = sqlkomut.ExecuteReader();

                while (reader.Read())
                {
                    sifre = reader[0].ToString();
                }

                if (sifre == textBoxSifre.Text)
                {

                    formKitaplar = new FormKitaplar();
                    this.Hide();
                    formKitaplar.Show();


                }
                else
                {
                    MessageBox.Show("Kullan�c� ad� ya da �ifre hatal�", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxKullaniciAdi.Clear();
                    textBoxSifre.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ba�lant� hatas�!\n", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        
    }
}
