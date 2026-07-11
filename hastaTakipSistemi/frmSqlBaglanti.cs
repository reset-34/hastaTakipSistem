using System.Data.SqlClient;

namespace hastaTakipSistemi
{
    internal class frmSqlBaglanti
    {
        string adres = @"Data Source=LAPTOP-IDH67BD8;Initial Catalog=db_HastaneYonetim;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public SqlConnection baglan()


        {
            SqlConnection baglanti = new SqlConnection(adres);
            baglanti.Open();                
            return baglanti;
        }

    }
}
