using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Scrum_Table_projesi
{
    public class StoryOperation
    {
        public OleDbCommand komut = new OleDbCommand();
        Connected connect = new Connected();
        public void StoryAdd(string storyBaslik, string storyAyrinti, int storySrue)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Yeni kayıt yapmak istediğinizden emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    connect.ConnectDataBase();                           //Alınan parametreye göre yeni kayıt yapmakta
                    komut.Connection = connect.baglanti;
                    komut.CommandText = "INSERT INTO  Table_Story (storyBaslık,storyAyrıntı,storySure) VALUES (@storyBaslık,@storyAyrıntı,@storySure)";
                    komut.Parameters.AddWithValue("storyBaslik", storyBaslik);
                    komut.Parameters.AddWithValue("storyAyrinti", storyAyrinti);
                    komut.Parameters.AddWithValue("storySrue", storySrue);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayit Başarılı !");
                    connect.baglanti.Close();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
