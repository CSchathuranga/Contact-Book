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
    public partial class frmmain : Form
    {
        public static string nametext;
        public static string saddress;
        public static string email1;
        public static string semail2;
        public static string mobile1;
        public static string mobile2;
        public static string shome;
        public static string soffice;
        public static string sfax;

        public frmmain()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            readData();
            radname.Checked = true;
            txtnum.Enabled = false;
            lbluser.Text = user.current;
            loginTime();
            this.BringToFront();
            this.Focus();
            this.KeyPreview = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmadd add = new frmadd();
            add.Show();
        }
        //read data from the phonebook.txt
        void readData()
        {
            table.Rows.Clear();
            String path = "..\\...\\phonebook.txt";
            string[] fields  = File.ReadAllLines(path);
            
           for (int i = 0; i < fields.Length; i++)
            {
                string[] row = fields[i].Split('%');
                if (row[0] == "") continue;
                table.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7],row[8]);
            }
        }

        private void frmmain_Activated(object sender, EventArgs e)
        {
            readData();
            toolStripStatusLabel2.Text = "Total No of records:" + table.RowCount.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            frmupdate win = new frmupdate();
            win.Show();
        }

        private void radname_Click(object sender, EventArgs e)
        {
            txtnum.Enabled = false;
            txtnm.Enabled = true;
        }
        private void radnumber_Click(object sender, EventArgs e)
        {
            txtnm.Enabled = false;
            txtnum.Enabled =true;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (radname.Checked == true)
            {
                
                for (int i = 0; i < table.RowCount; i++)
                {
                    string s = table.Rows[i].Cells[0].Value.ToString();
                    if (s.Equals(txtnm.Text.ToString()))
                    {
                        frmview win = new frmview();
                        setValue(i);
                        win.Show();
                    }
                }
            }else if (radnumber.Checked == true)
            {
                for (int i = 0; i < table.RowCount; i++)
                {
                    string s1 = table.Rows[i].Cells[1].Value.ToString();
                    string s2 = table.Rows[i].Cells[2].Value.ToString();
                    string s3 = table.Rows[i].Cells[3].Value.ToString();
                    string s4 = table.Rows[i].Cells[4].Value.ToString();
                    string s5 = table.Rows[i].Cells[7].Value.ToString();
                    if (s1.Equals(txtnum.Text)|| s2.Equals(txtnum.Text)|| s3.Equals(txtnum.Text)||s4.Equals(txtnum.Text)|| s1.Equals(txtnum.Text))
                    {
                        frmview win = new frmview();
                        setValue(i);
                        win.Show();
                    }
                }
            }
            else if(radnumber.Checked ==false && radnumber.Checked == false)
            {

            }
        }
        private void setValue(int i)
        {
            nametext = table.Rows[i].Cells[0].Value.ToString();
            saddress = table.Rows[i].Cells[1].Value.ToString();
            email1 = table.Rows[i].Cells[2].Value.ToString();
            semail2 = table.Rows[i].Cells[3].Value.ToString();
            mobile1 = table.Rows[i].Cells[4].Value.ToString();
            mobile2 = table.Rows[i].Cells[5].Value.ToString();
            shome = table.Rows[i].Cells[6].Value.ToString();
            soffice = table.Rows[i].Cells[7].Value.ToString();
            sfax = table.Rows[i].Cells[8].Value.ToString();
    }
        
        private void btndeletefull_Click(object sender, EventArgs e)
        {
            frmdelete win = new frmdelete();
            win.Show();
        }
        //set last login time
        private void loginTime()
        {
            String path = "..\\...\\system.txt";
            string[] fields = File.ReadAllLines(path);
            toolStripStatusLabel1.Text = "Last login time: " + fields[fields.Length-1];
            statusStrip1.Show();
            statusStrip1.Refresh();
        }
        //save last login time
        private void saveLogin()
        {
            DateTime dateTimeNow = DateTime.Now;
            string formattedTime = dateTimeNow.ToString("yyyy/MM/dd hh:mm:ss");
            string path = "..\\...\\system.txt";
            StreamWriter doc = new StreamWriter(path, true);
            doc.WriteLine(formattedTime);
            doc.Close();
        }

        private void frmmain_FormClosing(object sender, FormClosingEventArgs e)
        {

            string message = "Do you want to Exit?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            saveLogin();
        }
        private void frmmain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                btnadd.PerformClick();
            }
            if (e.KeyCode == Keys.F4)
            {
                btnupdate.PerformClick();
            }
            if (e.KeyCode == Keys.F6)
            {
                btndeletefull.PerformClick();
            }
            if (e.KeyCode == Keys.F10)
            {
                btnsearch.PerformClick();
            }
        }

        private void txtnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
