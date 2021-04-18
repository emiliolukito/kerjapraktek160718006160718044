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
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {

            Form form = Application.OpenForms["FormTambahUser"];
            if(form == null)
            {
                FormTambahBarang formTambahBarang = new FormTambahBarang();
                formTambahBarang.Owner = this;
                formTambahBarang.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
