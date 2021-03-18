using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.ORM
{
    public class ORMBase<tTable> : IORM<tTable>
    {
        public Type getPropertyType
        {
            get { return typeof(tTable); }
        }

        public bool Ekle(tTable table)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("Insert{0}", getPropertyType.Name);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = Tools.Baglanti;

            PropertyInfo[] customPropertys = getPropertyType.GetProperties();

            foreach (PropertyInfo item in customPropertys)
            {
                cmd.Parameters.AddWithValue($"@{item.Name}", item.GetValue(table));
            }
            return Tools.ExecuteNonQuery(cmd);
        }

        public bool Guncelle(tTable table)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("Update{0}", getPropertyType.Name);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = Tools.Baglanti;

            PropertyInfo[] customPropertys = getPropertyType.GetProperties();

            foreach (PropertyInfo item in customPropertys)
            {
                cmd.Parameters.AddWithValue($"@{item.Name}", item.GetValue(table));
            }
            return Tools.ExecuteNonQuery(cmd);
        }

        public DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = Tools.Baglanti;
            cmd.CommandText = string.Format("Select{0}", getPropertyType.Name);
            cmd.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand = cmd;
            adp.Fill(dt);
            return dt;
        }

        public bool Sil(int id)
        {
            tTable table = Activator.CreateInstance<tTable>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("Delete{0}", getPropertyType.Name);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = Tools.Baglanti;
            PropertyInfo property = getPropertyType.GetProperty("PrimaryKey");

            cmd.Parameters.AddWithValue($"@{property.GetValue(table)}", id);
            return Tools.ExecuteNonQuery(cmd);
        }
    }
}
