namespace liriksi.WinUI.RatingForms
{
    partial class frmUsersRating
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
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.cmbChoseView = new System.Windows.Forms.ComboBox();
            this.lblChoseView = new System.Windows.Forms.Label();
            this.dgvUsersRating = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlbumTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersRating)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(61, 24);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(179, 24);
            this.cmbUser.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(17, 27);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 17);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "User:";
            // 
            // cmbChoseView
            // 
            this.cmbChoseView.FormattingEnabled = true;
            this.cmbChoseView.Location = new System.Drawing.Point(327, 24);
            this.cmbChoseView.Name = "cmbChoseView";
            this.cmbChoseView.Size = new System.Drawing.Size(179, 24);
            this.cmbChoseView.TabIndex = 2;
            // 
            // lblChoseView
            // 
            this.lblChoseView.AutoSize = true;
            this.lblChoseView.Location = new System.Drawing.Point(280, 28);
            this.lblChoseView.Name = "lblChoseView";
            this.lblChoseView.Size = new System.Drawing.Size(41, 17);
            this.lblChoseView.TabIndex = 3;
            this.lblChoseView.Text = "View:";
            // 
            // dgvUsersRating
            // 
            this.dgvUsersRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersRating.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.AlbumTitle,
            this.Rate,
            this.Comment});
            this.dgvUsersRating.Location = new System.Drawing.Point(16, 79);
            this.dgvUsersRating.Name = "dgvUsersRating";
            this.dgvUsersRating.RowHeadersWidth = 51;
            this.dgvUsersRating.RowTemplate.Height = 24;
            this.dgvUsersRating.Size = new System.Drawing.Size(772, 359);
            this.dgvUsersRating.TabIndex = 4;
            this.dgvUsersRating.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsersRating_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(531, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 24);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.Width = 125;
            // 
            // AlbumTitle
            // 
            this.AlbumTitle.DataPropertyName = "Title";
            this.AlbumTitle.HeaderText = "Title";
            this.AlbumTitle.MinimumWidth = 6;
            this.AlbumTitle.Name = "AlbumTitle";
            this.AlbumTitle.Width = 125;
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "Rate";
            this.Rate.MinimumWidth = 6;
            this.Rate.Name = "Rate";
            this.Rate.Width = 125;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Comment";
            this.Comment.MinimumWidth = 6;
            this.Comment.Name = "Comment";
            this.Comment.Width = 125;
            // 
            // frmUsersRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvUsersRating);
            this.Controls.Add(this.lblChoseView);
            this.Controls.Add(this.cmbChoseView);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cmbUser);
            this.Name = "frmUsersRating";
            this.Text = "frmUsersRating";
            this.Load += new System.EventHandler(this.frmUsersRating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cmbChoseView;
        private System.Windows.Forms.Label lblChoseView;
        private System.Windows.Forms.DataGridView dgvUsersRating;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
    }
}