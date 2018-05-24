using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Scrum_Table_projesi
{
    public class Connected
    {
        string baglantiCumlesi = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\db_scrum.accdb;Persist Security Info=False;";
        public OleDbConnection baglanti;
        public Connected()
        {
            baglanti = new OleDbConnection(baglantiCumlesi);
        }
        public void ConnectDataBase()
        {
            try
            {
                baglanti.Open();
            }
            catch (Exception)
            {
                baglanti.Close();
                baglanti.Open();
            }
        }

    }
}
