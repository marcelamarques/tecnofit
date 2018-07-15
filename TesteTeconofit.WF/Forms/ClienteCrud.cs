using System;
using System.Windows.Forms;
using TesteTecnofit.Data.Repositories;
using TesteTecnofit.Domain;

namespace TesteTeconofit.WF.Forms
{
    public partial class ClienteCrud : Form
    {
        public ClienteCrud()
        {
            InitializeComponent();
            preencheGrid();
        }

        private void preencheGrid()
        {
            ClienteRepository repository = new ClienteRepository();

            dg_Cliente.DataSource = repository.GetAll();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btm_Inserir_Click(object sender, EventArgs e)
        {
            if (ValidaNome() && ValidaSobrenome() && ValidaEmail())
            {
                addCliente();
            }
            else
            {
                MessageBox.Show("Campos inválidos!!!");
            }
        }

        private void addCliente()
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Nome = tb_Nome.Text;
                cliente.Sobrenome = tb_Sobrenome.Text;
                cliente.Email = tb_Email.Text;
                cliente.Ativo = cb_Ativo.Checked;

                ClienteRepository clienteRepository = new ClienteRepository();
                clienteRepository.Add(cliente);
                preencheGrid();

                MessageBox.Show("Cliente " + cliente.Nome + " adicionado com sucesso!!!");

            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível adicionar o cliente: " + tb_Nome.Text + ".");
            }
        }

        private bool ValidaId()
        {
            if (string.IsNullOrEmpty(tb_ClienteId.Text))
            {
                try
                {
                    Convert.ToInt32(tb_ClienteId.Text);
                }
                catch (Exception)
                {
                    return false;            
                }
                return true;
            }

            return false;
        }

        private bool ValidaNome()
        {
            if (string.IsNullOrEmpty(tb_Nome.Text))
            {
                return false;
            }
            return true;
        }

        private bool ValidaSobrenome()
        {
            if (string.IsNullOrEmpty(tb_Sobrenome.Text))
            {
                return false;
            }
            return true;
        }

        private bool ValidaEmail()
        {
            if (string.IsNullOrEmpty(tb_Email.Text))
            {
                return false;
            }
            return true;
        }

        private void cb_Ativo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            UpdageCliente();
        }

        private void UpdageCliente()
        {
            ClienteRepository clienteRepository = new ClienteRepository();

            Cliente cliente = null;
            try
            {
                cliente = clienteRepository.GetById(Convert.ToInt32(tb_ClienteId));
            }
            catch (Exception)
            {
                MessageBox.Show("Campo Cliente Id inválido!!!");
                return;
            }

            if (cliente != null && ValidaNome() && ValidaSobrenome() && ValidaEmail())
            {
                cliente.Nome = tb_Nome.Text;
                cliente.Sobrenome = tb_Sobrenome.Text;
                cliente.Email = tb_Email.Text;
                cliente.Ativo = cb_Ativo.Checked;

                clienteRepository.Update(cliente);
                preencheGrid();

                MessageBox.Show("Cliente " + cliente.Nome + " foi alterado com sucesso!!!");
            }
            else
            {
                MessageBox.Show("Não foi possível realizar a edição desejada!!!");
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            buscaClienteId();
        }

        private void buscaClienteId(bool rem = false)
        {
            if (ValidaId())
            {
                Cliente cliente = retornaCliente();

                ClienteDetalhes clienteDetalhes = new ClienteDetalhes(cliente, rem);
                clienteDetalhes.Show();

            }
            else
            {
                MessageBox.Show("Não foi possível localizar o cliente!");
            }
        }


        private Cliente retornaCliente()
        {
            ClienteRepository repository = new ClienteRepository();
            Cliente cliente = repository.GetById(Convert.ToInt32(lb_ClienteId.Text));
            return cliente;
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            buscaClienteId(true);
            preencheGrid();

        }

        private void btn_Singleton_Click(object sender, EventArgs e)
        {
            openSingleton();
        }

        private static void openSingleton()
        {
            SingletonForm singletonForm = new SingletonForm();
            singletonForm.ShowDialog();
        }
    }
}
