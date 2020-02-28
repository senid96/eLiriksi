namespace liriksi.WinUI.SongForms
{
    partial class frmAddSong
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAlbum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPerformer = new System.Windows.Forms.ComboBox();
            this.btnAddAlbum = new System.Windows.Forms.Button();
            this.btnAddPerformer = new System.Windows.Forms.Button();
            this.txtLyrics = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(277, 22);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name: ";
            // 
            // cmbAlbum
            // 
            this.cmbAlbum.FormattingEnabled = true;
            this.cmbAlbum.Location = new System.Drawing.Point(109, 96);
            this.cmbAlbum.Name = "cmbAlbum";
            this.cmbAlbum.Size = new System.Drawing.Size(277, 24);
            this.cmbAlbum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Album: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Performer:";
            // 
            // cmbPerformer
            // 
            this.cmbPerformer.FormattingEnabled = true;
            this.cmbPerformer.Location = new System.Drawing.Point(109, 138);
            this.cmbPerformer.Name = "cmbPerformer";
            this.cmbPerformer.Size = new System.Drawing.Size(277, 24);
            this.cmbPerformer.TabIndex = 4;
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.Location = new System.Drawing.Point(398, 96);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(75, 24);
            this.btnAddAlbum.TabIndex = 6;
            this.btnAddAlbum.Text = "Add new";
            this.btnAddAlbum.UseVisualStyleBackColor = true;
            this.btnAddAlbum.Click += new System.EventHandler(this.btnAddAlbum_Click);
            // 
            // btnAddPerformer
            // 
            this.btnAddPerformer.Location = new System.Drawing.Point(398, 137);
            this.btnAddPerformer.Name = "btnAddPerformer";
            this.btnAddPerformer.Size = new System.Drawing.Size(75, 24);
            this.btnAddPerformer.TabIndex = 7;
            this.btnAddPerformer.Text = "Add new";
            this.btnAddPerformer.UseVisualStyleBackColor = true;
            // 
            // txtLyrics
            // 
            this.txtLyrics.Location = new System.Drawing.Point(109, 188);
            this.txtLyrics.Name = "txtLyrics";
            this.txtLyrics.Size = new System.Drawing.Size(277, 276);
            this.txtLyrics.TabIndex = 8;
            this.txtLyrics.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lyrics: ";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(398, 440);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 24);
            this.btnFinish.TabIndex = 10;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Add new song";
            // 
            // frmAddSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 488);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLyrics);
            this.Controls.Add(this.btnAddPerformer);
            this.Controls.Add(this.btnAddAlbum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPerformer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAlbum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "frmAddSong";
            this.Text = "frmAddSong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAlbum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPerformer;
        private System.Windows.Forms.Button btnAddAlbum;
        private System.Windows.Forms.Button btnAddPerformer;
        private System.Windows.Forms.RichTextBox txtLyrics;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label5;
    }
}