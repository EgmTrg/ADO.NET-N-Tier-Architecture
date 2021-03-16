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
            //Listele();
        }

        private void kaydet_button_Click(object sender, EventArgs e)
        {
            /*Kitap kitap = new Kitap();
            kitap.KitapAd = kitapAdi_textBox.Text;
            kitap.SayfaSayisi = Convert.ToInt32(sayfaSayisi_numericUpDown.Value);
            kitap.Puan = Convert.ToInt32(puani_numericUpDown.Value);
            kitap.YazarNo = Convert.ToInt32(yazar_comboBox.SelectedValue);
            kitap.TurNo = Convert.ToInt32(tur_comboBox.SelectedValue);
            bool insert = Kitap_ORM.Insert(kitap);
            if(insert)
                MessageBox.Show("Kayit basarili bir sekilde eklenmistir.");
            else
                MessageBox.Show("Bir hata olustu. Eklenemedi!");
            Listele();*/
        }

        /*private void Listele()
        {
            dataGridView1.DataSource = Kitap_ORM.Select();
            yazar_comboBox.DisplayMember = "Yazar Ad/Soyad";
            yazar_comboBox.ValueMember = "YazarID";
            tur_comboBox.DisplayMember = "Tur Adi";
            tur_comboBox.ValueMember = "TurID";
            yazar_comboBox.DataSource = Kitap_ORM.Select();
            tur_comboBox.DataSource = Kitap_ORM.Select();

            dataGridView1.Columns["KitapID"].Visible = true;
            dataGridView1.Columns["TurID"].Visible = false;
            dataGridView1.Columns["YazarID"].Visible = false;
            dataGridView1.Columns["TurNo"].Visible = false;
            dataGridView1.Columns["YazarNo"].Visible = false;
        }*/

        private void yenile_button_Click(object sender, EventArgs e)
        {
            //Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*kitapAdi_textBox.Text = dataGridView1.CurrentRow.Cells["Kitap Adi"].Value.ToString();
            puani_numericUpDown.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Puan"].Value);
            sayfaSayisi_numericUpDown.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Sayfa Sayisi"].Value);*/
        }
    }
}
