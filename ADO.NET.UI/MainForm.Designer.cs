
namespace ADO.NET.UI
{
    partial class MainForm
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
            this.anonimKitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıslemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitap2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siniflarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anonimKitaplarToolStripMenuItem,
            this.ıslemToolStripMenuItem,
            this.kitapToolStripMenuItem,
            this.kitap2ToolStripMenuItem,
            this.ogrenciToolStripMenuItem,
            this.siniflarToolStripMenuItem,
            this.turToolStripMenuItem,
            this.yazarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anonimKitaplarToolStripMenuItem
            // 
            this.anonimKitaplarToolStripMenuItem.Name = "anonimKitaplarToolStripMenuItem";
            this.anonimKitaplarToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.anonimKitaplarToolStripMenuItem.Text = "AnonimKitaplar";
            // 
            // ıslemToolStripMenuItem
            // 
            this.ıslemToolStripMenuItem.Name = "ıslemToolStripMenuItem";
            this.ıslemToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ıslemToolStripMenuItem.Text = "Islem";
            this.ıslemToolStripMenuItem.Click += new System.EventHandler(this.ıslemToolStripMenuItem_Click);
            // 
            // kitapToolStripMenuItem
            // 
            this.kitapToolStripMenuItem.Name = "kitapToolStripMenuItem";
            this.kitapToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.kitapToolStripMenuItem.Text = "Kitap";
            this.kitapToolStripMenuItem.Click += new System.EventHandler(this.kitapToolStripMenuItem_Click);
            // 
            // kitap2ToolStripMenuItem
            // 
            this.kitap2ToolStripMenuItem.Name = "kitap2ToolStripMenuItem";
            this.kitap2ToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.kitap2ToolStripMenuItem.Text = "Kitap2";
            // 
            // ogrenciToolStripMenuItem
            // 
            this.ogrenciToolStripMenuItem.Name = "ogrenciToolStripMenuItem";
            this.ogrenciToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ogrenciToolStripMenuItem.Text = "Ogrenci";
            // 
            // siniflarToolStripMenuItem
            // 
            this.siniflarToolStripMenuItem.Name = "siniflarToolStripMenuItem";
            this.siniflarToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.siniflarToolStripMenuItem.Text = "Siniflar";
            // 
            // turToolStripMenuItem
            // 
            this.turToolStripMenuItem.Name = "turToolStripMenuItem";
            this.turToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.turToolStripMenuItem.Text = "Tur";
            this.turToolStripMenuItem.Click += new System.EventHandler(this.turToolStripMenuItem_Click);
            // 
            // yazarToolStripMenuItem
            // 
            this.yazarToolStripMenuItem.Name = "yazarToolStripMenuItem";
            this.yazarToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.yazarToolStripMenuItem.Text = "Yazar";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kitapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ıslemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anonimKitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitap2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siniflarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarToolStripMenuItem;
    }
}