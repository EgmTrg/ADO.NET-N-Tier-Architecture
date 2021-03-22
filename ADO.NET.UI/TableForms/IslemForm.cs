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

namespace ADO.NET.UI
{
    public partial class IslemForm : Form
    {
        public IslemForm()
        {
            InitializeComponent();
        }

        private void IslemForm_Load(object sender, EventArgs e)
        {
            IslemORM islemORM = new IslemORM();
            dataGridView1.DataSource = islemORM.Select();
        }

        private void duzenlemeModuAcKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
