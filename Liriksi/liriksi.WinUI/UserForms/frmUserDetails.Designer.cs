namespace liriksi.WinUI.User
{
    partial class frmUserDetails
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
            this.components = new System.ComponentModel.Container();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtboxSurname = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPasswordConf = new System.Windows.Forms.Label();
            this.txtboxPasswordConf = new System.Windows.Forms.TextBox();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtBoxPhone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(12, 40);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(351, 20);
            this.txtboxName.TabIndex = 0;
            this.txtboxName.TextChanged += new System.EventHandler(this.TxtboxName_TextChanged);
            this.txtboxName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtboxName_Validating);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(9, 73);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Surname";
            // 
            // txtboxSurname
            // 
            this.txtboxSurname.Location = new System.Drawing.Point(12, 89);
            this.txtboxSurname.Name = "txtboxSurname";
            this.txtboxSurname.Size = new System.Drawing.Size(351, 20);
            this.txtboxSurname.TabIndex = 4;
            this.txtboxSurname.TextChanged += new System.EventHandler(this.TxtboxSurname_TextChanged);
            this.txtboxSurname.Validating += new System.ComponentModel.CancelEventHandler(this.TxtboxSurname_Validating);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 124);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(12, 140);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(351, 20);
            this.txtboxEmail.TabIndex = 6;
            this.txtboxEmail.TextChanged += new System.EventHandler(this.TxtboxEmail_TextChanged);
            this.txtboxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtboxEmail_Validating);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(9, 174);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(76, 13);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone number";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(12, 290);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '*';
            this.txtboxPassword.Size = new System.Drawing.Size(169, 20);
            this.txtboxPassword.TabIndex = 10;
            this.txtboxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtboxPassword_Validating);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(9, 274);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            // 
            // lblPasswordConf
            // 
            this.lblPasswordConf.AutoSize = true;
            this.lblPasswordConf.Location = new System.Drawing.Point(188, 274);
            this.lblPasswordConf.Name = "lblPasswordConf";
            this.lblPasswordConf.Size = new System.Drawing.Size(113, 13);
            this.lblPasswordConf.TabIndex = 13;
            this.lblPasswordConf.Text = "Password confirmation";
            // 
            // txtboxPasswordConf
            // 
            this.txtboxPasswordConf.Location = new System.Drawing.Point(191, 290);
            this.txtboxPasswordConf.Name = "txtboxPasswordConf";
            this.txtboxPasswordConf.PasswordChar = '*';
            this.txtboxPasswordConf.Size = new System.Drawing.Size(169, 20);
            this.txtboxPasswordConf.TabIndex = 14;
            this.txtboxPasswordConf.TextChanged += new System.EventHandler(this.TxtboxPasswordConf_TextChanged);
            this.txtboxPasswordConf.Validating += new System.ComponentModel.CancelEventHandler(this.TxtboxPasswordConf_Validating);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(285, 332);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(75, 23);
            this.btnSaveUser.TabIndex = 15;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.BtnSaveUser_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(9, 224);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "Username";
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(12, 240);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(351, 20);
            this.txtboxUsername.TabIndex = 16;
            this.txtboxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.TxtboxUsername_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(12, 190);
            this.txtBoxPhone.Mask = "000-000-000";
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(351, 20);
            this.txtBoxPhone.TabIndex = 18;
            this.txtBoxPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxtBoxPhone_MaskInputRejected);
            this.txtBoxPhone.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBoxPhone_Validating);
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 413);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.txtboxPasswordConf);
            this.Controls.Add(this.lblPasswordConf);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtboxSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtboxName);
            this.Name = "frmUserDetails";
            this.Text = "frmUserDetails";
            this.Load += new System.EventHandler(this.FrmUserDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtboxSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPasswordConf;
        private System.Windows.Forms.TextBox txtboxPasswordConf;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox txtBoxPhone;
    }
}