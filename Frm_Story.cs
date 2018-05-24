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
    public partial class Frm_Story : Form

    {
        Frm_AnaSayfa frm_ana = new Frm_AnaSayfa();
        StoryOperation storyOperation = new StoryOperation();
        public Frm_Story()
        {
            InitializeComponent();
        }
        private void btnStoryOlustur_Click(object sender, EventArgs e)
        {
            if (txtStBaslik.Text!=""&&txtStoryIcerik.Text != "" &&txtTahminiSure.Text != "" )
            {
                storyOperation.StoryAdd(txtStBaslik.Text.ToString(), txtStoryIcerik.Text.ToString(), Convert.ToInt32(txtTahminiSure.Text));     //Story ekleme metodu çalışır.
                frm_ana.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Lütfen Boş Değer Girmeyiniz");

        }

        private void btn_anaSayfa_Click(object sender, EventArgs e)
        {
            frm_ana.Show();
            this.Hide();
        }
    }
}
