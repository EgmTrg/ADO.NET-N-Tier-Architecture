using ADO.NET.ORM;
using System;
using System.Windows.Forms;

namespace ADO.NET.UI
{
    public partial class TurForm : Form, ITools
    {
        TurORM turORM = new TurORM();
        #region Interface Methods
        public void EditMode()
        {
            /*if (panel1.Visible)
            {
                panel1.Visible = false;
                ekleToolStripMenuItem.Visible = false;
            }
            else
            {
                panel1.Visible = true;
                ekleToolStripMenuItem.Visible = true;
            }*/
        }

        public void TransactionStatus(bool statement)
        {
            if (statement)
                MessageBox.Show("İşleminiz başarılı bir şekilde gerçekleşmiştir.", "İşlem Durumu!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("İşleminiz başarısız!", "İşlem Durumu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            RefreshDataSource();
        }

        public void RefreshDataSource()
        {
            dataGridView1.DataSource = turORM.Select();
        }

        public void KeyDown_HotKeys(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                bool durum = turORM.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells["IslemNo"].Value));
                TransactionStatus(durum);
            }
        }
        #endregion
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
