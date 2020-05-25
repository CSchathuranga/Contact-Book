namespace Assignment
{
    partial class frmadd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadd));
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemail1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmp1 = new System.Windows.Forms.TextBox();
            this.Home = new System.Windows.Forms.Label();
            this.txthome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfax = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtoffice = new System.Windows.Forms.TextBox();
            this.txtmp2 = new System.Windows.Forms.TextBox();
            this.txtemail2 = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(112, 35);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(248, 20);
            this.txtname.TabIndex = 0;
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
            // txtemail1
            // 
            this.txtemail1.Location = new System.Drawing.Point(112, 26);
            this.txtemail1.Name = "txtemail1";
            this.txtemail1.Size = new System.Drawing.Size(157, 20);
            this.txtemail1.TabIndex = 0;
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
            // txtmp1
            // 
            this.txtmp1.Location = new System.Drawing.Point(112, 88);
            this.txtmp1.Name = "txtmp1";
            this.txtmp1.Size = new System.Drawing.Size(157, 20);
            this.txtmp1.TabIndex = 2;
            this.txtmp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmp1_KeyPress);
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
            // txthome
            // 
            this.txthome.Location = new System.Drawing.Point(112, 151);
            this.txthome.Name = "txthome";
            this.txthome.Size = new System.Drawing.Size(157, 20);
            this.txthome.TabIndex = 4;
            this.txthome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthome_KeyPress);
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
            // txtfax
            // 
            this.txtfax.Location = new System.Drawing.Point(112, 214);
            this.txtfax.Name = "txtfax";
            this.txtfax.Size = new System.Drawing.Size(157, 20);
            this.txtfax.TabIndex = 6;
            this.txtfax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfax_KeyPress);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(6, 67);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 2;
            this.Address.Text = "Address";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(112, 67);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(248, 20);
            this.txtaddress.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Location = new System.Drawing.Point(23, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtfax);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Home);
            this.groupBox2.Controls.Add(this.txtoffice);
            this.groupBox2.Controls.Add(this.txthome);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtmp2);
            this.groupBox2.Controls.Add(this.txtmp1);
            this.groupBox2.Controls.Add(this.txtemail2);
            this.groupBox2.Controls.Add(this.txtemail1);
            this.groupBox2.Location = new System.Drawing.Point(23, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 255);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Details";
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
            // txtoffice
            // 
            this.txtoffice.Location = new System.Drawing.Point(112, 184);
            this.txtoffice.Name = "txtoffice";
            this.txtoffice.Size = new System.Drawing.Size(157, 20);
            this.txtoffice.TabIndex = 5;
            this.txtoffice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtoffice_KeyPress);
            // 
            // txtmp2
            // 
            this.txtmp2.Location = new System.Drawing.Point(112, 114);
            this.txtmp2.Name = "txtmp2";
            this.txtmp2.Size = new System.Drawing.Size(157, 20);
            this.txtmp2.TabIndex = 3;
            this.txtmp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmp2_KeyPress);
            // 
            // txtemail2
            // 
            this.txtemail2.Location = new System.Drawing.Point(112, 52);
            this.txtemail2.Name = "txtemail2";
            this.txtemail2.Size = new System.Drawing.Size(157, 20);
            this.txtemail2.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(386, 227);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(105, 46);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // btnclr
            // 
            this.btnclr.Location = new System.Drawing.Point(386, 287);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(105, 46);
            this.btnclr.TabIndex = 3;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = true;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click_1);
            // 
            // frmadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 420);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmadd";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemail1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmp1;
        private System.Windows.Forms.Label Home;
        private System.Windows.Forms.TextBox txthome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfax;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtoffice;
        private System.Windows.Forms.TextBox txtmp2;
        private System.Windows.Forms.TextBox txtemail2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnclr;
    }
}

