using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace P2
{
    public partial class Form2 : Form
    {
        private MySqlConnection conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=test";

        private int? idCarroSelecionado = null; //quando o '?' fica antes da variavel int ela vira um tipo anulavel


        public Form2()
        {

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            carregar_carros();


            listCarrosCadastrados.View = View.Details;
            listCarrosCadastrados.LabelEdit = false;
            listCarrosCadastrados.AllowColumnReorder = true;
            listCarrosCadastrados.FullRowSelect = true;
            listCarrosCadastrados.GridLines = true;

            listCarrosCadastrados.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listCarrosCadastrados.Columns.Add("Marca", 150, HorizontalAlignment.Left);
            listCarrosCadastrados.Columns.Add("Modelo", 150, HorizontalAlignment.Left);
            listCarrosCadastrados.Columns.Add("Ano", 150, HorizontalAlignment.Left);
            listCarrosCadastrados.Columns.Add("N° Portas", 150, HorizontalAlignment.Left);
            listCarrosCadastrados.Columns.Add("Preço/Dia", 150, HorizontalAlignment.Left);
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            // Verificar se algum campo está vazio
            if (string.IsNullOrEmpty(txtMarca.Text) || string.IsNullOrEmpty(txtModelo.Text) ||
                string.IsNullOrEmpty(txtAno.Text) || string.IsNullOrEmpty(txtNDP.Text) || string.IsNullOrEmpty(txtPPD.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Encerrar a execução do método
            }
            try
            {
                conexao = new MySqlConnection(data_source);

                conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conexao;

                //Inicia o insert no Banco
                cmd.CommandText = "INSERT INTO carros (marca, modelo, ano, numero_portas, preco_por_dia) " +
                    "VALUES " +
                    "(@marca, @modelo, @ano, @numero_portas, @preco_por_dia) ";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                cmd.Parameters.AddWithValue("@modelo", txtModelo.Text);
                cmd.Parameters.AddWithValue("@ano", txtAno.Text);
                cmd.Parameters.AddWithValue("@numero_portas", txtNDP.Text);
                cmd.Parameters.AddWithValue("@preco_por_dia", txtPPD.Text);

                cmd.ExecuteNonQuery(); //retorna o número de linhas afetadas

                carregar_carros();
                reset_carros();

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
        }
        private void listCarrosCadastrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = listCarrosCadastrados.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {


                idCarroSelecionado = Convert.ToInt32(item.SubItems[0].Text);

                txtMarca.Text = item.SubItems[1].Text;
                txtModelo.Text = item.SubItems[2].Text;
                txtAno.Text = item.SubItems[3].Text;
                txtNDP.Text = item.SubItems[4].Text;
                txtPPD.Text = item.SubItems[5].Text;

            }
        }

        private void reset_carros()
        {
            this.txtMarca.Clear();
            this.txtNDP.Clear();
            this.txtAno.Clear();
            this.txtModelo.Clear();
            this.txtPPD.Clear();
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
                cmd.CommandText = "SELECT * FROM carros ORDER BY id DESC ";

                cmd.Parameters.Clear();


                MySqlDataReader reader = cmd.ExecuteReader();

                listCarrosCadastrados.Items.Clear();

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
                        reader.GetString(5),
                    };

                    var linha_listview = new ListViewItem(row);

                    listCarrosCadastrados.Items.Add(linha_listview);
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

        private void button2_Click(object sender, EventArgs e)
        {
            conexao = new MySqlConnection(data_source);

            conexao.Open();

            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = conexao;

            try
            {
                //Inicia o update no Banco
                cmd.CommandText = "UPDATE carros SET marca=@marca, modelo=@modelo, ano=@ano, numero_portas=@numero_portas, preco_por_dia=@preco_por_dia "
                                    + "WHERE id=@id";

                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                cmd.Parameters.AddWithValue("@modelo", txtModelo.Text);
                cmd.Parameters.AddWithValue("@ano", txtAno.Text);
                cmd.Parameters.AddWithValue("@numero_portas", txtNDP.Text);
                cmd.Parameters.AddWithValue("@preco_por_dia", txtPPD.Text);
                cmd.Parameters.AddWithValue("@id", idCarroSelecionado);

                cmd.ExecuteNonQuery(); //retorna o número de linhas afetadas

                MessageBox.Show("Carro Atualizado com sucesso", "Sucesso", MessageBoxButtons.OK);
                carregar_carros();
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

        private void btnBuscarCarro_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "'%" + txtBuscarCarro.Text + "%'";

                conexao = new MySqlConnection(data_source);

                string sql = "SELECT * " +
                    "FROM carros " +
                    "WHERE marca LIKE " + q  + "OR modelo LIKE" + q ;

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);


                MySqlDataReader reader = comando.ExecuteReader();

                listCarrosCadastrados.Items.Clear();

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
                        reader.GetString(5),
                    };

                    var linha_listview = new ListViewItem(row);

                    listCarrosCadastrados.Items.Add(linha_listview);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
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



                    cmd.CommandText = "DELETE FROM carros WHERE id=@id ";

                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@id", idCarroSelecionado);

                    cmd.ExecuteNonQuery(); //retorna o número de linhas afetadas



                    MessageBox.Show("Carro excluído com sucesso", "Sucesso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    carregar_carros();
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


        private void veículoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 veiculo = new Form2();
            veiculo.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 cliente = new Form1();
            cliente.ShowDialog();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void carrosAlugadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarrosAlugados aluguel = new CarrosAlugados();
            aluguel.ShowDialog();
        }



        private void aluguelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Aluguel aluguel = new Aluguel();
            aluguel.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset_carros();
        }

       
    }
}
