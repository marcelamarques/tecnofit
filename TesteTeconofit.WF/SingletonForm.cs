using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TesteTeconofit.WF
{
    public partial class SingletonForm : Form
    {
        public SingletonForm()
        {
            InitializeComponent();
        }

        private void SingletonForm_Load(object sender, EventArgs e)
        {
            preencheForm();
        }

        private void preencheForm()
        {
            Singleton singleton = Singleton.Instance;
            if (singleton.StateDTR)
            {
                lb_StateDtrValue.Text = "Verdadeiro";
            }
            else
            {
                lb_StateDtrValue.Text = "Falso";
            }

            lb_StateDtrValue.Text = Convert.ToString(singleton.CountDataReceived);
        }
    }
}
