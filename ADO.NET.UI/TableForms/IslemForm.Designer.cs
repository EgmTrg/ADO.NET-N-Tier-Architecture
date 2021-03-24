
namespace ADO.NET.UI
{
    partial class IslemForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editModeOnOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vtarih_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.atarih_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kitapName_comboBox = new System.Windows.Forms.ComboBox();
            this.ogrNameSurname_comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editModeOnOffToolStripMenuItem,
            this.yenileToolStripMenuItem,
            this.ekleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editModeOnOffToolStripMenuItem
            // 
            this.editModeOnOffToolStripMenuItem.Name = "editModeOnOffToolStripMenuItem";
            this.editModeOnOffToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.editModeOnOffToolStripMenuItem.Text = "Edit Mode On/Off";
            this.editModeOnOffToolStripMenuItem.Click += new System.EventHandler(this.editModeOnOffToolStripMenuItem_Click);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.yenileToolStripMenuItem.Text = "Yenile";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vtarih_dateTimePicker);
            this.panel1.Controls.Add(this.atarih_dateTimePicker);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.kitapName_comboBox);
            this.panel1.Controls.Add(this.ogrNameSurname_comboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 78);
            this.panel1.TabIndex = 6;
            // 
            // vtarih_dateTimePicker
            // 
            this.vtarih_dateTimePicker.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.vtarih_dateTimePicker.Location = new System.Drawing.Point(786, 38);
            this.vtarih_dateTimePicker.Name = "vtarih_dateTimePicker";
            this.vtarih_dateTimePicker.Size = new System.Drawing.Size(241, 30);
            this.vtarih_dateTimePicker.TabIndex = 2;
            // 
            // atarih_dateTimePicker
            // 
            this.atarih_dateTimePicker.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.atarih_dateTimePicker.Location = new System.Drawing.Point(534, 38);
            this.atarih_dateTimePicker.Name = "atarih_dateTimePicker";
            this.atarih_dateTimePicker.Size = new System.Drawing.Size(241, 30);
            this.atarih_dateTimePicker.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label4.Location = new System.Drawing.Point(782, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Teslim Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.Location = new System.Drawing.Point(530, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Alim Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label2.Location = new System.Drawing.Point(271, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ogrenci Adi/Soyadi";
            // 
            // kitapName_comboBox
            // 
            this.kitapName_comboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.kitapName_comboBox.FormattingEnabled = true;
            this.kitapName_comboBox.Location = new System.Drawing.Point(275, 37);
            this.kitapName_comboBox.Name = "kitapName_comboBox";
            this.kitapName_comboBox.Size = new System.Drawing.Size(253, 31);
            this.kitapName_comboBox.TabIndex = 0;
            // 
            // ogrNameSurname_comboBox
            // 
            this.ogrNameSurname_comboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ogrNameSurname_comboBox.FormattingEnabled = true;
            this.ogrNameSurname_comboBox.Location = new System.Drawing.Point(16, 37);
            this.ogrNameSurname_comboBox.Name = "ogrNameSurname_comboBox";
            this.ogrNameSurname_comboBox.Size = new System.Drawing.Size(253, 31);
            this.ogrNameSurname_comboBox.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 102);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1042, 578);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // IslemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 680);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "IslemForm";
            this.Text = "IslemForm";
            this.Load += new System.EventHandler(this.IslemForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editModeOnOffToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker vtarih_dateTimePicker;
        private System.Windows.Forms.DateTimePicker atarih_dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox kitapName_comboBox;
        private System.Windows.Forms.ComboBox ogrNameSurname_comboBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
    }
}