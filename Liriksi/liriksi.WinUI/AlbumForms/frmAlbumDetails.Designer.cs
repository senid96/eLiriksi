namespace liriksi.WinUI.AlbumForms
{
    partial class frmAlbumDetails
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
            this.lblPerformer = new System.Windows.Forms.Label();
            this.picboxAlbum = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtYearRelease = new System.Windows.Forms.TextBox();
            this.txtPerformer = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.dgvAlbumSongs = new System.Windows.Forms.DataGridView();
            this.lblSongs = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPerformer
            // 
            this.lblPerformer.AutoSize = true;
            this.lblPerformer.Location = new System.Drawing.Point(22, 112);
            this.lblPerformer.Name = "lblPerformer";
            this.lblPerformer.Size = new System.Drawing.Size(71, 17);
            this.lblPerformer.TabIndex = 65;
            this.lblPerformer.Text = "Performer";
            // 
            // picboxAlbum
            // 
            this.picboxAlbum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxAlbum.Location = new System.Drawing.Point(372, 30);
            this.picboxAlbum.Name = "picboxAlbum";
            this.picboxAlbum.Size = new System.Drawing.Size(191, 139);
            this.picboxAlbum.TabIndex = 64;
            this.picboxAlbum.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Genre";
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(22, 70);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(89, 17);
            this.Genre.TabIndex = 55;
            this.Genre.Text = "Year release";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(121, 31);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(235, 22);
            this.txtTitle.TabIndex = 53;
            // 
            // txtYearRelease
            // 
            this.txtYearRelease.Location = new System.Drawing.Point(121, 70);
            this.txtYearRelease.Name = "txtYearRelease";
            this.txtYearRelease.Size = new System.Drawing.Size(235, 22);
            this.txtYearRelease.TabIndex = 67;
            // 
            // txtPerformer
            // 
            this.txtPerformer.Location = new System.Drawing.Point(121, 107);
            this.txtPerformer.Name = "txtPerformer";
            this.txtPerformer.Size = new System.Drawing.Size(235, 22);
            this.txtPerformer.TabIndex = 68;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(121, 147);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(235, 22);
            this.txtGenre.TabIndex = 69;
            // 
            // dgvAlbumSongs
            // 
            this.dgvAlbumSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbumSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Text});
            this.dgvAlbumSongs.Location = new System.Drawing.Point(12, 224);
            this.dgvAlbumSongs.Name = "dgvAlbumSongs";
            this.dgvAlbumSongs.RowHeadersWidth = 51;
            this.dgvAlbumSongs.RowTemplate.Height = 24;
            this.dgvAlbumSongs.Size = new System.Drawing.Size(551, 165);
            this.dgvAlbumSongs.TabIndex = 70;
            // 
            // lblSongs
            // 
            this.lblSongs.AutoSize = true;
            this.lblSongs.Location = new System.Drawing.Point(12, 201);
            this.lblSongs.Name = "lblSongs";
            this.lblSongs.Size = new System.Drawing.Size(48, 17);
            this.lblSongs.TabIndex = 71;
            this.lblSongs.Text = "Songs";
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            // 
            // Text
            // 
            this.Text.DataPropertyName = "Text";
            this.Text.HeaderText = "Text";
            this.Text.MinimumWidth = 6;
            this.Text.Name = "Text";
            this.Text.Width = 125;
            // 
            // frmAlbumDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 401);
            this.Controls.Add(this.lblSongs);
            this.Controls.Add(this.dgvAlbumSongs);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtPerformer);
            this.Controls.Add(this.txtYearRelease);
            this.Controls.Add(this.lblPerformer);
            this.Controls.Add(this.picboxAlbum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Name = "frmAlbumDetails";
            this.Load += new System.EventHandler(this.frmAlbumDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumSongs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPerformer;
        private System.Windows.Forms.PictureBox picboxAlbum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtYearRelease;
        private System.Windows.Forms.TextBox txtPerformer;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.DataGridView dgvAlbumSongs;
        private System.Windows.Forms.Label lblSongs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Text;
    }
}