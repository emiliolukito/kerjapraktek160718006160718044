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
    public partial class FormTambahUser : Form
    {
        public FormTambahUser()
        {
            InitializeComponent();
        }


        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPassword.Text != textBoxUlangiPassword.Text)
                {
                    MessageBox.Show("Ulangi Password tidak sama dengan Password.");
                }
                else
                {
                    User user = new User(textBoxUsername.Text, textBoxPassword.Text);

                    User.TambahData(user);
                    MessageBox.Show("User berhasil ditambah!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambah data, keterangan: " + ex.Message);
            }
        }

        private void buttonKosongi_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxUlangiPassword.Clear();
        }

        private void FormTambahUser_Load(object sender, EventArgs e)
        {

        }
    }
}
