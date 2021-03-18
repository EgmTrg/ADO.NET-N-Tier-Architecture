using ADO.NET.Entity;
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
        KitapORM kitapORM = new KitapORM();

        public KitapForm()
        {
            InitializeComponent();
        }

        private void KitapForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();

            yazar_comboBox.DataSource = kitapORM.Listele();// burayada yazar tablosu gelecek. O da daha eklenmedigi icin yazmadim.
            yazar_comboBox.DisplayMember = "Yazar Ad/Soyad";
            yazar_comboBox.ValueMember = "YazarID";

            tur_comboBox.DataSource = kitapORM.Listele(); // burada normalde tur tablosu gelecek. Ama daha eklenemdiginden dolayi bunu yazdim.
            tur_comboBox.DisplayMember = "Tur Adi";
            tur_comboBox.ValueMember = "TurID";
        }

        private void RefreshDataGridView()
        {
            dataGridView1.DataSource = kitapORM.Listele();

            /*dataGridView1.Columns["KitapID"].Visible = false;
            dataGridView1.Columns["TurNo"].Visible = false;
            dataGridView1.Columns["YazarNo"].Visible = false;
            dataGridView1.Columns["YazarID"].Visible = false;
            dataGridView1.Columns["TurID"].Visible = false;
            dataGridView1.Columns["Yazar Adi"].Visible = false;
            dataGridView1.Columns["Yazar Soyadi"].Visible = false;*/
        }

        private void kaydet_button_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.ad = kitapAdi_textBox.Text;
            kitap.puan = Convert.ToInt32(puani_numericUpDown.Value);
            kitap.sayfasayisi = Convert.ToInt32(sayfaSayisi_numericUpDown.Value);
            kitap.yazarno = Convert.ToInt32(yazar_comboBox.SelectedValue);
            kitap.turno = Convert.ToInt32(tur_comboBox.SelectedValue);

            kitapORM.Ekle(kitap);
        }

        private void yenile_button_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void temizle_button_Click(object sender, EventArgs e)
        {
            kitapORM.Sil(Convert.ToInt32(kitapAdi_textBox.Tag));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kitapAdi_textBox.Text = dataGridView1.CurrentRow.Cells["Kitap Adi"].Value.ToString();
            kitapAdi_textBox.Tag = (int)dataGridView1.CurrentRow.Cells["KitapID"].Value;
            puani_numericUpDown.Value = (int)dataGridView1.CurrentRow.Cells["Puan"].Value;
            sayfaSayisi_numericUpDown.Value = (int)dataGridView1.CurrentRow.Cells["Sayfa Sayisi"].Value;
            yazar_comboBox.SelectedValue = (int)dataGridView1.CurrentRow.Cells["YazarID"].Value;
        }
    }
}
