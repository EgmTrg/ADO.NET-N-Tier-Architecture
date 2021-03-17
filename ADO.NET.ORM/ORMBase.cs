using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.ORM
{
    public class ORMBase<tTable> : IORM<tTable>
    {
        public Type getType
        {
            get { return typeof(tTable); }
        }

        public bool Ekle(tTable t)
        {
            throw new NotImplementedException();
        }

        public bool Guncelle(tTable t)
        {
            throw new NotImplementedException();
        }

        public DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = Tools.Baglanti;
            cmd.CommandText = string.Format("Select{0}", getType.Name);
            cmd.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand = cmd;
            adp.Fill(dt);
            return dt;
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
