
namespace ADO.NET.UI
{
    partial class KitapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.puan_label = new System.Windows.Forms.Label();
            this.kitapAdi_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sayfaSayisi_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sayfaSayisi_label = new System.Windows.Forms.Label();
            this.puani_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yazar_label = new System.Windows.Forms.Label();
            this.yazar_comboBox = new System.Windows.Forms.ComboBox();
            this.Ekle_button = new System.Windows.Forms.Button();
            this.tur_comboBox = new System.Windows.Forms.ComboBox();
            this.kitapAdi_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yenile_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editModeOnOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.sayfaSayisi_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puani_numericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // puan_label
            // 
            this.puan_label.AutoSize = true;
            this.puan_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puan_label.Location = new System.Drawing.Point(500, 10);
            this.puan_label.Name = "puan_label";
            this.puan_label.Size = new System.Drawing.Size(52, 23);
            this.puan_label.TabIndex = 1;
            this.puan_label.Text = "Puani:";
            // 
            // kitapAdi_textBox
            // 
            this.kitapAdi_textBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.kitapAdi_textBox.Location = new System.Drawing.Point(12, 35);
            this.kitapAdi_textBox.Name = "kitapAdi_textBox";
            this.kitapAdi_textBox.Size = new System.Drawing.Size(240, 30);
            this.kitapAdi_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(810, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tür:";
            // 
            // sayfaSayisi_numericUpDown
            // 
            this.sayfaSayisi_numericUpDown.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.sayfaSayisi_numericUpDown.Location = new System.Drawing.Point(661, 36);
            this.sayfaSayisi_numericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sayfaSayisi_numericUpDown.Name = "sayfaSayisi_numericUpDown";
            this.sayfaSayisi_numericUpDown.Size = new System.Drawing.Size(147, 30);
            this.sayfaSayisi_numericUpDown.TabIndex = 3;
            // 
            // sayfaSayisi_label
            // 
            this.sayfaSayisi_label.AutoSize = true;
            this.sayfaSayisi_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayfaSayisi_label.Location = new System.Drawing.Point(657, 10);
            this.sayfaSayisi_label.Name = "sayfaSayisi_label";
            this.sayfaSayisi_label.Size = new System.Drawing.Size(109, 23);
            this.sayfaSayisi_label.TabIndex = 1;
            this.sayfaSayisi_label.Text = "Sayfa Sayisi:";
            // 
            // puani_numericUpDown
            // 
            this.puani_numericUpDown.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.puani_numericUpDown.Location = new System.Drawing.Point(504, 36);
            this.puani_numericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.puani_numericUpDown.Name = "puani_numericUpDown";
            this.puani_numericUpDown.Size = new System.Drawing.Size(151, 30);
            this.puani_numericUpDown.TabIndex = 3;
            // 
            // yazar_label
            // 
            this.yazar_label.AutoSize = true;
            this.yazar_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yazar_label.Location = new System.Drawing.Point(254, 9);
            this.yazar_label.Name = "yazar_label";
            this.yazar_label.Size = new System.Drawing.Size(64, 23);
            this.yazar_label.TabIndex = 1;
            this.yazar_label.Text = "Yazarı:";
            // 
            // yazar_comboBox
            // 
            this.yazar_comboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.yazar_comboBox.FormattingEnabled = true;
            this.yazar_comboBox.Location = new System.Drawing.Point(258, 35);
            this.yazar_comboBox.Name = "yazar_comboBox";
            this.yazar_comboBox.Size = new System.Drawing.Size(240, 31);
            this.yazar_comboBox.TabIndex = 7;
            // 
            // Ekle_button
            // 
            this.Ekle_button.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Ekle_button.Location = new System.Drawing.Point(986, 3);
            this.Ekle_button.Name = "Ekle_button";
            this.Ekle_button.Size = new System.Drawing.Size(159, 31);
            this.Ekle_button.TabIndex = 0;
            this.Ekle_button.Text = "Ekle";
            this.Ekle_button.UseVisualStyleBackColor = true;
            this.Ekle_button.Click += new System.EventHandler(this.ekle_button_Click);
            // 
            // tur_comboBox
            // 
            this.tur_comboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.tur_comboBox.FormattingEnabled = true;
            this.tur_comboBox.Location = new System.Drawing.Point(814, 35);
            this.tur_comboBox.Name = "tur_comboBox";
            this.tur_comboBox.Size = new System.Drawing.Size(166, 31);
            this.tur_comboBox.TabIndex = 7;
            // 
            // kitapAdi_label
            // 
            this.kitapAdi_label.AutoSize = true;
            this.kitapAdi_label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapAdi_label.Location = new System.Drawing.Point(8, 9);
            this.kitapAdi_label.Name = "kitapAdi_label";
            this.kitapAdi_label.Size = new System.Drawing.Size(85, 23);
            this.kitapAdi_label.TabIndex = 1;
            this.kitapAdi_label.Text = "Kitap Adi:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kitapAdi_label);
            this.panel1.Controls.Add(this.tur_comboBox);
            this.panel1.Controls.Add(this.Ekle_button);
            this.panel1.Controls.Add(this.yazar_comboBox);
            this.panel1.Controls.Add(this.yenile_button);
            this.panel1.Controls.Add(this.yazar_label);
            this.panel1.Controls.Add(this.puani_numericUpDown);
            this.panel1.Controls.Add(this.sayfaSayisi_label);
            this.panel1.Controls.Add(this.sayfaSayisi_numericUpDown);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.kitapAdi_textBox);
            this.panel1.Controls.Add(this.puan_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 75);
            this.panel1.TabIndex = 8;
            // 
            // yenile_button
            // 
            this.yenile_button.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.yenile_button.Location = new System.Drawing.Point(986, 35);
            this.yenile_button.Name = "yenile_button";
            this.yenile_button.Size = new System.Drawing.Size(161, 31);
            this.yenile_button.TabIndex = 0;
            this.yenile_button.Text = "Yenile";
            this.yenile_button.UseVisualStyleBackColor = true;
            this.yenile_button.Click += new System.EventHandler(this.yenile_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1157, 632);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editModeOnOffToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1157, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editModeOnOffToolStripMenuItem
            // 
            this.editModeOnOffToolStripMenuItem.Name = "editModeOnOffToolStripMenuItem";
            this.editModeOnOffToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.editModeOnOffToolStripMenuItem.Text = "Edit Mode On/Off";
            this.editModeOnOffToolStripMenuItem.Click += new System.EventHandler(this.editModeOnOffToolStripMenuItem_Click);
            // 
            // KitapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 731);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KitapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapForm";
            this.Load += new System.EventHandler(this.KitapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sayfaSayisi_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puani_numericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label puan_label;
        private System.Windows.Forms.TextBox kitapAdi_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sayfaSayisi_numericUpDown;
        private System.Windows.Forms.Label sayfaSayisi_label;
        private System.Windows.Forms.NumericUpDown puani_numericUpDown;
        private System.Windows.Forms.Label yazar_label;
        private System.Windows.Forms.ComboBox yazar_comboBox;
        private System.Windows.Forms.Button Ekle_button;
        private System.Windows.Forms.ComboBox tur_comboBox;
        private System.Windows.Forms.Label kitapAdi_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button yenile_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editModeOnOffToolStripMenuItem;
    }
}

