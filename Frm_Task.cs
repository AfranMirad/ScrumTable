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
    public partial class Frm_Task : Form
    {
        Frm_AnaSayfa frm_ana = new Frm_AnaSayfa();
        Story story = new Story();
        Connected connect = new Connected();
        OleDbCommand komut;
        OleDbDataAdapter adaptor;
        DataSet ds;
        public Frm_Task()
        {
            InitializeComponent();
        }
        private void btnTaskOlustur_Click(object sender, EventArgs e)
        {
            if (txt_TaskSure.Text!=""&&txt_TaskYapan.Text != "" &&txt_TaskYapilacak.Text != "" &&cmb_StoryListe.Text != "Seçin"&&cmb_TaskKategori.Text != "Seçin")
            {
                story.TaskAdd(txt_TaskYapan.Text.ToString(), Convert.ToInt32(txt_TaskSure.Text), txt_TaskYapilacak.Text.ToString(), cmb_TaskKategori.Text.ToString()); // Ekleme metodunu çalıştırır.
                frm_ana.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Lütfen Boş Değer Girmeyiniz.");

        }
        private void Frm_Task_Load(object sender, EventArgs e)
        {
        }
        public object ComboBoxDoldur()
        {
            connect.ConnectDataBase();                                                       //Veritabanından çekilen storyBaslık kaydı combobox a doldurulur.
            string sorgu = "select storyBaslık from Table_Scrum ";
            komut = new OleDbCommand(sorgu, connect.baglanti);
            adaptor = new OleDbDataAdapter(komut);
            adaptor.Fill(ds);
            cmb_StoryListe.Items.Add(ds.Tables[0].DefaultView);
            return komut.ExecuteNonQuery();
        }

        private void btn_anaSayfa_Click(object sender, EventArgs e)
        {
            frm_ana.Show();
            this.Hide();
               
        }
    }
}
