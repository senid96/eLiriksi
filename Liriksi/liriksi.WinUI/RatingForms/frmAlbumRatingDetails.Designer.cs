namespace liriksi.WinUI.RatingForms
{
    partial class frmAlbumRatingDetails
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
            this.dgvAlbumRatingDetails = new System.Windows.Forms.DataGridView();
            this.AlbumTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumRatingDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlbumRatingDetails
            // 
            this.dgvAlbumRatingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbumRatingDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlbumTitle,
            this.Username,
            this.Comment,
            this.Rate});
            this.dgvAlbumRatingDetails.Location = new System.Drawing.Point(12, 72);
            this.dgvAlbumRatingDetails.Name = "dgvAlbumRatingDetails";
            this.dgvAlbumRatingDetails.RowHeadersWidth = 51;
            this.dgvAlbumRatingDetails.RowTemplate.Height = 24;
            this.dgvAlbumRatingDetails.Size = new System.Drawing.Size(1057, 366);
            this.dgvAlbumRatingDetails.TabIndex = 0;
            // 
            // AlbumTitle
            // 
            this.AlbumTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AlbumTitle.DataPropertyName = "Title";
            this.AlbumTitle.HeaderText = "AlbumTitle";
            this.AlbumTitle.MinimumWidth = 6;
            this.AlbumTitle.Name = "AlbumTitle";
            this.AlbumTitle.Width = 150;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.Width = 125;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Comment";
            this.Comment.MinimumWidth = 6;
            this.Comment.Name = "Comment";
            this.Comment.Width = 125;
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "Rate";
            this.Rate.MinimumWidth = 6;
            this.Rate.Name = "Rate";
            this.Rate.Width = 125;
            // 
            // frmAlbumRatingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 450);
            this.Controls.Add(this.dgvAlbumRatingDetails);
            this.Name = "frmAlbumRatingDetails";
            this.Text = "frmRating";
            this.Load += new System.EventHandler(this.frmRating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumRatingDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlbumRatingDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
    }
}