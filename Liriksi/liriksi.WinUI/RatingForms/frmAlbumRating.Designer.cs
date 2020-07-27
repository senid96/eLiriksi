namespace liriksi.WinUI.RatingForms
{
    partial class frmAlbumRating
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
            this.dgvAlbumRate = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumRate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlbumRate
            // 
            this.dgvAlbumRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbumRate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.AvgRate});
            this.dgvAlbumRate.Location = new System.Drawing.Point(40, 47);
            this.dgvAlbumRate.Name = "dgvAlbumRate";
            this.dgvAlbumRate.RowHeadersWidth = 51;
            this.dgvAlbumRate.RowTemplate.Height = 24;
            this.dgvAlbumRate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlbumRate.Size = new System.Drawing.Size(684, 367);
            this.dgvAlbumRate.TabIndex = 0;
            this.dgvAlbumRate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlbumRate_CellContentClick);
            this.dgvAlbumRate.DoubleClick += new System.EventHandler(this.dgvAlbumRate_DoubleClick);
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
            // frmAlbumRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAlbumRate);
            this.Name = "frmAlbumRating";
            this.Text = "frmAlbumRating";
            this.Load += new System.EventHandler(this.frmAlbumRating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlbumRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgRate;
    }
}