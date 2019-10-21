using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assistente_social.Apresentacao
{
    public partial class frmEscolha : Form
    {
        public frmEscolha()
        {
            InitializeComponent();
        }
        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCadastrar frm = new frmCadastrar();
            this.Hide();
            frm.ShowDialog();
        }

        private void ProblematicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProblematica frm = new frmProblematica();
            this.Hide();
            frm.ShowDialog();
        }

        private void FrmEscolha_Load(object sender, EventArgs e)
        {
            if (Modelo.Estatic.num == "")
            {
                this.Hide();
                Apresentacao.frmFlash frm = new Apresentacao.frmFlash();
                frm.Show();
                frm.Update();
                System.Threading.Thread.Sleep(5100);
                frm.Close();
                this.Visible = true;
                Modelo.Estatic.num = "1";
            }

        }

        private void FrmEscolha_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modelo.Estatic.num = "";
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
