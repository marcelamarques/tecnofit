using System;
using System.IO.Ports;
using System.Windows.Forms;
using TesteTeconofit.WF.Forms;

namespace TesteTeconofit.WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Singleton singleton = Singleton.Instance;

            if (!serialPort1.DtrEnable)
            {
                serialPort1.DtrEnable = true;
                singleton.StateDTR = serialPort1.DtrEnable;
            }

            singleton.CountDataReceived++;
        }

        private void bt_SerialPort_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();
                MessageBox.Show("Porta Serial Conectada!");
            }
            catch (Exception)
            {
                MessageBox.Show("Cabo Desconectado!");
            }
        }

        private void bt_CalcRaio_Click(object sender, EventArgs e)
        {
            calculaRaio();
        }

        private void calculaRaio()
        {
            try
            {
                Double circuferencia = Double.Parse(tb_Circunferencia.Text);
                double raio = (circuferencia / (2 * Math.PI));
                MessageBox.Show("Raio = " + Convert.ToString(raio));
                tb_Circunferencia.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Informe uma número válido!");
            }
        }

        private void btn_CrudCliente_Click(object sender, EventArgs e)
        {
            ClienteCrud clienteCrud = new ClienteCrud();
            clienteCrud.Show();
        }
    }
}
