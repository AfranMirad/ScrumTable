using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Scrum_Table_projesi
{
    public partial class Frm_Duzenleme : Form
    {
        Connected connect = new Connected();
        OleDbCommand komutStory,komutTask,komut, komutguncelleStory, komutguncelleTask;
        Story stry = new Story();
        Task tsk = new Task();
        public Frm_Duzenleme()
        {
            InitializeComponent();
        }
        public void Doldur()
        {
            connect.ConnectDataBase();
            komutStory = new OleDbCommand("select * from Table_Story where Id_Story ='" + stry.SecilenId + "'", connect.baglanti);
            komutTask = new OleDbCommand("select * from Table_Task where Id_Task ='" + tsk.SecilenId + "'", connect.baglanti);

            komutStory.Parameters.AddWithValue("@storyBaslık", txtStBaslik.Text);
            komutStory.Parameters.AddWithValue("@storySure", txtTahminiSure.Text);
            komutStory.Parameters.AddWithValue("@storyAyrıntı", txtStoryIcerik.Text);
            komutTask.Parameters.AddWithValue("@taskYapacak", txt_TaskYapan.Text);
            komutTask.Parameters.AddWithValue("@taskKategori", cmb_TaskKategori.Text);
            komutTask.Parameters.AddWithValue("@taskSure", txt_TaskSure.Text);
            komutTask.Parameters.AddWithValue("@taskYapılacak", txt_TaskYapilacak.Text);

            komutStory.ExecuteNonQuery();
            komutStory.Dispose();
            komutTask.ExecuteNonQuery();
            komutTask.Dispose();
            connect.baglanti.Close();
        }
        private void btn_Sil_Click(object sender, EventArgs e)
        {
                VeriSil1_cal();
        }

        private void btn_anaSayfa_Click(object sender, EventArgs e)
        {
            Frm_AnaSayfa frm_Ana = new Frm_AnaSayfa();
            frm_Ana.Show();
            this.Hide();
        }

        private void btn_Duzenle_Click(object sender, EventArgs e)
        {
            if (txtStBaslik.Text != "" && txtStoryIcerik.Text != "" && txtTahminiSure.Text != ""&& txt_TaskSure.Text != "" && txt_TaskYapan.Text != "" && txt_TaskYapilacak.Text != ""  && cmb_TaskKategori.Text != "Seçin")
            {
                Duzenle();
                Frm_AnaSayfa frm_Ana = new Frm_AnaSayfa();
                frm_Ana.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Lütfen Boş Değer Girmeyiniz");

        }
        private void Frm_duzenleme_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        public void Duzenle()
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı düzenlemek istediğinizden emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    connect.ConnectDataBase();                                 //Ana sayfada atanan id ye göre kayıtlar çekilir. Textbox tan veriler güncellenir.
                    komutguncelleStory = new OleDbCommand("UPDATE Table_Story SET storyBaslık='" + txtStBaslik.Text + "', storySure ='" + txtTahminiSure + "', storyAyrıntı ='" + txtStoryIcerik + "' WHERE Id_Story = " + stry.SecilenId, connect.baglanti);
                    komutguncelleTask = new OleDbCommand("UPDATE Table_Task SET taskYapacak='" + txt_TaskYapan.Text + "', taskKategori ='" + cmb_TaskKategori.Text + "', taskSure ='" + txt_TaskSure.Text + "', taskYapılacak ='" + txt_TaskYapilacak.Text+ "' WHERE Id_Task = " + tsk.SecilenId, connect.baglanti);
                    komutguncelleStory.ExecuteNonQuery();
                    komutguncelleTask.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarıyla Güncellendi !", "Kayıt Güncelleme!");
                    connect.baglanti.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden bir alan seçiniz.", "UYARI");
            }
        }
        public void VeriSil1_cal()
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    connect.ConnectDataBase();                                     //Ana sayfada atanan id ye göre kayıtlar çekilir. Textbox tan veriler silinir.
                    komut = new OleDbCommand();
                    komut.Connection = connect.baglanti;
                    komut.CommandText = "delete from Table_Story where Id_Story =" + stry.SecilenId + "delete from Table_Task where Id_Task =" + tsk.SecilenId;
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    connect.baglanti.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden bir alan seçiniz.", "UYARI");
            }
        }
    }
}
