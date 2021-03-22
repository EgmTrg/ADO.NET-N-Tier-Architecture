using ADO.NET.ORM;
using System;
using System.Windows.Forms;

namespace ADO.NET.UI
{
    public partial class TurForm : Form
    {
        TurORM turORM = new TurORM();

        public TurForm()
        {
            InitializeComponent();
        }

        private void TurForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = turORM.Select();
        }
    }
}
