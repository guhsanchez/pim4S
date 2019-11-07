using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistenteSocial2._0
{
    public partial class frmEscolha : Form
    {
        public frmEscolha()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrar frm = new frmCadastrar();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnAtendimento_Click(object sender, EventArgs e)
        {
            frmAtendimento frm = new frmAtendimento();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
