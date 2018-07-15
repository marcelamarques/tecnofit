namespace TesteTeconofit.WF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.bt_SerialPort = new System.Windows.Forms.Button();
            this.bt_CalcRaio = new System.Windows.Forms.Button();
            this.lb_Circunferencia = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Circunferencia = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Title = new System.Windows.Forms.Label();
            this.btn_CrudCliente = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 2400;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // bt_SerialPort
            // 
            this.bt_SerialPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_SerialPort.Location = new System.Drawing.Point(3, 3);
            this.bt_SerialPort.Name = "bt_SerialPort";
            this.tableLayoutPanel1.SetRowSpan(this.bt_SerialPort, 3);
            this.bt_SerialPort.Size = new System.Drawing.Size(391, 106);
            this.bt_SerialPort.TabIndex = 0;
            this.bt_SerialPort.Text = "Conecte-se a SerialPort";
            this.bt_SerialPort.UseVisualStyleBackColor = true;
            this.bt_SerialPort.Click += new System.EventHandler(this.bt_SerialPort_Click);
            // 
            // bt_CalcRaio
            // 
            this.bt_CalcRaio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_CalcRaio.Location = new System.Drawing.Point(400, 64);
            this.bt_CalcRaio.Name = "bt_CalcRaio";
            this.bt_CalcRaio.Size = new System.Drawing.Size(391, 45);
            this.bt_CalcRaio.TabIndex = 1;
            this.bt_CalcRaio.Text = "Calcula o Raio";
            this.bt_CalcRaio.UseVisualStyleBackColor = true;
            this.bt_CalcRaio.Click += new System.EventHandler(this.bt_CalcRaio_Click);
            // 
            // lb_Circunferencia
            // 
            this.lb_Circunferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Circunferencia.AutoSize = true;
            this.lb_Circunferencia.Location = new System.Drawing.Point(486, 9);
            this.lb_Circunferencia.Name = "lb_Circunferencia";
            this.lb_Circunferencia.Size = new System.Drawing.Size(219, 17);
            this.lb_Circunferencia.TabIndex = 2;
            this.lb_Circunferencia.Text = "Informe o Valor da Circunferência";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lb_Circunferencia, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_CalcRaio, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_SerialPort, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Circunferencia, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 222);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.39437F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.53521F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 112);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tb_Circunferencia
            // 
            this.tb_Circunferencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Circunferencia.Location = new System.Drawing.Point(400, 39);
            this.tb_Circunferencia.Name = "tb_Circunferencia";
            this.tb_Circunferencia.Size = new System.Drawing.Size(391, 22);
            this.tb_Circunferencia.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lb_Title, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_CrudCliente, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.38356F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.61644F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 376);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lb_Title
            // 
            this.lb_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Lucida Sans", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(208, 43);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(383, 55);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "Teste TecnoFit";
            // 
            // btn_CrudCliente
            // 
            this.btn_CrudCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_CrudCliente.Location = new System.Drawing.Point(3, 144);
            this.btn_CrudCliente.Name = "btn_CrudCliente";
            this.btn_CrudCliente.Size = new System.Drawing.Size(794, 72);
            this.btn_CrudCliente.TabIndex = 1;
            this.btn_CrudCliente.Text = "Open Crud Cliente";
            this.btn_CrudCliente.UseVisualStyleBackColor = true;
            this.btn_CrudCliente.Click += new System.EventHandler(this.btn_CrudCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button bt_SerialPort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_Circunferencia;
        private System.Windows.Forms.Button bt_CalcRaio;
        private System.Windows.Forms.TextBox tb_Circunferencia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Button btn_CrudCliente;
    }
}

