using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SI_ManajemenInventori;

namespace KerjaPraktek
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
            
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            this.Enabled = false;

            this.IsMdiContainer = true;

            FormLogin login = new FormLogin();
            login.Owner = this;
            login.Show(); 
        }

        private void keluarSistemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormKategori"];
            if (form == null)
            {
                FormKategori frmKategori = new FormKategori();
                frmKategori.MdiParent = this;
                frmKategori.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void daerahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormDaerah"];
            if (form == null)
            {
                FormDaerah frmDaerah = new FormDaerah();
                frmDaerah.MdiParent = this;
                frmDaerah.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void gudangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormGudang"];
            if (form == null)
            {
                FormGudang frmGudang = new FormGudang();
                frmGudang.MdiParent = this;
                frmGudang.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormUser"];
            if (form == null)
            {
                FormUser frmUser = new FormUser();
                frmUser.MdiParent = this;
                frmUser.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
