using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.ORM
{
    public interface IORM<Table>
    {
        DataTable Listele();
        bool Ekle(Table t);
        bool Guncelle(Table t);
        bool Sil(int id);
    }
}
