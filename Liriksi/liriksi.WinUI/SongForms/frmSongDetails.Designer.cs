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
            this.labelPerformer = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.txtboxAlbum = new System.Windows.Forms.TextBox();
            this.txtboxPerformer = new System.Windows.Forms.TextBox();
            this.txtboxGenre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtboxLyrics
            // 
            this.txtboxLyrics.Location = new System.Drawing.Point(20, 196);
            this.txtboxLyrics.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxLyrics.Name = "txtboxLyrics";
            this.txtboxLyrics.ReadOnly = true;
            this.txtboxLyrics.Size = new System.Drawing.Size(416, 313);
            this.txtboxLyrics.TabIndex = 0;
            this.txtboxLyrics.Text = "";
            this.txtboxLyrics.TextChanged += new System.EventHandler(this.TxtboxLyrics_TextChanged);
            // 
            // labelPerformer
            // 
            this.labelPerformer.AutoSize = true;
            this.labelPerformer.Location = new System.Drawing.Point(13, 95);
            this.labelPerformer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPerformer.Name = "labelPerformer";
            this.labelPerformer.Size = new System.Drawing.Size(71, 17);
            this.labelPerformer.TabIndex = 1;
            this.labelPerformer.Text = "Performer";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(95, 34);
            this.txtBoxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.ReadOnly = true;
            this.txtBoxTitle.Size = new System.Drawing.Size(228, 22);
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
            this.labelGenre.Location = new System.Drawing.Point(12, 125);
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
            this.txtboxAlbum.Size = new System.Drawing.Size(228, 22);
            this.txtboxAlbum.TabIndex = 8;
            // 
            // txtboxPerformer
            // 
            this.txtboxPerformer.Location = new System.Drawing.Point(95, 92);
            this.txtboxPerformer.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxPerformer.Name = "txtboxPerformer";
            this.txtboxPerformer.ReadOnly = true;
            this.txtboxPerformer.Size = new System.Drawing.Size(228, 22);
            this.txtboxPerformer.TabIndex = 9;
            // 
            // txtboxGenre
            // 
            this.txtboxGenre.Location = new System.Drawing.Point(95, 122);
            this.txtboxGenre.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxGenre.Name = "txtboxGenre";
            this.txtboxGenre.ReadOnly = true;
            this.txtboxGenre.Size = new System.Drawing.Size(228, 22);
            this.txtboxGenre.TabIndex = 10;
            // 
            // frmSongDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 531);
            this.Controls.Add(this.txtboxGenre);
            this.Controls.Add(this.txtboxPerformer);
            this.Controls.Add(this.txtboxAlbum);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.labelPerformer);
            this.Controls.Add(this.txtboxLyrics);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSongDetails";
            this.Text = "frmSongDetails";
            this.Load += new System.EventHandler(this.FrmSongDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtboxLyrics;
        private System.Windows.Forms.Label labelPerformer;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.TextBox txtboxAlbum;
        private System.Windows.Forms.TextBox txtboxPerformer;
        private System.Windows.Forms.TextBox txtboxGenre;
    }
}