using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.ORM
{
    class Tools
    {
        private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);

        public static SqlConnection Baglanti
        {
            get { return baglanti; }
            set { baglanti = value; }
        }

        public static bool ExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                int etk = cmd.ExecuteNonQuery();
                return etk > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                    cmd.Connection.Close();
            }
        }

    }
}
