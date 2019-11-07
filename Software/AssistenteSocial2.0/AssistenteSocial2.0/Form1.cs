using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasseControle.DAO;
using ClasseModel.DTO;
using System.Windows.Forms;
using ClasseControle.BL;

namespace AssistenteSocial2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            ClasseModel.DTO.UsuarioDTO usuario = new ClasseModel.DTO.UsuarioDTO();
            usuario.Senha = txbSenha.Text;

            try
            {
                UsuarioDTO porra = ClasseControle.Controle.Controle.getinstancia().RealizaLogin(txbSenha.Text);
                frmEscolha frm = new frmEscolha();
                this.Hide();
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
