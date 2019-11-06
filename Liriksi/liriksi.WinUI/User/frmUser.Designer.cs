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
            this.txtSearchParameter = new System.Windows.Forms.TextBox();
            this.User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.Controls.Add(this.dgvUser);
            this.User.Location = new System.Drawing.Point(27, 57);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(746, 361);
            this.User.TabIndex = 0;
            this.User.TabStop = false;
            this.User.Text = "Korisnici";
            this.User.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // dgvUser
            // 
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.Location = new System.Drawing.Point(3, 16);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.Size = new System.Drawing.Size(740, 342);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(429, 28);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(75, 23);
            this.btnSearchUser.TabIndex = 1;
            this.btnSearchUser.Text = "Prikazi";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // txtSearchParameter
            // 
            this.txtSearchParameter.Location = new System.Drawing.Point(30, 29);
            this.txtSearchParameter.Name = "txtSearchParameter";
            this.txtSearchParameter.Size = new System.Drawing.Size(393, 20);
            this.txtSearchParameter.TabIndex = 2;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearchParameter);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.User);
            this.Name = "frmUser";
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.User.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox User;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox txtSearchParameter;
    }
}