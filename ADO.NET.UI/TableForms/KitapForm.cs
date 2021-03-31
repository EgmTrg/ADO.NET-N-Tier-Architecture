using ADO.NET.Entity;
using ADO.NET.ORM;
using ADO.NET.ORM.TableORMs;
using System;
using System.IO;
using System.Windows.Forms;

namespace ADO.NET.UI
{
    public partial class KitapForm : Form, ITools
    {
        KitapORM kitapORM = new KitapORM();
        TurORM turORM = new TurORM();
        #region Interface Methods
        public void EditMode()
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;
                ekleToolStripMenuItem.Visible = false;
            }
            else
            {
                panel1.Visible = true;
                ekleToolStripMenuItem.Visible = true;
            }
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
            dataGridView1.DataSource = kitapORM.Select();

            dataGridView1.Columns["KitapID"].Visible = false;
            dataGridView1.Columns["TurNo"].Visible = false;
            dataGridView1.Columns["YazarNo"].Visible = false;
            dataGridView1.Columns["YazarID"].Visible = false;
            dataGridView1.Columns["TurID"].Visible = false;
            dataGridView1.Columns["Yazar Adi"].Visible = false;
            dataGridView1.Columns["Yazar Soyadi"].Visible = false;
        }

        public void KeyDown_HotKeys(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                bool durum = kitapORM.Delete(Convert.ToInt32(dataGridView1.CurrentRow.Cells["IslemNo"].Value));
                TransactionStatus(durum);
            }
        }
        #endregion

        public KitapForm()
        {
            InitializeComponent();
        }

        private void KitapForm_Load(object sender, EventArgs e)
        {
            RefreshDataSource();

            yazar_comboBox.DataSource = kitapORM.Select();// burayada yazar tablosu gelecek. O da daha eklenmedigi icin yazmadim.
            yazar_comboBox.DisplayMember = "Yazar Ad/Soyad";
            yazar_comboBox.ValueMember = "YazarID";

            tur_comboBox.DataSource = turORM.Select(); // burada normalde tur tablosu gelecek. Ama daha eklenemdiginden dolayi bunu yazdim.
            tur_comboBox.DisplayMember = "Tur Adi";
            tur_comboBox.ValueMember = "TurID";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kitapAdi_textBox.Text = dataGridView1.CurrentRow.Cells["Kitap Adi"].Value.ToString();
            kitapAdi_textBox.Tag = (int)dataGridView1.CurrentRow.Cells["KitapID"].Value;
            puani_numericUpDown.Value = (int)dataGridView1.CurrentRow.Cells["Puan"].Value;
            sayfaSayisi_numericUpDown.Value = (int)dataGridView1.CurrentRow.Cells["Sayfa Sayisi"].Value;
            yazar_comboBox.SelectedValue = (int)dataGridView1.CurrentRow.Cells["YazarID"].Value;
        }

        private void editModeOnOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMode();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            //KeyDown_HotKeys();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.kitapno = Convert.ToInt32(kitapAdi_textBox.Tag);
            kitap.ad = dataGridView1.CurrentRow.Cells["Kitap Adi"].Value.ToString();
            kitap.puan = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Puan"].Value);
            kitap.sayfasayisi = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Sayfa Sayisi"].Value);
            kitap.yazarno = Convert.ToInt32(yazar_comboBox.SelectedValue);
            kitap.turno = Convert.ToInt32(tur_comboBox.SelectedValue);

            bool durum = kitapORM.Update(kitap);
            TransactionStatus(durum);
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.ad = kitapAdi_textBox.Text;
            kitap.puan = Convert.ToInt32(puani_numericUpDown.Value);
            kitap.sayfasayisi = Convert.ToInt32(sayfaSayisi_numericUpDown.Value);
            kitap.yazarno = Convert.ToInt32(yazar_comboBox.SelectedValue);
            kitap.turno = Convert.ToInt32(tur_comboBox.SelectedValue);

            bool durum = kitapORM.Insert(kitap);
            TransactionStatus(durum);
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshDataSource();
            }
            catch(Exception) { }
        }

        private void resimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            int id = (int)dataGridView1.CurrentRow.Cells["KitapID"].Value;
            openFileDialog1.Filter = "Jpg |*.jpg|Png |*.png";

            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader binary = new BinaryReader(fs);
                byte[] resim = binary.ReadBytes((int)fs.Length);
                binary.Close();
                fs.Close();

                KitapResim kr = new KitapResim();
                kr.kitapno = id;
                kr.resim = resim;
                if (new KitapResimORM().Insert(kr))
                {
                    MessageBox.Show("Resim eklendi");
                }
                else
                {
                    MessageBox.Show("Resim eklenemedi");
                }
            }
        }
    }
}
