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
    public partial class insTecniciFrm : Form
    {
        public insTecniciFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\User\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True");
            conn.Open();

            string query = "select * from dbTecnici where utente = '"+ userTxt.Text +"' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count ==1)
            {
                MessageBox.Show("Record esistente!");
                userTxt.Clear();
                pswTxt.Clear();
                userTxt.Focus();
            }
            else
            {
                SqlCommand queryIns = new SqlCommand("", conn);
                queryIns.CommandText = "insert into dbTecnici (utente,password) values ('" + userTxt.Text + "','" + pswTxt.Text + "')";
                queryIns.ExecuteNonQuery();

                conn.Close();
                this.Close();
            }

        }

        private void esciBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void insTecniciFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
