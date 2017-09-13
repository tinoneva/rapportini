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
    public partial class frmPagamenti : Form
    {
        public frmPagamenti()
        {
            InitializeComponent();
        }

        private void frmPagamenti_Load(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\User\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True");
            DataTable pagamentiDt = new DataTable();

            conn.Open();

            SqlDataReader leggi = null;
            SqlCommand comando = new SqlCommand("Select * from dbTipoPagamento order by codice",conn);
            leggi = comando.ExecuteReader();
            pagamentiDt.Clear();
            pagamentiDt.Load(leggi);

            pagamentiDgv.DataSource=pagamentiDt;
            conn.Close();
            pagamentiDgv.Columns["idTipoPagamento"].Visible=false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\User\Documents\Visual Studio 2013\Projects\WindowsFormsApplication1\WindowsFormsApplication1\Database1.mdf;Integrated Security=True");
            DataTable pagamentiDt = new DataTable();

            conn.Open();
         
                SqlCommand queryIns = new SqlCommand("", conn);
                queryIns.CommandText = "insert into dbTipoPagamento(codice,descrizione) values ('" + codiceTxt.Text + "', '" + descrizioneTxt.Text + "')";
                queryIns.ExecuteNonQuery();

                conn.Close();

        }

        private void pagamentiDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        }

    }

