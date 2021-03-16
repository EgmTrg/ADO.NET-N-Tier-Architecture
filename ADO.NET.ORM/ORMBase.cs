using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.ORM
{
    public class ORMBase<tTable> : IORM<tTable>
    {
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
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
