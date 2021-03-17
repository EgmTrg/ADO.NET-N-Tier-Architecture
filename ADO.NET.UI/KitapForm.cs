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
    public partial class KitapForm : Form
    {
        public KitapForm()
        {
            InitializeComponent();
        }

        private void KitapForm_Load(object sender, EventArgs e)
        {
            KitapORM kitapORM = new KitapORM();
            dataGridView1.DataSource = kitapORM.Listele();

            dataGridView1.Columns["KitapID"].Visible = false;
            dataGridView1.Columns["TurNo"].Visible = false;
            dataGridView1.Columns["YazarNo"].Visible = false;
            dataGridView1.Columns["YazarID"].Visible = false;
            dataGridView1.Columns["TurID"].Visible = false;
            dataGridView1.Columns["Yazar Adi"].Visible = false;
            dataGridView1.Columns["Yazar Soyadi"].Visible = false;
        }

        private void kaydet_button_Click(object sender, EventArgs e)
        {

        }
    }
}
