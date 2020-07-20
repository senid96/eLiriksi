namespace liriksi.WinUI.User
{
    partial class frmUser
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
            this.User = new System.Windows.Forms.GroupBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtboxSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.Controls.Add(this.dgvUser);
            this.User.Location = new System.Drawing.Point(36, 129);
            this.User.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.User.Name = "User";
            this.User.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.User.Size = new System.Drawing.Size(995, 385);
            this.User.TabIndex = 0;
            this.User.TabStop = false;
            this.User.Text = "Korisnici";
            this.User.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AllowUserToOrderColumns = true;
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UsrName,
            this.Surname,
            this.Username,
            this.Email,
            this.Status});
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.Location = new System.Drawing.Point(4, 19);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(987, 362);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.AllowUserToOrderColumnsChanged += new System.EventHandler(this.DgvUser_AllowUserToOrderColumnsChanged);
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dgvUser.DoubleClick += new System.EventHandler(this.DgvUser_DoubleClick);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(376, 66);
            this.btnSearchUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(100, 28);
            this.btnSearchUser.TabIndex = 1;
            this.btnSearchUser.Text = "Prikazi";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(161, 36);
            this.txtboxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(197, 22);
            this.txtboxName.TabIndex = 2;
            this.txtboxName.TextChanged += new System.EventHandler(this.TxtSearchParameter_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(39, 39);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Unesite ime:";
            this.lblName.Click += new System.EventHandler(this.LblSearchParam_Click);
            // 
            // txtboxSurname
            // 
            this.txtboxSurname.Location = new System.Drawing.Point(161, 68);
            this.txtboxSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxSurname.Name = "txtboxSurname";
            this.txtboxSurname.Size = new System.Drawing.Size(197, 22);
            this.txtboxSurname.TabIndex = 4;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(39, 71);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(114, 17);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Unesite prezime:";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(484, 66);
            this.btnClearSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(100, 28);
            this.btnClearSearch.TabIndex = 6;
            this.btnClearSearch.Text = "Ponisti unos";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.BtnClearSearch_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // UsrName
            // 
            this.UsrName.DataPropertyName = "Name";
            this.UsrName.HeaderText = "Name";
            this.UsrName.MinimumWidth = 6;
            this.UsrName.Name = "UsrName";
            this.UsrName.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Surname";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtboxSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.User);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.User.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox User;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtboxSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnClearSearch;
        public System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}