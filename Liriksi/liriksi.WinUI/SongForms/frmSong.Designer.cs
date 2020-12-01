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
            this.components = new System.ComponentModel.Container();
            this.dgvSong = new System.Windows.Forms.DataGridView();
            this.txtboxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSongSearch = new System.Windows.Forms.Button();
            this.Keyword = new System.Windows.Forms.Label();
            this.txtBoxLyrics = new System.Windows.Forms.TextBox();
            this.btnClearInputs = new System.Windows.Forms.Button();
            this.userGetRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGetRequestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSong
            // 
            this.dgvSong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Text});
            this.dgvSong.Location = new System.Drawing.Point(0, 97);
            this.dgvSong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSong.Name = "dgvSong";
            this.dgvSong.ReadOnly = true;
            this.dgvSong.RowHeadersWidth = 51;
            this.dgvSong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSong.Size = new System.Drawing.Size(1067, 457);
            this.dgvSong.TabIndex = 0;
            this.dgvSong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSong_CellContentClick);
            this.dgvSong.DoubleClick += new System.EventHandler(this.DgvSong_DoubleClick);
            // 
            // txtboxTitle
            // 
            this.txtboxTitle.Location = new System.Drawing.Point(91, 15);
            this.txtboxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxTitle.Name = "txtboxTitle";
            this.txtboxTitle.Size = new System.Drawing.Size(212, 22);
            this.txtboxTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            // 
            // btnSongSearch
            // 
            this.btnSongSearch.Location = new System.Drawing.Point(324, 47);
            this.btnSongSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSongSearch.Name = "btnSongSearch";
            this.btnSongSearch.Size = new System.Drawing.Size(100, 26);
            this.btnSongSearch.TabIndex = 3;
            this.btnSongSearch.Text = "Search";
            this.btnSongSearch.UseVisualStyleBackColor = true;
            this.btnSongSearch.Click += new System.EventHandler(this.BtnSongSearch_Click);
            // 
            // Keyword
            // 
            this.Keyword.AutoSize = true;
            this.Keyword.Location = new System.Drawing.Point(5, 50);
            this.Keyword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Keyword.Name = "Keyword";
            this.Keyword.Size = new System.Drawing.Size(62, 17);
            this.Keyword.TabIndex = 5;
            this.Keyword.Text = "Keyword";
            // 
            // txtBoxLyrics
            // 
            this.txtBoxLyrics.Location = new System.Drawing.Point(91, 47);
            this.txtBoxLyrics.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxLyrics.Name = "txtBoxLyrics";
            this.txtBoxLyrics.Size = new System.Drawing.Size(212, 22);
            this.txtBoxLyrics.TabIndex = 4;
            // 
            // btnClearInputs
            // 
            this.btnClearInputs.Location = new System.Drawing.Point(432, 47);
            this.btnClearInputs.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearInputs.Name = "btnClearInputs";
            this.btnClearInputs.Size = new System.Drawing.Size(100, 26);
            this.btnClearInputs.TabIndex = 6;
            this.btnClearInputs.Text = "Clear";
            this.btnClearInputs.UseVisualStyleBackColor = true;
            this.btnClearInputs.Click += new System.EventHandler(this.BtnClearInputs_Click);
            // 
            // userGetRequestBindingSource
            // 
            this.userGetRequestBindingSource.DataSource = typeof(liriksi.Model.Requests.UserGetRequest);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Text
            // 
            this.Text.DataPropertyName = "Text";
            this.Text.HeaderText = "Text";
            this.Text.Name = "Text";
            this.Text.ReadOnly = true;
            // 
            // frmSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnClearInputs);
            this.Controls.Add(this.Keyword);
            this.Controls.Add(this.txtBoxLyrics);
            this.Controls.Add(this.btnSongSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxTitle);
            this.Controls.Add(this.dgvSong);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSong";
            this.Load += new System.EventHandler(this.FrmSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGetRequestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvSong;
        private System.Windows.Forms.TextBox txtboxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSongSearch;
        private System.Windows.Forms.Label Keyword;
        private System.Windows.Forms.TextBox txtBoxLyrics;
        private System.Windows.Forms.Button btnClearInputs;
        private System.Windows.Forms.BindingSource userGetRequestBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Text;
    }
}