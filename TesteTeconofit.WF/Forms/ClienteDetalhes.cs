using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TesteTecnofit.Data.Repositories;
using TesteTecnofit.Domain;

namespace TesteTeconofit.WF.Forms
{
    public partial class ClienteDetalhes : Form
    {
        Cliente cliente;
        public ClienteDetalhes(Cliente cli, bool remove = false)
        {
            cliente = cli;
            InitializeComponent();
            preencheCampos();
            bt_Remove.Visible = remove;

        }

        private void preencheCampos()
        {
            lb_NameText.Text = cliente.Nome;
            lb_SobrenomeText.Text = cliente.Sobrenome;
            lb_EmailText.Text = cliente.Email;
            if (cliente.Ativo)
            {
                lb_AtivoText.Text = "Sim";
            }
            else
            {
                lb_AtivoText.Text = "Não";
            }
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            ClienteRepository Db = new ClienteRepository();
            Db.Remove(cliente);
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
