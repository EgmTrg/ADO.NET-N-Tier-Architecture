using ADO.NET.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET.UI.Pages
{
    public partial class SelectPage : Form
    {
        KitapORM kitapORM = new KitapORM();

        public SelectPage()
        {
            InitializeComponent();
        }
    }
}
