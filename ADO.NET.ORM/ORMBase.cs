using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace ADO.NET.ORM
{
    public class ORMBase<tTable> : IORM<tTable> where tTable : class
    {
        public Type getPropertyType
        {
            get { return typeof(tTable); }
        }

        // Ekle ve select sorgulari neredeyse ayni. Bunlari tek bir methoda donustur.

        public bool Insert(tTable table)
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

        public bool Update(tTable table)
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

        public DataTable Select()
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

        public bool Delete(int id)
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
