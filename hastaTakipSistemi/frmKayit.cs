using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace hastaTakipSistemi
{
    public partial class frmKayit : Form
    {
        public frmKayit()
        {
            InitializeComponent();
        }

        private void frmKayit_Load(object sender, EventArgs e)
        {

        }
        frmSqlBaglanti bgl = new frmSqlBaglanti();

        private void btnKayit_Click(object sender, EventArgs e)
        {
            /* if (txtKulAdi.Text != "" && txtSifre.Text != "")
             {
                 SqlCommand kayit = new SqlCommand("kayitOl", bgl.baglan());
                 kayit.CommandType= CommandType.StoredProcedure;
                 kayit.Parameters.AddWithValue("@kullaniciAdi", txtKulAdi.Text);
                 kayit.Parameters.AddWithValue("@sifre", txtSifre.Text);
                 kayit.ExecuteNonQuery();
                 MessageBox.Show("Kayıt İşlemi Başarılı", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else
             {
                 MessageBox.Show("Lütfen Boş Alan Bırakmayınız" , "Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
             }*/
            if (!string.IsNullOrEmpty(txtKulAdi.Text) && !string.IsNullOrEmpty(txtSifre.Text))
            {
                // bgl.baglan() metodundan gelen açık bağlantıyı bir değişkene atıyoruz
                SqlConnection baglanti = bgl.baglan();

                try
                {
                    SqlCommand kayit = new SqlCommand("kayitOl", baglanti);
                    kayit.CommandType = CommandType.StoredProcedure;

                    // Parametrelerin başına '@' eklendi
                    kayit.Parameters.AddWithValue("@kulAdi", txtKulAdi.Text);
                    kayit.Parameters.AddWithValue("@sifre", txtSifre.Text);

                    // Komut çalıştırılıyor
                    kayit.ExecuteNonQuery();

                    MessageBox.Show("Kayıt İşlemi Başarılı", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Eğer SQL tarafında bir hata oluşursa (Örn: Aynı kullanıcı adından varsa) program çökmez, hatayı gösterir.
                    MessageBox.Show("Veritabanı Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Hata oluşsa da oluşmasa da bağlantı mutlaka güvenli bir şekilde kapatılır.
                    if (baglanti != null && baglanti.State == ConnectionState.Open)
                    {
                        baglanti.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
