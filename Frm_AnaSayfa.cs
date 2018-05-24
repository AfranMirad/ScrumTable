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
    public partial class Frm_AnaSayfa : Form
    {
        public int Id_Story;
        public int Id_Task;
        Frm_Duzenleme duzenle = new Frm_Duzenleme();
        public Frm_AnaSayfa()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        Connected connect = new Connected();
        OleDbDataAdapter adaptor;
        Frm_Duzenleme frm_duzenle = new Frm_Duzenleme();
        public Story stry = new Story();
        public Task tsk = new Task();
        private void btnStoryEkle_Click(object sender, EventArgs e)
        {
            Frm_Story frm_story = new Frm_Story();     
            frm_story.Show();
            this.Hide();
        }
        private void btnTaskEkle_Click(object sender, EventArgs e)
        {
            Frm_Task frm_task = new Frm_Task();
            frm_task.Show();
            this.Hide();
        }
        private void Frm_AnaSayfa_Load(object sender, EventArgs e)
        {
            connect.ConnectDataBase();                                     //Veritabanından çekilen kayıtlar datagrid e doldurulur.
            ds.Clear();
            adaptor = new OleDbDataAdapter("SELECT Table_Story.Id_Story, Table_Story.storyBaslık, Table_Task.Id_Task, Table_Task.taskYapacak, Table_Task.taskSure, Table_Task.taskYapılacak, Table_Task.taskKategori FROM Table_Story INNER JOIN Table_Task ON Table_Story.Id_Story = Table_Task.Id_storyBaglan",
                connect.baglanti);
            adaptor.Fill(ds);
            dtGrid_Scrum.DataSource = ds.Tables[0].DefaultView;
            connect.baglanti.Close();
        }
        private void dtGrid_Scrum_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            stry.SecilenId = dtGrid_Scrum.CurrentRow.Cells[0].Value.GetHashCode();        //Datagrid te seçilen satırın ıd'si alınır. 
            tsk.SecilenId = dtGrid_Scrum.CurrentRow.Cells[2].Value.GetHashCode();
            frm_duzenle.Show();
            this.Hide();
        }
    }
}
