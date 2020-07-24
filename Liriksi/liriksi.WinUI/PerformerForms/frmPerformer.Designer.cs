namespace liriksi.WinUI.PerformerForms
{
    partial class frmPerformer
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
            this.dgvPerformer = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.btnSearchPerformer = new System.Windows.Forms.Button();
            this.txtboxArtisticName = new System.Windows.Forms.TextBox();
            this.lblArtisticName = new System.Windows.Forms.Label();
            this.txtboxSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtisticName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPerformer
            // 
            this.dgvPerformer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerformer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Surname,
            this.ArtisticName,
            this.Image});
            this.dgvPerformer.Location = new System.Drawing.Point(12, 154);
            this.dgvPerformer.Name = "dgvPerformer";
            this.dgvPerformer.RowHeadersWidth = 51;
            this.dgvPerformer.RowTemplate.Height = 50;
            this.dgvPerformer.Size = new System.Drawing.Size(776, 284);
            this.dgvPerformer.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(108, 36);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(230, 22);
            this.txtboxName.TabIndex = 2;
            // 
            // btnSearchPerformer
            // 
            this.btnSearchPerformer.Location = new System.Drawing.Point(355, 98);
            this.btnSearchPerformer.Name = "btnSearchPerformer";
            this.btnSearchPerformer.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPerformer.TabIndex = 3;
            this.btnSearchPerformer.Text = "Search";
            this.btnSearchPerformer.UseVisualStyleBackColor = true;
            this.btnSearchPerformer.Click += new System.EventHandler(this.btnSearchPerformer_Click);
            // 
            // txtboxArtisticName
            // 
            this.txtboxArtisticName.Location = new System.Drawing.Point(108, 98);
            this.txtboxArtisticName.Name = "txtboxArtisticName";
            this.txtboxArtisticName.Size = new System.Drawing.Size(230, 22);
            this.txtboxArtisticName.TabIndex = 5;
            // 
            // lblArtisticName
            // 
            this.lblArtisticName.AutoSize = true;
            this.lblArtisticName.Location = new System.Drawing.Point(13, 101);
            this.lblArtisticName.Name = "lblArtisticName";
            this.lblArtisticName.Size = new System.Drawing.Size(89, 17);
            this.lblArtisticName.TabIndex = 4;
            this.lblArtisticName.Text = "Artistic name";
            // 
            // txtboxSurname
            // 
            this.txtboxSurname.Location = new System.Drawing.Point(108, 67);
            this.txtboxSurname.Name = "txtboxSurname";
            this.txtboxSurname.Size = new System.Drawing.Size(230, 22);
            this.txtboxSurname.TabIndex = 7;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(13, 67);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 17);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname";
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
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.DataPropertyName = "Name";
            this.Title.HeaderText = "Name";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Surname";
            this.Surname.MinimumWidth = 6;
            this.Surname.Name = "Surname";
            // 
            // ArtisticName
            // 
            this.ArtisticName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ArtisticName.DataPropertyName = "ArtisticName";
            this.ArtisticName.HeaderText = "ArtisticName";
            this.ArtisticName.MinimumWidth = 6;
            this.ArtisticName.Name = "ArtisticName";
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            // 
            // frmPerformer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtboxArtisticName);
            this.Controls.Add(this.lblArtisticName);
            this.Controls.Add(this.btnSearchPerformer);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvPerformer);
            this.Name = "frmPerformer";
            this.Load += new System.EventHandler(this.frmPerformer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPerformer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Button btnSearchPerformer;
        private System.Windows.Forms.TextBox txtboxArtisticName;
        private System.Windows.Forms.Label lblArtisticName;
        private System.Windows.Forms.TextBox txtboxSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtisticName;
        private System.Windows.Forms.DataGridViewImageColumn Image;
    }
}