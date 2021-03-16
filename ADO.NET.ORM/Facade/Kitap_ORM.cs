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
    public class Kitap_ORM
    {
        //  Select Methodu
        public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("SelectKitap", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        //  Insert Methodu
        public static bool Insert(Kitap k)
        {
            SqlCommand cmd = new SqlCommand("InsertKitap", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ad", k.KitapAd);
            cmd.Parameters.AddWithValue("@sayfasayisi", k.SayfaSayisi);
            cmd.Parameters.AddWithValue("@puan", k.Puan);
            cmd.Parameters.AddWithValue("@yazarno", k.YazarNo);
            cmd.Parameters.AddWithValue("@turno", k.TurNo);
            return Tools.ExecuteNonQuery(cmd);
        }
        //  Update Methodu
        //  Delete Methodu
    }
}
