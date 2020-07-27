namespace liriksi.WinUI.RatingForms
{
    partial class frmSongRatingDetails
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
            this.dgvSongRateDetails = new System.Windows.Forms.DataGridView();
            this.SongTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongRateDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSongRateDetails
            // 
            this.dgvSongRateDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongRateDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongTitle,
            this.Username,
            this.Comment,
            this.Rate});
            this.dgvSongRateDetails.Location = new System.Drawing.Point(12, 74);
            this.dgvSongRateDetails.Name = "dgvSongRateDetails";
            this.dgvSongRateDetails.RowHeadersWidth = 51;
            this.dgvSongRateDetails.RowTemplate.Height = 24;
            this.dgvSongRateDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSongRateDetails.Size = new System.Drawing.Size(1058, 364);
            this.dgvSongRateDetails.TabIndex = 0;
            // 
            // SongTitle
            // 
            this.SongTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SongTitle.DataPropertyName = "SongTitle";
            this.SongTitle.HeaderText = "SongTitle";
            this.SongTitle.MinimumWidth = 6;
            this.SongTitle.Name = "SongTitle";
            this.SongTitle.Width = 150;
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
            // frmSongRatingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 450);
            this.Controls.Add(this.dgvSongRateDetails);
            this.Name = "frmSongRatingDetails";
            this.Text = "frmSongRating";
            this.Load += new System.EventHandler(this.frmSongRating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongRateDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSongRateDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
    }
}