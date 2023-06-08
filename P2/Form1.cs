using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Org.BouncyCastle.Crypto.Digests.SkeinEngine;

namespace P2
{
    public partial class Form1 : Form
    {
        //conexao do MYSQL
        private MySqlConnection conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=test";

        
        private int ?idClienteSelecionado = null; //quando o '?' fica antes da variavel int ela vira um tipo anulavel

        
        public Form1()
        {   //janela nao maximiza
            this.MaximizeBox = false;
            //janela não pode ser redimensionada 
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            InitializeComponent();

            list_Busca.View = View.Details;
            list_Busca.LabelEdit = false;
            list_Busca.AllowColumnReorder = true;
            list_Busca.FullRowSelect = true;
            list_Busca.GridLines = true;

            list_Busca.Columns.Add("ID", 30, HorizontalAlignment.Left);
            list_Busca.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            list_Busca.Columns.Add("Telefone", 150, HorizontalAlignment.Left);
            list_Busca.Columns.Add("CPF", 150, HorizontalAlignment.Left);
            list_Busca.Columns.Add("CNH", 150, HorizontalAlignment.Left);

            carregar_clientes();

        }
     
        private void button1_Click(object sender, EventArgs e)   //Botão cadastrar cliente
        {

            // Verificar se algum campo está vazio
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtTelefone.Text) ||
                string.IsNullOrEmpty(txtCPF.Text) || string.IsNullOrEmpty(txtCNH.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Encerrar a execução do método
            }
            try
            {
                conexao = new MySqlConnection(data_source); //Endereço do banco de dados

                conexao.Open(); // abrir o serviço

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conexao;

                    //Inicia o insert no Banco
                    cmd.CommandText = "INSERT INTO clientes (nome, telefone, cpf, cnh)" + //inserir no viewlist
                        "VALUES " +
                        "(@nome, @telefone, @cpf, @cnh)";

                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                    cmd.Parameters.AddWithValue("@cnh", txtCNH.Text);

                    cmd.ExecuteNonQuery(); //retorna o número de linhas afetadas
                carregar_clientes();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ocorreu" + ex.Message, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conexao.Close();
            }


                       
            this.txtNome.Clear();
            this.txtCNH.Clear();
            this.txtCPF.Clear();
            this.txtTelefone.Clear();
        }

        private void list_Busca_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = list_Busca.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {


                idClienteSelecionado = Convert.ToInt32(item.SubItems[0].Text);

                txtNome.Text = item.SubItems[1].Text;
                txtTelefone.Text = item.SubItems[2].Text;
                txtCPF.Text = item.SubItems[3].Text;
                txtCNH.Text = item.SubItems[4].Text;

            }
        }


        private void botaoFiltrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "'%" + txtBuscarCliente.Text + "%'";

                conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                    "FROM clientes " +
                    "WHERE cpf LIKE " + q + "OR nome LIKE " + q;

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);


                MySqlDataReader reader = comando.ExecuteReader();

                list_Busca.Items.Clear();

                while(reader.Read()) //reader = leitor de informações do banco de dados 
                                     //Read = observador que passa de linha em linha
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                    };

                    var linha_listview = new ListViewItem(row);

                    list_Busca.Items.Add(linha_listview);
                }
            }
             catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {

                conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                    "FROM clientes ";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);


                MySqlDataReader reader = comando.ExecuteReader();

                list_Busca.Items.Clear();

                while (reader.Read()) //reader = leitor de informações do banco de dados 
                                      //Read = observador que passa de linha em linha
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                    };

                    var linha_listview = new ListViewItem(row);

                    list_Busca.Items.Add(linha_listview);
                }
                carregar_clientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            conexao = new MySqlConnection(data_source);

            conexao.Open();

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = conexao;

            try
            {
                //Inicia o update no Banco
                cmd.CommandText = "UPDATE clientes SET nome=@nome, telefone=@telefone, cpf=@cpf, cnh=@cnh "
                                    + "WHERE id=@id";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                cmd.Parameters.AddWithValue("@cnh", txtCNH.Text);
                cmd.Parameters.AddWithValue("@id", idClienteSelecionado);

                cmd.ExecuteNonQuery(); //retorna o número de linhas afetadas

                MessageBox.Show("Cliente Atualizado com sucesso", "Sucesso", MessageBoxButtons.OK);
                carregar_clientes();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                conexao.Close(); 
            }
            this.txtNome.Clear();
            this.txtCNH.Clear();
            this.txtCPF.Clear();
            this.txtTelefone.Clear();
        }


        private void excluir_cliente()
        {
            try
            {
                DialogResult conf = MessageBox.Show("Deseja excluir este registro?", "Ops, tem certeza?"
                                                       , MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (conf == DialogResult.Yes)
                {
                    conexao = new MySqlConnection(data_source);

                    conexao.Open();

                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = conexao;



                    cmd.CommandText = "DELETE FROM clientes WHERE id=@id ";

                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@id", idClienteSelecionado);

                    cmd.ExecuteNonQuery(); //retorna o número de linhas afetadas



                    MessageBox.Show("Cliente excluído com sucesso", "Sucesso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    carregar_clientes();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            excluir_cliente();
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluir_cliente();
            this.txtNome.Clear();
            this.txtCNH.Clear();
            this.txtCPF.Clear();
            this.txtTelefone.Clear();
            carregar_clientes();
        }

        private void carregar_clientes()
        {
            try
            {
                conexao = new MySqlConnection(data_source);

                conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conexao;

                //Inicia o insert no Banco
                cmd.CommandText = "SELECT * FROM clientes ORDER BY id DESC ";
                    
                cmd.Parameters.Clear();


                MySqlDataReader reader = cmd.ExecuteReader();

                list_Busca.Items.Clear();

                while (reader.Read()) //reader = leitor de informações do banco de dados 
                                      //Read = observador que passa de linha em linha
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                    };

                    var linha_listview = new ListViewItem(row);

                    list_Busca.Items.Add(linha_listview);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void veículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 veiculo = new Form2();
            veiculo.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aluguel aluguel = new Aluguel();
            aluguel.ShowDialog();
        }

        private void carrosAlugadosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CarrosAlugados aluguel = new CarrosAlugados();
            aluguel.ShowDialog();
        }

        private void btnCarroAlugado_Click(object sender, EventArgs e)
        {
            CarrosAlugados aluguel = new CarrosAlugados();
            aluguel.ShowDialog();
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.txtNome.Clear();
            this.txtCNH.Clear();
            this.txtCPF.Clear();
            this.txtTelefone.Clear();
        }

        private void aluguelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Aluguel aluguel = new Aluguel();
            aluguel.ShowDialog();
        }
    }

    }



