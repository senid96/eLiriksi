namespace liriksi.WinUI.SongForms
{
    partial class frmEditSong
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtLyrics = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPerformer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAlbum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSaveEditedSong = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Lyrics: ";
            // 
            // txtLyrics
            // 
            this.txtLyrics.Location = new System.Drawing.Point(116, 150);
            this.txtLyrics.Name = "txtLyrics";
            this.txtLyrics.Size = new System.Drawing.Size(277, 276);
            this.txtLyrics.TabIndex = 16;
            this.txtLyrics.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Performer:";
            // 
            // cmbPerformer
            // 
            this.cmbPerformer.FormattingEnabled = true;
            this.cmbPerformer.Location = new System.Drawing.Point(116, 57);
            this.cmbPerformer.Name = "cmbPerformer";
            this.cmbPerformer.Size = new System.Drawing.Size(277, 24);
            this.cmbPerformer.TabIndex = 14;
            this.cmbPerformer.DropDownClosed += new System.EventHandler(this.cmbPerformer_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Album: ";
            // 
            // cmbAlbum
            // 
            this.cmbAlbum.FormattingEnabled = true;
            this.cmbAlbum.Location = new System.Drawing.Point(116, 98);
            this.cmbAlbum.Name = "cmbAlbum";
            this.cmbAlbum.Size = new System.Drawing.Size(277, 24);
            this.cmbAlbum.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(277, 22);
            this.txtName.TabIndex = 10;
            // 
            // btnSaveEditedSong
            // 
            this.btnSaveEditedSong.Location = new System.Drawing.Point(318, 442);
            this.btnSaveEditedSong.Name = "btnSaveEditedSong";
            this.btnSaveEditedSong.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEditedSong.TabIndex = 18;
            this.btnSaveEditedSong.Text = "Save";
            this.btnSaveEditedSong.UseVisualStyleBackColor = true;
            this.btnSaveEditedSong.Click += new System.EventHandler(this.btnSaveEditedSong_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEditSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 491);
            this.Controls.Add(this.btnSaveEditedSong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLyrics);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPerformer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAlbum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "frmEditSong";
            this.Text = "frmEditSong";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditSong_FormClosing);
            this.Load += new System.EventHandler(this.frmEditSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtLyrics;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPerformer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAlbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSaveEditedSong;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}