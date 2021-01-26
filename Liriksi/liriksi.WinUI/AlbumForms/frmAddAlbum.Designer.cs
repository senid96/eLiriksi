namespace liriksi.WinUI.UtilForms
{
    partial class frmAddAlbum
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.picboxAlbum = new System.Windows.Forms.PictureBox();
            this.lblPerformer = new System.Windows.Forms.Label();
            this.cmbPerformer = new System.Windows.Forms.ComboBox();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAbout = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(109, 26);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(235, 22);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(10, 65);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(89, 17);
            this.Genre.TabIndex = 3;
            this.Genre.Text = "Year release";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Genre";
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(109, 140);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(152, 24);
            this.cmbGenre.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 8;
            this.button2.Text = "Finish";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.finishAlbum_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(109, 62);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(235, 24);
            this.cmbYear.TabIndex = 9;
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(269, 458);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(75, 24);
            this.btnOpenFileDialog.TabIndex = 47;
            this.btnOpenFileDialog.Text = "Upload img";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // picboxAlbum
            // 
            this.picboxAlbum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxAlbum.Location = new System.Drawing.Point(202, 353);
            this.picboxAlbum.Name = "picboxAlbum";
            this.picboxAlbum.Size = new System.Drawing.Size(142, 99);
            this.picboxAlbum.TabIndex = 50;
            this.picboxAlbum.TabStop = false;
            // 
            // lblPerformer
            // 
            this.lblPerformer.AutoSize = true;
            this.lblPerformer.Location = new System.Drawing.Point(10, 107);
            this.lblPerformer.Name = "lblPerformer";
            this.lblPerformer.Size = new System.Drawing.Size(71, 17);
            this.lblPerformer.TabIndex = 51;
            this.lblPerformer.Text = "Performer";
            // 
            // cmbPerformer
            // 
            this.cmbPerformer.FormattingEnabled = true;
            this.cmbPerformer.Location = new System.Drawing.Point(109, 102);
            this.cmbPerformer.Name = "cmbPerformer";
            this.cmbPerformer.Size = new System.Drawing.Size(235, 24);
            this.cmbPerformer.TabIndex = 52;
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(269, 140);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(75, 24);
            this.btnAddGenre.TabIndex = 7;
            this.btnAddGenre.Text = "Add new";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Cover photo";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtAbout
            // 
            this.txtAbout.Location = new System.Drawing.Point(109, 183);
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.Size = new System.Drawing.Size(235, 151);
            this.txtAbout.TabIndex = 54;
            this.txtAbout.Text = "";
            this.txtAbout.Validating += new System.ComponentModel.CancelEventHandler(this.txtAbout_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "About";
            // 
            // frmAddAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 517);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAbout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPerformer);
            this.Controls.Add(this.lblPerformer);
            this.Controls.Add(this.picboxAlbum);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Name = "frmAddAlbum";
            this.Text = "frmAddAlbum";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddAlbum_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddAlbum_FormClosed);
            this.Load += new System.EventHandler(this.frmAddAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.PictureBox picboxAlbum;
        private System.Windows.Forms.Label lblPerformer;
        private System.Windows.Forms.ComboBox cmbPerformer;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtAbout;
    }
}