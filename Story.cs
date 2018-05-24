using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Scrum_Table_projesi
{
    public class Story
    {
        OleDbCommand komut = new OleDbCommand();
        Connected connect = new Connected();
        public int SecilenId = -1;
        public void TaskAdd(string taskYapacak, int taskSure, string taskYapılacak,string taskKategori)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Yeni kayıt yapmak istediğinizden emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    connect.ConnectDataBase();                                            //Alınan parametreye göre yeni kayıt yapmakta
                    komut.Connection = connect.baglanti;
                    komut.CommandText = "INSERT INTO  Table_Task (taskYapacak,taskSure,taskYapılacak,taskKategori) VALUES (@taskYapacak,@taskSure,@taskYapılacak,@taskKategori)";
                    komut.Parameters.AddWithValue("taskYapacak", taskYapacak);
                    komut.Parameters.AddWithValue("taskSure", taskSure);
                    komut.Parameters.AddWithValue("taskYapılacak", taskYapılacak);
                    komut.Parameters.AddWithValue("taskKategori", taskKategori);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayit Başarılı !");
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
