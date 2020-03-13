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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(107, 21);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(175, 22);
            this.txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(12, 64);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(89, 17);
            this.Genre.TabIndex = 3;
            this.Genre.Text = "Year release";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Genre";
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(107, 104);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(175, 24);
            this.cmbGenre.TabIndex = 6;
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(288, 104);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(75, 24);
            this.btnAddGenre.TabIndex = 7;
            this.btnAddGenre.Text = "Add new";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 145);
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
            this.cmbYear.Location = new System.Drawing.Point(107, 62);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(175, 24);
            this.cmbYear.TabIndex = 9;
            // 
            // frmAddAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 201);
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
            this.Load += new System.EventHandler(this.frmAddAlbum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbYear;
    }
}