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

namespace assistente_social.Apresentacao
{
    public partial class frmProblematica : Form
    {
        public frmProblematica()
        {
            InitializeComponent();
        }

        private void VoltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEscolha frm = new frmEscolha();
            this.Hide();
            frm.ShowDialog();
        }

        private void LimparTelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            txbAtividade.Text = "";
        }

        private void ExcluirCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);

            if (txbNome.Text != "")
            {
                DialogResult msgSN = MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                //SE O ESCOLHER SIM FAÇA
                if (msgSN == DialogResult.Yes)
                {
                    try
                    {
                        Modelo.Conexao.obterConexao();
                        cmd = new SqlCommand("sp_ExcluirUsuario", Modelo.Conexao.conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nome", txbNome.Text);

                        cmd.Parameters.Add("@Mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                        cmd.ExecuteNonQuery();

                        string msg = cmd.Parameters["@Mensagem"].Value.ToString();
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);

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
                        txbAtividade.Text = "";


                        {
                            Listar();
                        }


                        void Listar()
                        {

                            {
                                DataTable dt = new DataTable();
                                SqlDataAdapter da = default(SqlDataAdapter);
                                try
                                {
                                    Modelo.Conexao.obterConexao();
                                    da = new SqlDataAdapter("SELECT * FROM CRIANCA", Modelo.Conexao.connString);
                                    da.Fill(dt);
                                    dgvMostar.DataSource = dt;


                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Erro.");
                                    Modelo.Conexao.FecharConexao();
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Excluir os dados " + ex.Message);
                        Modelo.Conexao.FecharConexao();
                    }
                }
            }

        }

        private void AtualizarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);

            if (txbNome.Text != "")
            {
                DialogResult msgSN = MessageBox.Show("Deseja Atualizar o cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                //SE O ESCOLHER SIM FAÇA
                if (msgSN == DialogResult.Yes)
                {
                    try
                    {
                        Modelo.Conexao.obterConexao();
                        cmd = new SqlCommand("sp_ExcluirUsuario", Modelo.Conexao.conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nome", txbNome.Text);

                        cmd.Parameters.Add("@Mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                        cmd.ExecuteNonQuery();

                        string msg = cmd.Parameters["@Mensagem"].Value.ToString();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Excluir os dados " + ex.Message);
                        Modelo.Conexao.FecharConexao();
                    }
                }
                if (txbNome.Text == (""))
                {
                    MessageBox.Show("Alguma campos não foi corretamente Preenchido.");
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

                        string inserir = "insert into CRIANCA (Nome, Escola, Data_Nascimento, Mae, Pai, responsavel, Endereco, Telefone, Casa_Propria, Bolsa_Familiae, Renda_Familiar, Gasto_mensal, Encaminhado, Problematica) values ('" + txbNome.Text + "','" + txbESCOLARIDADE.Text + "','" + txbDN.Text + "','" + txbMae.Text + "','" + txbPai.Text + "' ,'" + txbResponsavel.Text + "','" + txbEndereco.Text + "','" + txbNumero.Text + "','" + txbC_Propria.Text + "','" + txbB_Familia.Text + "','" + txbR_Familia.Text + "','" + txbG_Mensal.Text + "','" + txbEncaminhamento.Text + "','" + txbAtividade.Text + "')";
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
                        txbAtividade.Text = "";
                        MessageBox.Show("Cadastrada Atualizado Lucineia");


                        {
                            Listar();
                        }


                        void Listar()
                        {

                            {
                                DataTable dt = new DataTable();
                                SqlDataAdapter da = default(SqlDataAdapter);
                                try
                                {
                                    Modelo.Conexao.obterConexao();
                                    da = new SqlDataAdapter("SELECT * FROM CRIANCA", Modelo.Conexao.connString);
                                    da.Fill(dt);
                                    dgvMostar.DataSource = dt;


                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Erro.");
                                    Modelo.Conexao.FecharConexao();
                                }

                            }
                        }
                    }
                }
            }
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = default(SqlCommand);

            if (txbNome.Text != "")
            {
                DialogResult msgSN = MessageBox.Show("Deseja Colocar a problematica?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                //SE O ESCOLHER SIM FAÇA
                if (msgSN == DialogResult.Yes)
                {
                    try
                    {
                        Modelo.Conexao.obterConexao();
                        cmd = new SqlCommand("sp_ExcluirUsuario", Modelo.Conexao.conn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nome", txbNome.Text);

                        cmd.Parameters.Add("@Mensagem", SqlDbType.VarChar, 100).Direction = (System.Data.ParameterDirection)2;
                        cmd.ExecuteNonQuery();

                        string msg = cmd.Parameters["@Mensagem"].Value.ToString();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao Excluir os dados " + ex.Message);
                        Modelo.Conexao.FecharConexao();
                    }
                }
                if (txbNome.Text == (""))
                {
                    MessageBox.Show("Alguma campos não foi corretamente Preenchido.");
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

                        string inserir = "insert into CRIANCA (Nome, Escola, Data_Nascimento, Mae, Pai, responsavel, Endereco, Telefone, Casa_Propria, Bolsa_Familiae, Renda_Familiar, Gasto_mensal, Encaminhado, Problematica) values ('" + txbNome.Text + "','" + txbESCOLARIDADE.Text + "','" + txbDN.Text + "','" + txbMae.Text + "','" + txbPai.Text + "' ,'" + txbResponsavel.Text + "','" + txbEndereco.Text + "','" + txbNumero.Text + "','" + txbC_Propria.Text + "','" + txbB_Familia.Text + "','" + txbR_Familia.Text + "','" + txbG_Mensal.Text + "','" + txbEncaminhamento.Text + "','" + txbAtividade.Text + "')";
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
                        txbAtividade.Text = "";
                        MessageBox.Show("Problematica Cadastrada Lucineia");


                        {
                            Listar();
                        }


                        void Listar()
                        {

                            {
                                DataTable dt = new DataTable();
                                SqlDataAdapter da = default(SqlDataAdapter);
                                try
                                {
                                    Modelo.Conexao.obterConexao();
                                    da = new SqlDataAdapter("SELECT * FROM CRIANCA", Modelo.Conexao.connString);
                                    da.Fill(dt);
                                    dgvMostar.DataSource = dt;


                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Erro.");
                                    Modelo.Conexao.FecharConexao();
                                }

                            }
                        }
                    }
                }
            }
        }

        private void FrmProblematica_Load(object sender, EventArgs e)
        {
            {
                Listar();
            }


            void Listar()
            {

                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = default(SqlDataAdapter);
                    try
                    {
                        Modelo.Conexao.obterConexao();
                        da = new SqlDataAdapter("SELECT * FROM CRIANCA", Modelo.Conexao.connString);
                        da.Fill(dt);
                        dgvMostar.DataSource = dt;


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro.");
                        Modelo.Conexao.FecharConexao();
                    }

                }
            }
        }

        private void DgvMostar_DoubleClick(object sender, EventArgs e)
        {
            txbNome.Text = dgvMostar.CurrentRow.Cells[0].Value.ToString(); ;
            txbESCOLARIDADE.Text = dgvMostar.CurrentRow.Cells[1].Value.ToString(); ;
            txbDN.Text = dgvMostar.CurrentRow.Cells[2].Value.ToString(); ;
            txbMae.Text = dgvMostar.CurrentRow.Cells[3].Value.ToString(); ;
            txbPai.Text = dgvMostar.CurrentRow.Cells[4].Value.ToString(); ;
            txbResponsavel.Text = dgvMostar.CurrentRow.Cells[5].Value.ToString(); ;
            txbEndereco.Text = dgvMostar.CurrentRow.Cells[6].Value.ToString(); ;
            txbNumero.Text = dgvMostar.CurrentRow.Cells[7].Value.ToString(); ;
            txbC_Propria.Text = dgvMostar.CurrentRow.Cells[8].Value.ToString(); ;
            txbB_Familia.Text = dgvMostar.CurrentRow.Cells[9].Value.ToString(); ;
            txbR_Familia.Text = dgvMostar.CurrentRow.Cells[10].Value.ToString(); ;
            txbG_Mensal.Text = dgvMostar.CurrentRow.Cells[11].Value.ToString(); ;
            txbEncaminhamento.Text = dgvMostar.CurrentRow.Cells[12].Value.ToString(); ;
            txbAtividade.Text = dgvMostar.CurrentRow.Cells[13].Value.ToString(); ;
        }

        private void FrmProblematica_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modelo.Estatic.num = "";
        }
    }
}

