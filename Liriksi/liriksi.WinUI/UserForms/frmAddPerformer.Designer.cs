namespace liriksi.WinUI.UserForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArtisticName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddPerformer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(105, 77);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(244, 22);
            this.txtSurname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // txtArtisticName
            // 
            this.txtArtisticName.Location = new System.Drawing.Point(105, 117);
            this.txtArtisticName.Name = "txtArtisticName";
            this.txtArtisticName.Size = new System.Drawing.Size(244, 22);
            this.txtArtisticName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "ArtisticName";
            // 
            // btnAddPerformer
            // 
            this.btnAddPerformer.Location = new System.Drawing.Point(274, 154);
            this.btnAddPerformer.Name = "btnAddPerformer";
            this.btnAddPerformer.Size = new System.Drawing.Size(75, 23);
            this.btnAddPerformer.TabIndex = 6;
            this.btnAddPerformer.Text = "Finish";
            this.btnAddPerformer.UseVisualStyleBackColor = true;
            // 
            // frmAddPerformer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 229);
            this.Controls.Add(this.btnAddPerformer);
            this.Controls.Add(this.txtArtisticName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "frmAddPerformer";
            this.Text = "frmAddPerformer";
            this.Load += new System.EventHandler(this.frmAddPerformer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArtisticName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddPerformer;
    }
}