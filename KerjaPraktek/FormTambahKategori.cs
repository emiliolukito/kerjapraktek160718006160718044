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
    public partial class FormTambahKategori : Form
    {
        public FormTambahKategori()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori k = new Kategori(0, textBoxKategori.Text);

                Kategori.TambahData(k);
                MessageBox.Show("Kategori berhasil ditambah!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah data, keterangan: " + ex.Message);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxKategori.Clear();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            string halo = "";
        }
    }
}
