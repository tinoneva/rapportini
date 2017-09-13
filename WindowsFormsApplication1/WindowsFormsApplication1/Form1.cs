using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class homeFrm : Form
    {
        public homeFrm()
        {
            InitializeComponent();
        }

        private void rptDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entraBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\User\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True");
            conn.Open();

            string query = "select * from dbTecnici where utente ='" + usertTxt.Text + "'and password= '" + passwTxt.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count ==1)
            {
                this.Hide();
                inizioFrm formInizio = new inizioFrm();
                formInizio.ShowDialog();



            }
            else
            {
                MessageBox.Show("Verificare user e Password");
                usertTxt.Clear();
                passwTxt.Clear();
                usertTxt.Focus();
            }

            conn.Close();
        }

        private void dbRapportiniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        

        }

        private void homeFrm_Load(object sender, EventArgs e)
        {
           

        }
    }
}
