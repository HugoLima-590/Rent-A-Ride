using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using static P2.CarrosAlugados;

namespace P2
{

    public partial class Aluguel : Form
    {
        private MySqlConnection conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=test";

        private int ?idClienteSelecionado = null;
        private int ?idCarroSelecionado = null;

        public string CarroAlugado { get; private set; }
        public string NomePessoa { get; private set; }
        public string CNHPessoa { get; private set; }
        public string Total { get; private set; }


        public Aluguel()
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            carregar_clientes();
            carregar_carros();

            listView1.View = View.Details;
            listView1.LabelEdit = false;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listView1.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("CNH", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Telefone", 100, HorizontalAlignment.Left);

            listView2.View = View.Details;
            listView2.LabelEdit = false;
            listView2.AllowColumnReorder = true;
            listView2.FullRowSelect = true;
            listView2.GridLines = true;

            listView2.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listView2.Columns.Add("Marca", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("Modelo", 100, HorizontalAlignment.Left);
            listView2.Columns.Add("Preço/Dia", 100, HorizontalAlignment.Left);
        }

        private void Aluguel_Load(object sender, EventArgs e)
        {
        }

        private void buscarCarroModelo_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "'%" + txtBuscarModelo.Text + "%'";

                conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                    "FROM carros " +
                    "WHERE modelo LIKE " + q;

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);


                MySqlDataReader reader = comando.ExecuteReader();

                listView2.Items.Clear();

                while (reader.Read()) //reader = leitor de informações do banco de dados 
                                      //Read = observador que passa de linha em linha
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(5),
                    };

                    var linha_listview = new ListViewItem(row);

                    listView2.Items.Add(linha_listview);
                }
            }catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
          }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "'%" + txtBuscarCliente.Text + "%'";

                conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                    "FROM clientes " +
                    "WHERE nome LIKE " + q + "OR cnh LIKE " + q;

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);


                MySqlDataReader reader = comando.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read()) //reader = leitor de informações do banco de dados 
                                      //Read = observador que passa de linha em linha
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(4),
                        reader.GetString(2),
                    };

                    var linha_listview = new ListViewItem(row);

                    listView1.Items.Add(linha_listview);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void carregar_clientes() //atualizar a lista
        {
            try
            {
                conexao = new MySqlConnection(data_source);

                conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conexao;

                //Inicia o insert no Banco
                cmd.CommandText = "SELECT * FROM clientes";

                cmd.Parameters.Clear();


                MySqlDataReader reader = cmd.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read()) //reader = leitor de informações do banco de dados 
                                      //Read = observador que passa de linha em linha
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(4),
                        reader.GetString(2),
                    };

                    var linha_listview = new ListViewItem(row);

                    listView1.Items.Add(linha_listview);
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

        private void carregar_carros()
        {
            try
            {
                conexao = new MySqlConnection(data_source);

                conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conexao;

                //Inicia o insert no Banco
                cmd.CommandText = "SELECT * FROM carros";

                cmd.Parameters.Clear();


                MySqlDataReader reader = cmd.ExecuteReader();

                listView2.Items.Clear();

                while (reader.Read()) //reader = leitor de informações do banco de dados 
                                      //Read = observador que passa de linha em linha
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(5),
                    };

                    var linha_listview = new ListViewItem(row);

                    listView2.Items.Add(linha_listview);
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

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = listView1.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {


                idClienteSelecionado = Convert.ToInt32(item.SubItems[0].Text);

                txtClienteSelecionado.Text = item.SubItems[1].Text;
                txtCNH.Text = item.SubItems[2].Text;


            }
        }


        private void listView2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = listView2.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {

                idCarroSelecionado = Convert.ToInt32(item.SubItems[0].Text);

                txtPrecoPorDia.Text = item.SubItems[3].Text;
                txtModeloCarro.Text = item.SubItems[1].Text;

            }
        }

        private void btnCalc_por_dia_Click(object sender, EventArgs e)
        {
            
            DateTime dataInicio = dataRetirada.Value;
            DateTime dataTermino = dataDevolução.Value;

            decimal precoPorDia;
            if (!decimal.TryParse(txtPrecoPorDia.Text, out precoPorDia))
            {
                MessageBox.Show("Preço por dia inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TimeSpan duracaoAluguel = dataTermino - dataInicio;
            int diasAluguel = (int)duracaoAluguel.TotalDays;

            decimal precoTotal = diasAluguel * precoPorDia;

            
            txtTotal.Text = precoTotal.ToString("0.00");
        }

        private void btnAlugarCarro_Click(object sender, EventArgs e)
        {
            string nomePessoa = txtClienteSelecionado.Text;
            string cnhPessoa = txtCNH.Text;
            string carroAlugado = txtModeloCarro.Text;
            string total = txtTotal.Text;

            // Criar um objeto contendo as informações do carro alugado e o nome da pessoa
            AluguelCarro aluguel = new AluguelCarro
            {
                CarroAlugado = carroAlugado,
                NomePessoa = nomePessoa,
                CNHPessoa = cnhPessoa,
                Total = total
            };
            CarrosAlugados formCarrosAlugados = new CarrosAlugados();
            formCarrosAlugados.ReceberAluguel(aluguel);

            try
            {
                // Criar uma conexão com o banco de dados
                MySqlConnection conexao = new MySqlConnection(data_source);
                conexao.Open();

                // Criar uma declaração SQL INSERT
                string query = "INSERT INTO alugueis (carro, nome, cnh, total) VALUES (@carro, @nome, @cnh, @total)";

                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@carro", aluguel.CarroAlugado);
                cmd.Parameters.AddWithValue("@nome", aluguel.NomePessoa);
                cmd.Parameters.AddWithValue("@cnh", aluguel.CNHPessoa);
                cmd.Parameters.AddWithValue("@total", aluguel.Total);

                // Executar o comando INSERT
                cmd.ExecuteNonQuery();

                // Fechar a conexão com o banco de dados
                conexao.Close();

                MessageBox.Show("Aluguel salvo com sucesso!", "Sucesso", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o aluguel: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 cliente = new Form1();
            cliente.ShowDialog();
        }

        private void veículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 veiculo = new Form2();
            veiculo.ShowDialog();
        }

        private void aluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aluguel aluguel = new Aluguel();
            aluguel.ShowDialog();
        }

        private void carrosAlugadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarrosAlugados aluguel = new CarrosAlugados();
            aluguel.ShowDialog();
        }
    }
}
