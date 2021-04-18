using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KerjaPraktek
{
    public partial class FormKategori : Form
    {
        public FormKategori()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahKategori tambah = new FormTambahKategori();
            tambah.Owner = this;
            tambah.Show();
        }
    }
}
