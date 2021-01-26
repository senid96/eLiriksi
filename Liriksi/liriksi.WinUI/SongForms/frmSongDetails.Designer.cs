namespace liriksi.WinUI.SongForms
{
    partial class frmSongDetails
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
            this.txtboxLyrics = new System.Windows.Forms.RichTextBox();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.txtboxAlbum = new System.Windows.Forms.TextBox();
            this.txtboxGenre = new System.Windows.Forms.TextBox();
            this.picboxAlbum = new System.Windows.Forms.PictureBox();
            this.btnEditSong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxLyrics
            // 
            this.txtboxLyrics.Location = new System.Drawing.Point(16, 140);
            this.txtboxLyrics.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxLyrics.Name = "txtboxLyrics";
            this.txtboxLyrics.ReadOnly = true;
            this.txtboxLyrics.Size = new System.Drawing.Size(435, 343);
            this.txtboxLyrics.TabIndex = 0;
            this.txtboxLyrics.Text = "";
            this.txtboxLyrics.TextChanged += new System.EventHandler(this.TxtboxLyrics_TextChanged);
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(95, 34);
            this.txtBoxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.ReadOnly = true;
            this.txtBoxTitle.Size = new System.Drawing.Size(196, 22);
            this.txtBoxTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(13, 39);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(13, 67);
            this.labelAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(47, 17);
            this.labelAlbum.TabIndex = 6;
            this.labelAlbum.Text = "Album";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(12, 95);
            this.labelGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(48, 17);
            this.labelGenre.TabIndex = 7;
            this.labelGenre.Text = "Genre";
            // 
            // txtboxAlbum
            // 
            this.txtboxAlbum.Location = new System.Drawing.Point(95, 62);
            this.txtboxAlbum.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxAlbum.Name = "txtboxAlbum";
            this.txtboxAlbum.ReadOnly = true;
            this.txtboxAlbum.Size = new System.Drawing.Size(196, 22);
            this.txtboxAlbum.TabIndex = 8;
            // 
            // txtboxGenre
            // 
            this.txtboxGenre.Location = new System.Drawing.Point(95, 92);
            this.txtboxGenre.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxGenre.Name = "txtboxGenre";
            this.txtboxGenre.ReadOnly = true;
            this.txtboxGenre.Size = new System.Drawing.Size(196, 22);
            this.txtboxGenre.TabIndex = 10;
            // 
            // picboxAlbum
            // 
            this.picboxAlbum.Location = new System.Drawing.Point(313, 34);
            this.picboxAlbum.Name = "picboxAlbum";
            this.picboxAlbum.Size = new System.Drawing.Size(126, 80);
            this.picboxAlbum.TabIndex = 11;
            this.picboxAlbum.TabStop = false;
            // 
            // btnEditSong
            // 
            this.btnEditSong.Location = new System.Drawing.Point(376, 490);
            this.btnEditSong.Name = "btnEditSong";
            this.btnEditSong.Size = new System.Drawing.Size(75, 23);
            this.btnEditSong.TabIndex = 12;
            this.btnEditSong.Text = "Edit";
            this.btnEditSong.UseVisualStyleBackColor = true;
            this.btnEditSong.Click += new System.EventHandler(this.btnEditSong_Click);
            // 
            // frmSongDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 561);
            this.Controls.Add(this.btnEditSong);
            this.Controls.Add(this.picboxAlbum);
            this.Controls.Add(this.txtboxGenre);
            this.Controls.Add(this.txtboxAlbum);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.txtboxLyrics);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSongDetails";
            this.Text = "frmSongDetails";
            this.Load += new System.EventHandler(this.FrmSongDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtboxLyrics;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.TextBox txtboxAlbum;
        private System.Windows.Forms.TextBox txtboxGenre;
        private System.Windows.Forms.PictureBox picboxAlbum;
        private System.Windows.Forms.Button btnEditSong;
    }
}