namespace Scrum_Table_projesi
{
    partial class Frm_Task
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
            this.cmb_StoryListe = new System.Windows.Forms.ComboBox();
            this.txt_TaskSure = new System.Windows.Forms.TextBox();
            this.txt_TaskYapilacak = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_TaskKategori = new System.Windows.Forms.ComboBox();
            this.txt_TaskYapan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTaskOlustur = new System.Windows.Forms.Button();
            this.btn_anaSayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Lütfen Story Seçin:";
            // 
            // cmb_StoryListe
            // 
            this.cmb_StoryListe.FormattingEnabled = true;
            this.cmb_StoryListe.Location = new System.Drawing.Point(351, 31);
            this.cmb_StoryListe.Name = "cmb_StoryListe";
            this.cmb_StoryListe.Size = new System.Drawing.Size(118, 21);
            this.cmb_StoryListe.TabIndex = 36;
            this.cmb_StoryListe.Text = "Seçin";
            // 
            // txt_TaskSure
            // 
            this.txt_TaskSure.Location = new System.Drawing.Point(351, 117);
            this.txt_TaskSure.Name = "txt_TaskSure";
            this.txt_TaskSure.Size = new System.Drawing.Size(118, 20);
            this.txt_TaskSure.TabIndex = 38;
            // 
            // txt_TaskYapilacak
            // 
            this.txt_TaskYapilacak.Location = new System.Drawing.Point(12, 30);
            this.txt_TaskYapilacak.Multiline = true;
            this.txt_TaskYapilacak.Name = "txt_TaskYapilacak";
            this.txt_TaskYapilacak.Size = new System.Drawing.Size(212, 76);
            this.txt_TaskYapilacak.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Task İçeriği:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Task Kategori:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Yapım Tarihi:";
            // 
            // cmb_TaskKategori
            // 
            this.cmb_TaskKategori.FormattingEnabled = true;
            this.cmb_TaskKategori.Items.AddRange(new object[] {
            "Başlamadı",
            "Devam Etmekte",
            "Bitti"});
            this.cmb_TaskKategori.Location = new System.Drawing.Point(351, 90);
            this.cmb_TaskKategori.Name = "cmb_TaskKategori";
            this.cmb_TaskKategori.Size = new System.Drawing.Size(118, 21);
            this.cmb_TaskKategori.TabIndex = 33;
            this.cmb_TaskKategori.Text = "Seçin";
            // 
            // txt_TaskYapan
            // 
            this.txt_TaskYapan.Location = new System.Drawing.Point(351, 64);
            this.txt_TaskYapan.Name = "txt_TaskYapan";
            this.txt_TaskYapan.Size = new System.Drawing.Size(118, 20);
            this.txt_TaskYapan.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Task Yapan:";
            // 
            // btnTaskOlustur
            // 
            this.btnTaskOlustur.Location = new System.Drawing.Point(12, 117);
            this.btnTaskOlustur.Name = "btnTaskOlustur";
            this.btnTaskOlustur.Size = new System.Drawing.Size(111, 29);
            this.btnTaskOlustur.TabIndex = 32;
            this.btnTaskOlustur.Text = "Task Oluştur";
            this.btnTaskOlustur.UseVisualStyleBackColor = true;
            this.btnTaskOlustur.Click += new System.EventHandler(this.btnTaskOlustur_Click);
            // 
            // btn_anaSayfa
            // 
            this.btn_anaSayfa.Location = new System.Drawing.Point(129, 115);
            this.btn_anaSayfa.Name = "btn_anaSayfa";
            this.btn_anaSayfa.Size = new System.Drawing.Size(95, 31);
            this.btn_anaSayfa.TabIndex = 42;
            this.btn_anaSayfa.Text = "Ana Sayfa";
            this.btn_anaSayfa.UseVisualStyleBackColor = true;
            this.btn_anaSayfa.Click += new System.EventHandler(this.btn_anaSayfa_Click);
            // 
            // Frm_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 156);
            this.Controls.Add(this.btn_anaSayfa);
            this.Controls.Add(this.txt_TaskYapilacak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TaskSure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTaskOlustur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_StoryListe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TaskYapan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_TaskKategori);
            this.Name = "Frm_Task";
            this.Text = "Frm_Task";
            this.Load += new System.EventHandler(this.Frm_Task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_StoryListe;
        public System.Windows.Forms.Button btnTaskOlustur;
        public System.Windows.Forms.TextBox txt_TaskYapilacak;
        public System.Windows.Forms.TextBox txt_TaskYapan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_TaskKategori;
        private System.Windows.Forms.TextBox txt_TaskSure;
        private System.Windows.Forms.Button btn_anaSayfa;
    }
}