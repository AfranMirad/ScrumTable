namespace Scrum_Table_projesi
{
    partial class Frm_AnaSayfa
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
            this.btnTaskEkle = new System.Windows.Forms.Button();
            this.btnStoryEkle = new System.Windows.Forms.Button();
            this.dtGrid_Scrum = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Scrum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.Location = new System.Drawing.Point(408, 225);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(121, 29);
            this.btnTaskEkle.TabIndex = 16;
            this.btnTaskEkle.Text = "Task Ekle";
            this.btnTaskEkle.UseVisualStyleBackColor = true;
            this.btnTaskEkle.Click += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // btnStoryEkle
            // 
            this.btnStoryEkle.Location = new System.Drawing.Point(281, 225);
            this.btnStoryEkle.Name = "btnStoryEkle";
            this.btnStoryEkle.Size = new System.Drawing.Size(121, 29);
            this.btnStoryEkle.TabIndex = 15;
            this.btnStoryEkle.Text = "Story Yönet";
            this.btnStoryEkle.UseVisualStyleBackColor = true;
            this.btnStoryEkle.Click += new System.EventHandler(this.btnStoryEkle_Click);
            // 
            // dtGrid_Scrum
            // 
            this.dtGrid_Scrum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_Scrum.Location = new System.Drawing.Point(12, 12);
            this.dtGrid_Scrum.Name = "dtGrid_Scrum";
            this.dtGrid_Scrum.Size = new System.Drawing.Size(876, 207);
            this.dtGrid_Scrum.TabIndex = 14;
            this.dtGrid_Scrum.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGrid_Scrum_CellMouseClick);
            // 
            // Frm_AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 283);
            this.Controls.Add(this.btnTaskEkle);
            this.Controls.Add(this.btnStoryEkle);
            this.Controls.Add(this.dtGrid_Scrum);
            this.Name = "Frm_AnaSayfa";
            this.Text = "Frm_AnaSayfa";
            this.Load += new System.EventHandler(this.Frm_AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_Scrum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaskEkle;
        private System.Windows.Forms.Button btnStoryEkle;
        private System.Windows.Forms.DataGridView dtGrid_Scrum;
    }
}