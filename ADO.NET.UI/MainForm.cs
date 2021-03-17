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
        KitapForm kf = new KitapForm();
        IslemForm islemform = new IslemForm();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void kitapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kf.IsDisposed)
                kf = new KitapForm();
            kf.MdiParent = this;
            kf.Show();
        }

        private void ıslemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (islemform.IsDisposed)
                islemform = new IslemForm();
            islemform.MdiParent = this;
            islemform.Show();
        }
    }
}
