using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmRapportiniIns : Form
    {
        public frmRapportiniIns()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmRapportiniIns_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.dbRapportini' table. You can move, or remove it, as needed.
            this.dbRapportiniTableAdapter.Fill(this.database1DataSet.dbRapportini);

        }
    }
}
