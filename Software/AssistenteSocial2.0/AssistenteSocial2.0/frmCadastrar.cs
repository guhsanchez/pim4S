﻿using ClasseControle.DAO;
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
    public partial class frmCadastrar : Form
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClasseModel.DTO.UsuarioDTO usuario = new ClasseModel.DTO.UsuarioDTO();
            usuario.Nome = txbNome.Text;
            usuario.Mae = txbMAe.Text;
            usuario.Pai = txbPai.Text;
            usuario.RendaFamilia = txbRFamilia.Text;
            usuario.Responsavel = txbResponsavel.Text;
            usuario.Telefone = txbTelefone.Text;
            usuario.GastoMensal = txbGMensal.Text;
            usuario.Escola = txbEscola.Text;
            usuario.Endereco = txbEndereco.Text;
            usuario.Encaminhado = txbEncaminhado.Text;
            usuario.CasaPropria = txbCPropria.Text;
            usuario.BolsaFamilia = txbBFamilia.Text;
            usuario.DataNascimento = txbDtNascimento.Text;
            usuario.Atendimento1 = ("");

            try
            {
                UsuarioDAO.getinstancia().Save(usuario);
                MessageBox.Show("Sucesso");
            }
            catch (Exception z)
            {

                MessageBox.Show(z.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmEscolha frm = new frmEscolha();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
