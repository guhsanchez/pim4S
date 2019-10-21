using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assistente_social
{
    public partial class frmCadastrar : Form
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Apresentacao.frmEscolha frm = new Apresentacao.frmEscolha();
            this.Hide();
            frm.ShowDialog();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (txbNome.Text == (""))
            {
                MessageBox.Show("Nome não foi colocado.");
            }
            else
            {

                // vamos obter a conexão com o banco de dados
                SqlConnection conn = Modelo.Conexao.obterConexao();

                // a conexão foi efetuada com sucesso?
                if (conn == null)
                {
                    MessageBox.Show("Não foi possível obter a conexão. Veja o log de erros.");
                }
                else
                {

                    string inserir = "insert into CRIANCA (Nome, Escola, Data_Nascimento, Mae, Pai, responsavel, Endereco, Telefone, Casa_Propria, Bolsa_Familiae, Renda_Familiar, Gasto_mensal, Encaminhado) values ('" + txbNome.Text + "','" + txbESCOLARIDADE.Text + "','" + txbDN.Text + "','" + txbMae.Text + "','" + txbPai.Text + "' ,'" + txbResponsavel.Text + "','" + txbEndereco.Text + "','" + txbNumero.Text + "','" + txbC_Propria.Text + "','" + txbB_Familia.Text + "','" + txbR_Familia.Text + "','" + txbG_Mensal.Text + "','" + txbEncaminhamento.Text + "')";
                    SqlCommand cmdInserir = new SqlCommand(inserir, conn);

                    cmdInserir.ExecuteNonQuery();
                    txbNome.Text = "";
                    txbESCOLARIDADE.Text = "";
                    txbDN.Text = "";
                    txbMae.Text = "";
                    txbPai.Text = "";
                    txbResponsavel.Text = "";
                    txbEndereco.Text = "";
                    txbNumero.Text = "";
                    txbC_Propria.Text = "";
                    txbB_Familia.Text = "";
                    txbR_Familia.Text = "";
                    txbG_Mensal.Text = "";
                    txbEncaminhamento.Text = "";
                    MessageBox.Show("Criança Cadastrada Lucineia");
                }
            }
        }

        private void FrmCadastrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modelo.Estatic.num = "";
        }

        private void FrmCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void LblG_Mensal_Click(object sender, EventArgs e)
        {

        }

        private void LblR_Familia_Click(object sender, EventArgs e)
        {

        }

        private void LblB_Familia_Click(object sender, EventArgs e)
        {

        }

        private void LblC_Propria_Click(object sender, EventArgs e)
        {

        }

        private void LblPai_Click(object sender, EventArgs e)
        {

        }

        private void LblMae_Click(object sender, EventArgs e)
        {

        }

        private void LblESCOLARIDADE_Click(object sender, EventArgs e)
        {

        }

        private void LblDN_Click(object sender, EventArgs e)
        {

        }

        private void LblResponsavel_Click(object sender, EventArgs e)
        {

        }

        private void LblEndereco_Click(object sender, EventArgs e)
        {

        }

        private void LblNumero_Click(object sender, EventArgs e)
        {

        }

        private void LblNome_Click(object sender, EventArgs e)
        {

        }

        private void LblEncaminhamento_Click(object sender, EventArgs e)
        {

        }

        private void TxbEncaminhamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbG_Mensal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbR_Familia_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbB_Familia_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbC_Propria_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbResponsavel_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbPai_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbMae_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbESCOLARIDADE_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

