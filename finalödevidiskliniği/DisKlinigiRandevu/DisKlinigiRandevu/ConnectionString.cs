using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DisKlinigiRandevu
{
    internal class ConnectionString
    {
        public SqlConnection GetCon()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = @"Data Source=DESKTOP-SEC2336\SQLEXPRESS;Initial Catalog=DisHekimligiRandevu;Integrated Security=True;Encrypt=False";
            return baglanti;
        }
    }
}
