namespace Scrum_Table_projesi
{
    partial class Frm_Story
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
            this.txtStoryIcerik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStoryOlustur = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTahminiSure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStBaslik = new System.Windows.Forms.TextBox();
            this.btn_anaSayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStoryIcerik
            // 
            this.txtStoryIcerik.Location = new System.Drawing.Point(228, 28);
            this.txtStoryIcerik.Multiline = true;
            this.txtStoryIcerik.Name = "txtStoryIcerik";
            this.txtStoryIcerik.Size = new System.Drawing.Size(273, 111);
            this.txtStoryIcerik.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Story İçeriği:";
            // 
            // btnStoryOlustur
            // 
            this.btnStoryOlustur.Location = new System.Drawing.Point(15, 110);
            this.btnStoryOlustur.Name = "btnStoryOlustur";
            this.btnStoryOlustur.Size = new System.Drawing.Size(95, 29);
            this.btnStoryOlustur.TabIndex = 32;
            this.btnStoryOlustur.Text = "Story Oluştur";
            this.btnStoryOlustur.UseVisualStyleBackColor = true;
            this.btnStoryOlustur.Click += new System.EventHandler(this.btnStoryOlustur_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tahmini Süre(Gün):";
            // 
            // txtTahminiSure
            // 
            this.txtTahminiSure.Location = new System.Drawing.Point(116, 25);
            this.txtTahminiSure.Name = "txtTahminiSure";
            this.txtTahminiSure.Size = new System.Drawing.Size(81, 20);
            this.txtTahminiSure.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Story Başlığı:";
            // 
            // txtStBaslik
            // 
            this.txtStBaslik.Location = new System.Drawing.Point(116, 64);
            this.txtStBaslik.Name = "txtStBaslik";
            this.txtStBaslik.Size = new System.Drawing.Size(82, 20);
            this.txtStBaslik.TabIndex = 37;
            // 
            // btn_anaSayfa
            // 
            this.btn_anaSayfa.Location = new System.Drawing.Point(116, 108);
            this.btn_anaSayfa.Name = "btn_anaSayfa";
            this.btn_anaSayfa.Size = new System.Drawing.Size(95, 31);
            this.btn_anaSayfa.TabIndex = 43;
            this.btn_anaSayfa.Text = "Ana Sayfa";
            this.btn_anaSayfa.UseVisualStyleBackColor = true;
            this.btn_anaSayfa.Click += new System.EventHandler(this.btn_anaSayfa_Click);
            // 
            // Frm_Story
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 162);
            this.Controls.Add(this.btn_anaSayfa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStBaslik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStoryIcerik);
            this.Controls.Add(this.txtTahminiSure);
            this.Controls.Add(this.btnStoryOlustur);
            this.Controls.Add(this.label7);
            this.Name = "Frm_Story";
            this.Text = "Frm_Story";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtStoryIcerik;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnStoryOlustur;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtTahminiSure;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtStBaslik;
        private System.Windows.Forms.Button btn_anaSayfa;
    }
}