namespace liriksi.WinUI.SongForms
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
            this.txtboxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSongSearch = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSong
            // 
            this.dgvSong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id});
            this.dgvSong.Location = new System.Drawing.Point(0, 61);
            this.dgvSong.Name = "dgvSong";
            this.dgvSong.ReadOnly = true;
            this.dgvSong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSong.Size = new System.Drawing.Size(800, 389);
            this.dgvSong.TabIndex = 0;
            this.dgvSong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSong_CellContentClick);
            this.dgvSong.DoubleClick += new System.EventHandler(this.DgvSong_DoubleClick);
            // 
            // txtboxTitle
            // 
            this.txtboxTitle.Location = new System.Drawing.Point(54, 22);
            this.txtboxTitle.Name = "txtboxTitle";
            this.txtboxTitle.Size = new System.Drawing.Size(160, 20);
            this.txtboxTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            // 
            // btnSongSearch
            // 
            this.btnSongSearch.Location = new System.Drawing.Point(220, 22);
            this.btnSongSearch.Name = "btnSongSearch";
            this.btnSongSearch.Size = new System.Drawing.Size(75, 21);
            this.btnSongSearch.TabIndex = 3;
            this.btnSongSearch.Text = "Search";
            this.btnSongSearch.UseVisualStyleBackColor = true;
            this.btnSongSearch.Click += new System.EventHandler(this.BtnSongSearch_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // frmSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSongSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxTitle);
            this.Controls.Add(this.dgvSong);
            this.Name = "frmSong";
            this.Text = "frmSong";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvSong;
        private System.Windows.Forms.TextBox txtboxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSongSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}