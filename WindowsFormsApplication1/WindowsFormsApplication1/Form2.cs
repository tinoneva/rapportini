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
    public partial class inizioFrm : Form
    {
        public inizioFrm()
        {
            InitializeComponent();
        }

        private void fineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void inserimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            insTecniciFrm formInsTecnici = new insTecniciFrm();
            formInsTecnici.MdiParent = this;
            formInsTecnici.Show();

        }

        private void archiviToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inserimentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPagamenti formPagamenti = new frmPagamenti();
            formPagamenti.MdiParent = this;
            formPagamenti.Show();
        }

        private void inizioFrm_Load(object sender, EventArgs e)
        {

        }

        private void modificaEliminaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void inserimentoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmRapportiniIns formRapportini = new frmRapportiniIns();
            formRapportini.Show();

        }
    }
}
