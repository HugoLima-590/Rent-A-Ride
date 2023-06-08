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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P2
{
    public partial class CarrosAlugados : Form
    {
        private MySqlConnection conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=test";
        public CarrosAlugados()
        {
            InitializeComponent();
            carregar_aluguel();

            listViewCarrosAlugados.View = View.Details;
            listViewCarrosAlugados.LabelEdit = false;
            listViewCarrosAlugados.AllowColumnReorder = true;
            listViewCarrosAlugados.FullRowSelect = true;
            listViewCarrosAlugados.GridLines = true;

            listViewCarrosAlugados.Columns.Add("ID", 30, HorizontalAlignment.Left);
            listViewCarrosAlugados.Columns.Add("Carro Alugado", 100, HorizontalAlignment.Left);
            listViewCarrosAlugados.Columns.Add("Nome Pessoa", 100, HorizontalAlignment.Left);
            listViewCarrosAlugados.Columns.Add("CNH", 100, HorizontalAlignment.Left);
            listViewCarrosAlugados.Columns.Add("Total", 100, HorizontalAlignment.Left);
        }

        public class AluguelCarro
        {
            public string CarroAlugado { get; set; }
            public string NomePessoa { get; set; }
            public string CNHPessoa { get; set; }
            public string Total { get;  set; }
        }

        public void ReceberAluguel(AluguelCarro aluguel)
        {
            // Criar um ListViewItem com as informações do aluguel
            ListViewItem item = new ListViewItem(aluguel.CarroAlugado);
            item.SubItems.Add(aluguel.NomePessoa);
            item.SubItems.Add(aluguel.CNHPessoa);

            // Adicionar o item à ListView
            listViewCarrosAlugados.Items.Add(item);

           
        }

        public void carregar_aluguel()
        {
            try
            {
                conexao = new MySqlConnection(data_source);

                conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = conexao;

                //Inicia o insert no Banco
                cmd.CommandText = "SELECT * FROM alugueis";

                cmd.Parameters.Clear();


                MySqlDataReader reader = cmd.ExecuteReader();

                listViewCarrosAlugados.Items.Clear();

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

                    listViewCarrosAlugados.Items.Add(linha_listview);
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
