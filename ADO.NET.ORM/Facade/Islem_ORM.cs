using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.NET.ORM.Entity;

namespace ADO.NET.ORM.Facade
{
    class Islem_ORM
    {
        public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("SelectIslem",Tools.Baglanti);
            DataTable dt = new DataTable();
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.Fill(dt);
            return dt;
        }
        public static bool Insert(Islem islem)
        {
            SqlCommand cmd = new SqlCommand("InsertIslem",Tools.Baglanti);
            cmd.Parameters.AddWithValue("@ogrno",islem.OgrNo);
            cmd.Parameters.AddWithValue("@kitapno",islem.KitapNo);
            cmd.Parameters.AddWithValue("@atrih",islem.aTarih);
            cmd.Parameters.AddWithValue("@vtarih",islem.vTarih);
            return Tools.ExecuteNonQuery(cmd);
        }
    }
}
