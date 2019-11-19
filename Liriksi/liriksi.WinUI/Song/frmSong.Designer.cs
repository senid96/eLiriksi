namespace liriksi.WinUI.Song
{
    partial class frmSong
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
            this.dgvSong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchSong = new System.Windows.Forms.Button();
            this.txtboxSongTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSong
            // 
            this.dgvSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSong.Location = new System.Drawing.Point(12, 78);
            this.dgvSong.Name = "dgvSong";
            this.dgvSong.Size = new System.Drawing.Size(776, 360);
            this.dgvSong.TabIndex = 0;
            this.dgvSong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSong_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Song title:";
            // 
            // btnSearchSong
            // 
            this.btnSearchSong.Location = new System.Drawing.Point(271, 37);
            this.btnSearchSong.Name = "btnSearchSong";
            this.btnSearchSong.Size = new System.Drawing.Size(75, 23);
            this.btnSearchSong.TabIndex = 2;
            this.btnSearchSong.Text = "Search";
            this.btnSearchSong.UseVisualStyleBackColor = true;
            this.btnSearchSong.Click += new System.EventHandler(this.BtnSearchSong_Click);
            // 
            // txtboxSongTitle
            // 
            this.txtboxSongTitle.Location = new System.Drawing.Point(69, 39);
            this.txtboxSongTitle.Name = "txtboxSongTitle";
            this.txtboxSongTitle.Size = new System.Drawing.Size(196, 20);
            this.txtboxSongTitle.TabIndex = 3;
            // 
            // frmSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxSongTitle);
            this.Controls.Add(this.btnSearchSong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSong);
            this.Name = "frmSong";
            this.Text = "frmSong";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchSong;
        private System.Windows.Forms.TextBox txtboxSongTitle;
    }
}