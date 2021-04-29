namespace KerjaPraktek
{
    partial class FormUtama
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
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daerahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gudangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangKeluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prosesBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangKeluarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarSistemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.barangKeluarToolStripMenuItem,
            this.keluarSistemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(557, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriToolStripMenuItem,
            this.daerahToolStripMenuItem,
            this.gudangToolStripMenuItem,
            this.userToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.kategoriToolStripMenuItem.Text = "Kategori";
            this.kategoriToolStripMenuItem.Click += new System.EventHandler(this.kategoriToolStripMenuItem_Click);
            // 
            // daerahToolStripMenuItem
            // 
            this.daerahToolStripMenuItem.Name = "daerahToolStripMenuItem";
            this.daerahToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.daerahToolStripMenuItem.Text = "Daerah";
            this.daerahToolStripMenuItem.Click += new System.EventHandler(this.daerahToolStripMenuItem_Click);
            // 
            // gudangToolStripMenuItem
            // 
            this.gudangToolStripMenuItem.Name = "gudangToolStripMenuItem";
            this.gudangToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.gudangToolStripMenuItem.Text = "Gudang";
            this.gudangToolStripMenuItem.Click += new System.EventHandler(this.gudangToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // barangKeluarToolStripMenuItem
            // 
            this.barangKeluarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahBarangToolStripMenuItem,
            this.prosesBarangToolStripMenuItem,
            this.barangKeluarToolStripMenuItem1});
            this.barangKeluarToolStripMenuItem.Name = "barangKeluarToolStripMenuItem";
            this.barangKeluarToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.barangKeluarToolStripMenuItem.Text = "Barang";
            // 
            // tambahBarangToolStripMenuItem
            // 
            this.tambahBarangToolStripMenuItem.Name = "tambahBarangToolStripMenuItem";
            this.tambahBarangToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.tambahBarangToolStripMenuItem.Text = "Tambah Barang";
            // 
            // prosesBarangToolStripMenuItem
            // 
            this.prosesBarangToolStripMenuItem.Name = "prosesBarangToolStripMenuItem";
            this.prosesBarangToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.prosesBarangToolStripMenuItem.Text = "Proses Barang";
            // 
            // barangKeluarToolStripMenuItem1
            // 
            this.barangKeluarToolStripMenuItem1.Name = "barangKeluarToolStripMenuItem1";
            this.barangKeluarToolStripMenuItem1.Size = new System.Drawing.Size(252, 30);
            this.barangKeluarToolStripMenuItem1.Text = "Barang Keluar";
            // 
            // keluarSistemToolStripMenuItem
            // 
            this.keluarSistemToolStripMenuItem.Name = "keluarSistemToolStripMenuItem";
            this.keluarSistemToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.keluarSistemToolStripMenuItem.Text = "Keluar Sistem";
            this.keluarSistemToolStripMenuItem.Click += new System.EventHandler(this.keluarSistemToolStripMenuItem_Click);
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 402);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormUtama";
            this.Text = "SI Manajemen Inventori UD Setia Makmur";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daerahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gudangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangKeluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarSistemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prosesBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangKeluarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
    }
}

