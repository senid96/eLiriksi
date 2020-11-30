namespace liriksi.WinUI.SongForms.AlbumForms
{
    partial class frmAlbum
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
            this.dgvAlbum = new System.Windows.Forms.DataGridView();
            this.txtboxAlbumName = new System.Windows.Forms.TextBox();
            this.lblAlbumName = new System.Windows.Forms.Label();
            this.btnSearchAlbum = new System.Windows.Forms.Button();
            this.btnUpdateAlbum = new System.Windows.Forms.Button();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearRelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlbum
            // 
            this.dgvAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.YearRelease,
            this.Image});
            this.dgvAlbum.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAlbum.Location = new System.Drawing.Point(15, 79);
            this.dgvAlbum.Name = "dgvAlbum";
            this.dgvAlbum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvAlbum.RowHeadersWidth = 60;
            this.dgvAlbum.RowTemplate.Height = 50;
            this.dgvAlbum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlbum.Size = new System.Drawing.Size(1027, 390);
            this.dgvAlbum.TabIndex = 0;
            this.dgvAlbum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlbum_CellContentClick);
            this.dgvAlbum.DoubleClick += new System.EventHandler(this.dgvAlbum_DoubleClick);
            // 
            // txtboxAlbumName
            // 
            this.txtboxAlbumName.Location = new System.Drawing.Point(104, 34);
            this.txtboxAlbumName.Name = "txtboxAlbumName";
            this.txtboxAlbumName.Size = new System.Drawing.Size(242, 22);
            this.txtboxAlbumName.TabIndex = 1;
            // 
            // lblAlbumName
            // 
            this.lblAlbumName.AutoSize = true;
            this.lblAlbumName.Location = new System.Drawing.Point(12, 34);
            this.lblAlbumName.Name = "lblAlbumName";
            this.lblAlbumName.Size = new System.Drawing.Size(86, 17);
            this.lblAlbumName.TabIndex = 2;
            this.lblAlbumName.Text = "Album name";
            // 
            // btnSearchAlbum
            // 
            this.btnSearchAlbum.Location = new System.Drawing.Point(352, 33);
            this.btnSearchAlbum.Name = "btnSearchAlbum";
            this.btnSearchAlbum.Size = new System.Drawing.Size(98, 23);
            this.btnSearchAlbum.TabIndex = 3;
            this.btnSearchAlbum.Text = "Search";
            this.btnSearchAlbum.UseVisualStyleBackColor = true;
            this.btnSearchAlbum.Click += new System.EventHandler(this.btnSearchAlbum_Click);
            // 
            // btnUpdateAlbum
            // 
            this.btnUpdateAlbum.Location = new System.Drawing.Point(456, 33);
            this.btnUpdateAlbum.Name = "btnUpdateAlbum";
            this.btnUpdateAlbum.Size = new System.Drawing.Size(98, 23);
            this.btnUpdateAlbum.TabIndex = 4;
            this.btnUpdateAlbum.Text = "Update";
            this.btnUpdateAlbum.UseVisualStyleBackColor = true;
            this.btnUpdateAlbum.Click += new System.EventHandler(this.btnUpdateAlbum_Click);
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataSource = typeof(liriksi.Model.Genre);
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(liriksi.Model.Album);
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
            this.Title.DataPropertyName = "Name";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 420;
            // 
            // YearRelease
            // 
            this.YearRelease.DataPropertyName = "YearRelease";
            this.YearRelease.HeaderText = "Year release";
            this.YearRelease.MinimumWidth = 6;
            this.YearRelease.Name = "YearRelease";
            this.YearRelease.Width = 125;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            // 
            // frmAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 481);
            this.Controls.Add(this.btnUpdateAlbum);
            this.Controls.Add(this.btnSearchAlbum);
            this.Controls.Add(this.lblAlbumName);
            this.Controls.Add(this.txtboxAlbumName);
            this.Controls.Add(this.dgvAlbum);
            this.Name = "frmAlbum";
            this.Load += new System.EventHandler(this.frmAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlbum;
        private System.Windows.Forms.TextBox txtboxAlbumName;
        private System.Windows.Forms.Label lblAlbumName;
        private System.Windows.Forms.Button btnSearchAlbum;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.Button btnUpdateAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearRelease;
        private System.Windows.Forms.DataGridViewImageColumn Image;
    }
}