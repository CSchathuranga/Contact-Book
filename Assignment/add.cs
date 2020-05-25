using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class frmadd : Form
    {
        String path = "..\\...\\phonebook.txt";
        public frmadd()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                string message = "You can not have empty name field";
                string title = "Name Field Empty";
                MessageBox.Show(message, title);
            }
            else
            {
                StreamWriter doc = new StreamWriter(path, true);
                doc.WriteLine(txtname.Text + "%" + txtmp1.Text + "%" + txtmp2.Text + "%" + txthome.Text + "%" + txtoffice.Text + "%" + txtemail1.Text + "%" + txtemail2.Text + "%" + txtfax.Text + "%" + txtaddress.Text);
                doc.Close();
                this.Close();
            }
            
        }

        private void btnclr_Click_1(object sender, EventArgs e)
        {
            txtaddress.Text = "";
            txtemail1.Text = "";
            txtemail2.Text = "";
            txtfax.Text = "";
            txthome.Text = "";
            txtmp1.Text = "";
            txtmp2.Text = "";
            txtname.Text = "";
            txtoffice.Text = "";
        }

        private void txtmp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtmp2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txthome_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtoffice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtfax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
