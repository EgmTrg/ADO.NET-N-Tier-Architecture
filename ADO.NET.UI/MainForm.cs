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
    public partial class MainForm : Form
    {
        KitapForm kitapForm = new KitapForm();
        IslemForm islemform = new IslemForm();
        TurForm turForm = new TurForm();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void kitapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kitapForm.IsDisposed)
                kitapForm = new KitapForm();
            kitapForm.MdiParent = this;
            kitapForm.Show();
        }

        private void ıslemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (islemform.IsDisposed)
                islemform = new IslemForm();
            islemform.MdiParent = this;
            islemform.Show();
        }

        private void turToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (turForm.IsDisposed)
                turForm = new TurForm();
            turForm.MdiParent = this;
            turForm.Show();
        }
    }
}
