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
    public partial class frmdelete : Form
    {
        public int countNow;
        public frmdelete()
        {
            InitializeComponent();
            radname.Checked = true;
            txtnum.Enabled = false;
        }

        private void delete_Load(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (radname.Checked == true && txtnm.Text != "")
            {
                int counter = 0;
                string line;

                // Read the file and display it line by line.  
                System.IO.StreamReader file = new System.IO.StreamReader(@"..\\...\\phonebook.txt");
                while ((line = file.ReadLine()) != null)
                {
                    //System.Console.WriteLine(line);
                    string[] item = line.Split('%');
                    if (item[0].Equals(txtnm.Text))
                    {
                        setValue(item);
                        countNow = counter;
                    }
                    counter++;
                }
                file.Close();
            }
            else if (radnumber.Checked == true && txtnum.Text != "")
            {
                int counter = 0;
                string line;

                // Read the file and display it line by line.  
                System.IO.StreamReader file = new System.IO.StreamReader(@"..\\...\\phonebook.txt");
                while ((line = file.ReadLine()) != null)
                {
                    //System.Console.WriteLine(line);
                    string[] item = line.Split('%');
                    if (item[1].Equals(txtnum.Text) || item[2].Equals(txtnum.Text) || item[3].Equals(txtnum.Text) || item[4].Equals(txtnum.Text) || item[7].Equals(txtnum.Text))
                    {
                        setValue(item);
                        countNow = counter;
                    }
                    counter++;
                }
                file.Close();
            }
            else if (radnumber.Checked == false && radnumber.Checked == false)
            {

            }
        }
        void setValue(string[] item)
        {
            txtname.Text = item[0];
            txtaddress.Text = item[8];
            txte1.Text = item[5];
            txte2.Text = item[6];
            txtm1.Text = item[1];
            txtm2.Text = item[2];
            txthm.Text = item[3];
            txtoffice.Text = item[4];
            txtfax.Text = item[7];
        }
        private void radnumber_Click_1(object sender, EventArgs e)
        {
            txtnm.Enabled = false;
            txtnum.Enabled = true;
        }

        private void radname_Click_1(object sender, EventArgs e)
        {
            txtnum.Enabled = false;
            txtnm.Enabled = true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string update = "%" + "%" + "%" + "%" + "%" + "%" + "%" + "%";
            String path = "..\\...\\phonebook.txt";
            var lines = File.ReadAllLines(path);
            lines[countNow] = update;
            File.WriteAllLines(path, lines);
            this.Close();
        }

        private void txtnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
