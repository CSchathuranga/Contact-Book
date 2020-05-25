namespace Assignment
{
    partial class frmdelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdelete));
            this.radnumber = new System.Windows.Forms.RadioButton();
            this.radname = new System.Windows.Forms.RadioButton();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Label();
            this.txtoffice = new System.Windows.Forms.TextBox();
            this.txthm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtm2 = new System.Windows.Forms.TextBox();
            this.txtm1 = new System.Windows.Forms.TextBox();
            this.txte2 = new System.Windows.Forms.TextBox();
            this.txte1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radnumber
            // 
            this.radnumber.AutoSize = true;
            this.radnumber.Location = new System.Drawing.Point(86, 54);
            this.radnumber.Name = "radnumber";
            this.radnumber.Size = new System.Drawing.Size(113, 17);
            this.radnumber.TabIndex = 11;
            this.radnumber.TabStop = true;
            this.radnumber.Text = "Search by Number";
            this.radnumber.UseVisualStyleBackColor = true;
            this.radnumber.Click += new System.EventHandler(this.radnumber_Click_1);
            // 
            // radname
            // 
            this.radname.AutoSize = true;
            this.radname.Location = new System.Drawing.Point(86, 12);
            this.radname.Name = "radname";
            this.radname.Size = new System.Drawing.Size(104, 17);
            this.radname.TabIndex = 9;
            this.radname.TabStop = true;
            this.radname.Text = "Search by Name";
            this.radname.UseVisualStyleBackColor = true;
            this.radname.Click += new System.EventHandler(this.radname_Click_1);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(215, 51);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(132, 20);
            this.txtnum.TabIndex = 12;
            this.txtnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum_KeyPress);
            // 
            // txtnm
            // 
            this.txtnm.Location = new System.Drawing.Point(215, 9);
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(132, 20);
            this.txtnm.TabIndex = 10;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(374, 12);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(90, 48);
            this.btnsearch.TabIndex = 13;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(383, 320);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(105, 46);
            this.btnupdate.TabIndex = 16;
            this.btnupdate.Text = "Delete";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtfax);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Home);
            this.groupBox2.Controls.Add(this.txtoffice);
            this.groupBox2.Controls.Add(this.txthm);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtm2);
            this.groupBox2.Controls.Add(this.txtm1);
            this.groupBox2.Controls.Add(this.txte2);
            this.groupBox2.Controls.Add(this.txte1);
            this.groupBox2.Location = new System.Drawing.Point(20, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 255);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mobile No";
            // 
            // txtfax
            // 
            this.txtfax.Location = new System.Drawing.Point(112, 214);
            this.txtfax.Name = "txtfax";
            this.txtfax.Size = new System.Drawing.Size(157, 20);
            this.txtfax.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Office";
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Location = new System.Drawing.Point(6, 151);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(35, 13);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            // 
            // txtoffice
            // 
            this.txtoffice.Location = new System.Drawing.Point(112, 184);
            this.txtoffice.Name = "txtoffice";
            this.txtoffice.Size = new System.Drawing.Size(157, 20);
            this.txtoffice.TabIndex = 6;
            // 
            // txthm
            // 
            this.txthm.Location = new System.Drawing.Point(112, 151);
            this.txthm.Name = "txthm";
            this.txthm.Size = new System.Drawing.Size(157, 20);
            this.txthm.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fax";
            // 
            // txtm2
            // 
            this.txtm2.Location = new System.Drawing.Point(112, 114);
            this.txtm2.Name = "txtm2";
            this.txtm2.Size = new System.Drawing.Size(157, 20);
            this.txtm2.TabIndex = 4;
            // 
            // txtm1
            // 
            this.txtm1.Location = new System.Drawing.Point(112, 88);
            this.txtm1.Name = "txtm1";
            this.txtm1.Size = new System.Drawing.Size(157, 20);
            this.txtm1.TabIndex = 3;
            // 
            // txte2
            // 
            this.txte2.Location = new System.Drawing.Point(112, 52);
            this.txte2.Name = "txte2";
            this.txte2.Size = new System.Drawing.Size(157, 20);
            this.txte2.TabIndex = 2;
            // 
            // txte1
            // 
            this.txte1.Location = new System.Drawing.Point(112, 26);
            this.txte1.Name = "txte1";
            this.txte1.Size = new System.Drawing.Size(157, 20);
            this.txte1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Location = new System.Drawing.Point(20, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 125);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(6, 67);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 0;
            this.Address.Text = "Address";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(112, 35);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(248, 20);
            this.txtname.TabIndex = 1;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(112, 67);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(248, 20);
            this.txtaddress.TabIndex = 2;
            // 
            // frmdelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 503);
            this.Controls.Add(this.radnumber);
            this.Controls.Add(this.radname);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtnm);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmdelete";
            this.Text = "Delete Specific Contact";
            this.Load += new System.EventHandler(this.delete_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radnumber;
        private System.Windows.Forms.RadioButton radname;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Home;
        private System.Windows.Forms.TextBox txtoffice;
        private System.Windows.Forms.TextBox txthm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtm2;
        private System.Windows.Forms.TextBox txtm1;
        private System.Windows.Forms.TextBox txte2;
        private System.Windows.Forms.TextBox txte1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtaddress;
    }
}