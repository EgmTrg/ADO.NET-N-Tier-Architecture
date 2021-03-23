using ADO.NET.Entity;
using ADO.NET.ORM;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ADO.NET.UI
{
    public partial class IslemForm : Form
    {
        IslemORM islemORM = new IslemORM();
        KitapORM kitapORM = new KitapORM();
        //OgrenciORM ogrenciORM = new OgrenciORM();

        Dictionary<string, string> CurrentRowItems = new Dictionary<string, string>();

        public IslemForm()
        {
            InitializeComponent();
        }

        private void IslemForm_Load(object sender, EventArgs e)
        {
            RefreshDataSource();
            CurrentRowItems.Add("islemno", "");
            CurrentRowItems.Add("kitapno", "");
            CurrentRowItems.Add("ogrno", "");
            CurrentRowItems.Add("atarih", "");
            CurrentRowItems.Add("vtarih", "");

            kitapName_comboBox.DataSource = kitapORM.Select();
            kitapName_comboBox.DisplayMember = "Kitap Adi";
            kitapName_comboBox.ValueMember = "KitapID";

            /*ogrNameSurname_comboBox.DataSource = ogrenciORM.Select();
            ogrNameSurname_comboBox.DisplayMember = "Ogrenci Adi";
            ogrNameSurname_comboBox.ValueMember = "OgrenciID";*/

            ogrNameSurname_comboBox.DataSource = islemORM.Select();
            ogrNameSurname_comboBox.DisplayMember = "Ogrenci Adi";
            ogrNameSurname_comboBox.ValueMember = "OgrenciNo";
        }

        private void RefreshDataSource()
        {
            dataGridView.DataSource = islemORM.Select();

            dataGridView.Columns["islemNo"].Visible = false;
            dataGridView.Columns["kitapno"].Visible = false;

            dataGridView.Columns[0].Width = 100;
            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[2].Width = 120;
            dataGridView.Columns[3].Width = 90;
            dataGridView.Columns[4].Width = 300;
            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[6].Width = 100;
        }

        private void editModeOnOffToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                                                  $"Verileri güncellemek istediğinzden eminmisiniz? \n\n" +
                                                  $"Alim Tarihi = {CurrentRowItems["atarih"]} => {dataGridView.CurrentRow.Cells["Alim Tarihi"].Value}\n" +
                                                  $"Teslim Tarihi = {CurrentRowItems["vtarih"]} => {dataGridView.CurrentRow.Cells["Teslim Tarihi"].Value}\n\n" +
                                                  $"Dipnot: OgrenciNo, Adi, Soyadi güncellemek istiyorsanız kaydı silip tekrar eklemelisiniz!",
                                                  "İşlem Durumu!",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Islem islem = new Islem();
                islem.islemno = Convert.ToInt32(CurrentRowItems["islemno"]);
                islem.kitapno = Convert.ToInt32(CurrentRowItems["kitapno"]);
                islem.ogrno = Convert.ToInt32(CurrentRowItems["ogrno"]);
                islem.atarih = Convert.ToDateTime(dataGridView.CurrentRow.Cells["Alim Tarihi"].Value);
                islem.vtarih = Convert.ToDateTime(dataGridView.CurrentRow.Cells["Teslim Tarihi"].Value);

                bool statement = islemORM.Update(islem);
                IslemDurumu(statement);
            }
            else
                MessageBox.Show("İşleminiz başarısız!.", "İşlem Durumu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void IslemDurumu(bool statement)
        {
            if (statement)
                MessageBox.Show("İşleminiz başarılı bir şekilde gerçekleşmiştir.", "İşlem Durumu!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("İşleminiz başarısız!", "İşlem Durumu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            RefreshDataSource();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentRowItems["islemno"] = dataGridView.CurrentRow.Cells["IslemNo"].Value.ToString();
            CurrentRowItems["kitapno"] = dataGridView.CurrentRow.Cells["KitapNo"].Value.ToString();
            CurrentRowItems["ogrno"] = dataGridView.CurrentRow.Cells["OgrenciNo"].Value.ToString();
            CurrentRowItems["atarih"] = dataGridView.CurrentRow.Cells["Alim Tarihi"].Value.ToString();
            CurrentRowItems["vtarih"] = dataGridView.CurrentRow.Cells["Teslim Tarihi"].Value.ToString();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ogrNameSurname_comboBox.Text) && !string.IsNullOrEmpty(kitapName_comboBox.Text))
            {
                Islem islem = new Islem();
                islem.atarih = Convert.ToDateTime(atarih_dateTimePicker.Value);
                islem.vtarih = Convert.ToDateTime(vtarih_dateTimePicker.Value);
                islem.kitapno = Convert.ToInt32(kitapName_comboBox.SelectedValue);
                islem.ogrno = Convert.ToInt32(ogrNameSurname_comboBox.SelectedValue);

                bool durum = islemORM.Insert(islem);
                IslemDurumu(durum);
            }
            else
                MessageBox.Show("Lutfen Bos Alanlari Doldurunuz!", "İşlem Durumu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void kitapName_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //delete
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                bool durum = islemORM.Delete(Convert.ToInt32(dataGridView.CurrentRow.Cells["IslemNo"].Value));
                IslemDurumu(durum);
            }
        }
    }
}
