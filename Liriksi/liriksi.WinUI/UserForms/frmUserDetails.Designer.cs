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
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtboxSurname = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.txtboxCity = new System.Windows.Forms.TextBox();
            this.txtboxUserType = new System.Windows.Forms.TextBox();
            this.picboxUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(208, 49);
            this.txtboxName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(234, 22);
            this.txtboxName.TabIndex = 0;
            this.txtboxName.TextChanged += new System.EventHandler(this.TxtboxName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(205, 28);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(205, 75);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 17);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Surname";
            // 
            // txtboxSurname
            // 
            this.txtboxSurname.Location = new System.Drawing.Point(208, 96);
            this.txtboxSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxSurname.Name = "txtboxSurname";
            this.txtboxSurname.Size = new System.Drawing.Size(234, 22);
            this.txtboxSurname.TabIndex = 4;
            this.txtboxSurname.TextChanged += new System.EventHandler(this.TxtboxSurname_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(205, 122);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(208, 143);
            this.txtboxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(234, 22);
            this.txtboxEmail.TabIndex = 6;
            this.txtboxEmail.TextChanged += new System.EventHandler(this.TxtboxEmail_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(8, 183);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(101, 17);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone number";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(8, 367);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 17;
            this.lblUsername.Text = "Username";
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(12, 388);
            this.txtboxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(430, 22);
            this.txtboxUsername.TabIndex = 16;
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(12, 203);
            this.txtBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPhone.Mask = "000-000-000";
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(430, 22);
            this.txtBoxPhone.TabIndex = 18;
            this.txtBoxPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxtBoxPhone_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "City";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(8, 307);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(69, 17);
            this.lblUserType.TabIndex = 24;
            this.lblUserType.Text = "User type";
            // 
            // txtboxCity
            // 
            this.txtboxCity.Location = new System.Drawing.Point(12, 266);
            this.txtboxCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxCity.Name = "txtboxCity";
            this.txtboxCity.Size = new System.Drawing.Size(430, 22);
            this.txtboxCity.TabIndex = 25;
            // 
            // txtboxUserType
            // 
            this.txtboxUserType.Location = new System.Drawing.Point(12, 329);
            this.txtboxUserType.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxUserType.Name = "txtboxUserType";
            this.txtboxUserType.Size = new System.Drawing.Size(430, 22);
            this.txtboxUserType.TabIndex = 26;
            // 
            // picboxUser
            // 
            this.picboxUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxUser.Location = new System.Drawing.Point(12, 28);
            this.picboxUser.Name = "picboxUser";
            this.picboxUser.Size = new System.Drawing.Size(162, 137);
            this.picboxUser.TabIndex = 27;
            this.picboxUser.TabStop = false;
            this.picboxUser.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 444);
            this.Controls.Add(this.picboxUser);
            this.Controls.Add(this.txtboxUserType);
            this.Controls.Add(this.txtboxCity);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxPhone);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtboxSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtboxName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUserDetails";
            this.Text = "frmUserDetails";
            this.Load += new System.EventHandler(this.FrmUserDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).EndInit();
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
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.MaskedTextBox txtBoxPhone;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxUserType;
        private System.Windows.Forms.TextBox txtboxCity;
        private System.Windows.Forms.PictureBox picboxUser;
    }
}