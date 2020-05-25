namespace Assignment
{
    partial class frmmain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.label1 = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.table = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileno1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileno2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.home = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.office = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.radname = new System.Windows.Forms.RadioButton();
            this.radnumber = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndeletefull = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(66, 42);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(121, 23);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "User Name";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 574);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(978, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(0, 3, 200, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabel1.Text = "time last login";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(0, 3, 15, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.mobileno1,
            this.mobileno2,
            this.home,
            this.office,
            this.email,
            this.email2,
            this.fax,
            this.address});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle2;
            this.table.Location = new System.Drawing.Point(16, 148);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(946, 339);
            this.table.TabIndex = 2;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // mobileno1
            // 
            this.mobileno1.HeaderText = "Mobile No";
            this.mobileno1.Name = "mobileno1";
            this.mobileno1.ReadOnly = true;
            // 
            // mobileno2
            // 
            this.mobileno2.HeaderText = "Mobile No";
            this.mobileno2.Name = "mobileno2";
            this.mobileno2.ReadOnly = true;
            // 
            // home
            // 
            this.home.HeaderText = "Home";
            this.home.Name = "home";
            this.home.ReadOnly = true;
            // 
            // office
            // 
            this.office.HeaderText = "Office";
            this.office.Name = "office";
            this.office.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "E-Mail (Primary)";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // email2
            // 
            this.email2.HeaderText = "E-Mail (secondary)";
            this.email2.Name = "email2";
            this.email2.ReadOnly = true;
            // 
            // fax
            // 
            this.fax.HeaderText = "Fax";
            this.fax.Name = "fax";
            this.fax.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Address                                      ";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(157, 516);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(87, 52);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Add [F3]";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(339, 516);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(87, 52);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "Update [F4]";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtnm
            // 
            this.txtnm.Location = new System.Drawing.Point(560, 20);
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(132, 20);
            this.txtnm.TabIndex = 1;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(719, 23);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(90, 48);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.Text = "Search [F10]";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(560, 68);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(132, 20);
            this.txtnum.TabIndex = 3;
            this.txtnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum_KeyPress);
            // 
            // radname
            // 
            this.radname.AutoSize = true;
            this.radname.Location = new System.Drawing.Point(431, 23);
            this.radname.Name = "radname";
            this.radname.Size = new System.Drawing.Size(104, 17);
            this.radname.TabIndex = 0;
            this.radname.TabStop = true;
            this.radname.Text = "Search by Name";
            this.radname.UseVisualStyleBackColor = true;
            this.radname.Click += new System.EventHandler(this.radname_Click);
            // 
            // radnumber
            // 
            this.radnumber.AutoSize = true;
            this.radnumber.Location = new System.Drawing.Point(431, 71);
            this.radnumber.Name = "radnumber";
            this.radnumber.Size = new System.Drawing.Size(113, 17);
            this.radnumber.TabIndex = 2;
            this.radnumber.TabStop = true;
            this.radnumber.Text = "Search by Number";
            this.radnumber.UseVisualStyleBackColor = true;
            this.radnumber.Click += new System.EventHandler(this.radnumber_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbluser);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(29, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Details";
            // 
            // btndeletefull
            // 
            this.btndeletefull.Location = new System.Drawing.Point(538, 516);
            this.btndeletefull.Name = "btndeletefull";
            this.btndeletefull.Size = new System.Drawing.Size(154, 52);
            this.btndeletefull.TabIndex = 1;
            this.btndeletefull.Text = "Delete Contact [F6]";
            this.btndeletefull.UseVisualStyleBackColor = true;
            this.btndeletefull.Click += new System.EventHandler(this.btndeletefull_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 596);
            this.Controls.Add(this.table);
            this.Controls.Add(this.btndeletefull);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.radnumber);
            this.Controls.Add(this.radname);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtnm);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmmain";
            this.Text = "Contact Book";
            this.Activated += new System.EventHandler(this.frmmain_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmmain_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmmain_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.RadioButton radname;
        private System.Windows.Forms.RadioButton radnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileno1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileno2;
        private System.Windows.Forms.DataGridViewTextBoxColumn home;
        private System.Windows.Forms.DataGridViewTextBoxColumn office;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn email2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btndeletefull;
    }
}