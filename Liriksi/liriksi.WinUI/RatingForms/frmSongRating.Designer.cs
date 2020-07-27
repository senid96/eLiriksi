namespace liriksi.WinUI.RatingForms
{
    partial class frmSongRating
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
            this.dgvSongRating = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongRating)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSongRating
            // 
            this.dgvSongRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongRating.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.AvgRate});
            this.dgvSongRating.Location = new System.Drawing.Point(32, 110);
            this.dgvSongRating.Name = "dgvSongRating";
            this.dgvSongRating.RowHeadersWidth = 51;
            this.dgvSongRating.RowTemplate.Height = 24;
            this.dgvSongRating.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSongRating.Size = new System.Drawing.Size(744, 309);
            this.dgvSongRating.TabIndex = 0;
            this.dgvSongRating.DoubleClick += new System.EventHandler(this.dgvSongRating_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 125;
            // 
            // AvgRate
            // 
            this.AvgRate.DataPropertyName = "AvgRate";
            this.AvgRate.HeaderText = "AvgRate";
            this.AvgRate.MinimumWidth = 6;
            this.AvgRate.Name = "AvgRate";
            this.AvgRate.Width = 125;
            // 
            // frmSongRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSongRating);
            this.Name = "frmSongRating";
            this.Text = "frmSongRating";
            this.Load += new System.EventHandler(this.frmSongRating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongRating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSongRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgRate;
    }
}