namespace liriksi.WinUI.SongForms.SongUtilForms
{
    partial class frmAddPerformer
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
            this.btnAddPerformer = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.Label();
            this.txtArtisticName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picBoxPerformer = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblImg = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAbout = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPerformer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPerformer
            // 
            this.btnAddPerformer.Location = new System.Drawing.Point(445, 395);
            this.btnAddPerformer.Name = "btnAddPerformer";
            this.btnAddPerformer.Size = new System.Drawing.Size(75, 26);
            this.btnAddPerformer.TabIndex = 5;
            this.btnAddPerformer.Text = "Finish";
            this.btnAddPerformer.UseVisualStyleBackColor = true;
            this.btnAddPerformer.Click += new System.EventHandler(this.btnAddPerformer_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(414, 22);
            this.txtName.TabIndex = 4;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name: ";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(106, 54);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(414, 22);
            this.txtSurname.TabIndex = 7;
            this.txtSurname.Validating += new System.ComponentModel.CancelEventHandler(this.txtSurname_Validating);
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(8, 54);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(65, 17);
            this.Surname.TabIndex = 6;
            this.Surname.Text = "Surname";
            this.Surname.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtArtisticName
            // 
            this.txtArtisticName.Location = new System.Drawing.Point(106, 82);
            this.txtArtisticName.Name = "txtArtisticName";
            this.txtArtisticName.Size = new System.Drawing.Size(414, 22);
            this.txtArtisticName.TabIndex = 9;
            this.txtArtisticName.Validating += new System.ComponentModel.CancelEventHandler(this.txtArtisticName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Artistic name:";
            // 
            // picBoxPerformer
            // 
            this.picBoxPerformer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxPerformer.Location = new System.Drawing.Point(316, 255);
            this.picBoxPerformer.Name = "picBoxPerformer";
            this.picBoxPerformer.Size = new System.Drawing.Size(204, 105);
            this.picBoxPerformer.TabIndex = 10;
            this.picBoxPerformer.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(445, 366);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Location = new System.Drawing.Point(15, 255);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(46, 17);
            this.lblImg.TabIndex = 12;
            this.lblImg.Text = "Image";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtAbout
            // 
            this.txtAbout.Location = new System.Drawing.Point(106, 110);
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.Size = new System.Drawing.Size(414, 139);
            this.txtAbout.TabIndex = 13;
            this.txtAbout.Text = "";
            this.txtAbout.Validating += new System.ComponentModel.CancelEventHandler(this.txtAbout_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "About:";
            // 
            // frmAddPerformer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 433);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAbout);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.picBoxPerformer);
            this.Controls.Add(this.txtArtisticName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.btnAddPerformer);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "frmAddPerformer";
            this.Text = "frmAddPerformer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddPerformer_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddPerformer_FormClosed);
            this.Load += new System.EventHandler(this.frmAddPerformer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPerformer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPerformer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.TextBox txtArtisticName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBoxPerformer;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.RichTextBox txtAbout;
        private System.Windows.Forms.Label label2;
    }
}