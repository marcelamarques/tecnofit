namespace TesteTeconofit.WF.Forms
{
    partial class ClienteCrud
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btm_Inserir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.la_Ativo = new System.Windows.Forms.Label();
            this.cb_Ativo = new System.Windows.Forms.CheckBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Sobrenome = new System.Windows.Forms.TextBox();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Sobrenome = new System.Windows.Forms.Label();
            this.lb_Nome = new System.Windows.Forms.Label();
            this.lb_ClienteId = new System.Windows.Forms.Label();
            this.tb_ClienteId = new System.Windows.Forms.TextBox();
            this.dg_Cliente = new System.Windows.Forms.DataGridView();
            this.btn_Singleton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btm_Inserir, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_Editar, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_Buscar, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_Remover, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.la_Ativo, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cb_Ativo, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_Email, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_Sobrenome, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Nome, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_Sobrenome, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Nome, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_ClienteId, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_ClienteId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dg_Cliente, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btn_Singleton, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.38655F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.61345F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 535);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
            this.label1.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grud Cliente";
            // 
            // btm_Inserir
            // 
            this.btm_Inserir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btm_Inserir.Location = new System.Drawing.Point(3, 295);
            this.btm_Inserir.Name = "btm_Inserir";
            this.btm_Inserir.Size = new System.Drawing.Size(194, 22);
            this.btm_Inserir.TabIndex = 2;
            this.btm_Inserir.Text = "Inserir";
            this.btm_Inserir.UseVisualStyleBackColor = true;
            this.btm_Inserir.Click += new System.EventHandler(this.btm_Inserir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Editar.Location = new System.Drawing.Point(203, 295);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(194, 22);
            this.btn_Editar.TabIndex = 3;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Buscar.Location = new System.Drawing.Point(403, 295);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(194, 22);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Remover.Location = new System.Drawing.Point(603, 295);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(194, 22);
            this.btn_Remover.TabIndex = 5;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // la_Ativo
            // 
            this.la_Ativo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.la_Ativo.AutoSize = true;
            this.la_Ativo.Location = new System.Drawing.Point(3, 254);
            this.la_Ativo.Name = "la_Ativo";
            this.la_Ativo.Size = new System.Drawing.Size(194, 17);
            this.la_Ativo.TabIndex = 10;
            this.la_Ativo.Text = "Ativo:";
            // 
            // cb_Ativo
            // 
            this.cb_Ativo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Ativo.AutoSize = true;
            this.cb_Ativo.Location = new System.Drawing.Point(203, 254);
            this.cb_Ativo.Name = "cb_Ativo";
            this.cb_Ativo.Size = new System.Drawing.Size(194, 17);
            this.cb_Ativo.TabIndex = 13;
            this.cb_Ativo.UseVisualStyleBackColor = true;
            this.cb_Ativo.CheckedChanged += new System.EventHandler(this.cb_Ativo_CheckedChanged);
            // 
            // tb_Email
            // 
            this.tb_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tb_Email, 3);
            this.tb_Email.Location = new System.Drawing.Point(203, 211);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(594, 22);
            this.tb_Email.TabIndex = 12;
            // 
            // tb_Sobrenome
            // 
            this.tb_Sobrenome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tb_Sobrenome, 3);
            this.tb_Sobrenome.Location = new System.Drawing.Point(203, 169);
            this.tb_Sobrenome.Name = "tb_Sobrenome";
            this.tb_Sobrenome.Size = new System.Drawing.Size(594, 22);
            this.tb_Sobrenome.TabIndex = 11;
            // 
            // tb_Nome
            // 
            this.tb_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tb_Nome, 3);
            this.tb_Nome.Location = new System.Drawing.Point(203, 129);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(594, 22);
            this.tb_Nome.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "E-mail:";
            // 
            // lb_Sobrenome
            // 
            this.lb_Sobrenome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Sobrenome.AutoSize = true;
            this.lb_Sobrenome.Location = new System.Drawing.Point(3, 171);
            this.lb_Sobrenome.Name = "lb_Sobrenome";
            this.lb_Sobrenome.Size = new System.Drawing.Size(194, 17);
            this.lb_Sobrenome.TabIndex = 8;
            this.lb_Sobrenome.Text = "Sobrenome:";
            // 
            // lb_Nome
            // 
            this.lb_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Location = new System.Drawing.Point(3, 131);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(194, 17);
            this.lb_Nome.TabIndex = 6;
            this.lb_Nome.Text = "Nome:";
            // 
            // lb_ClienteId
            // 
            this.lb_ClienteId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ClienteId.AutoSize = true;
            this.lb_ClienteId.Location = new System.Drawing.Point(3, 90);
            this.lb_ClienteId.Name = "lb_ClienteId";
            this.lb_ClienteId.Size = new System.Drawing.Size(194, 17);
            this.lb_ClienteId.TabIndex = 14;
            this.lb_ClienteId.Text = "Cliente Id:";
            // 
            // tb_ClienteId
            // 
            this.tb_ClienteId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tb_ClienteId, 3);
            this.tb_ClienteId.Location = new System.Drawing.Point(203, 88);
            this.tb_ClienteId.Name = "tb_ClienteId";
            this.tb_ClienteId.Size = new System.Drawing.Size(594, 22);
            this.tb_ClienteId.TabIndex = 15;
            // 
            // dg_Cliente
            // 
            this.dg_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dg_Cliente, 4);
            this.dg_Cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Cliente.Location = new System.Drawing.Point(3, 323);
            this.dg_Cliente.Name = "dg_Cliente";
            this.dg_Cliente.RowTemplate.Height = 24;
            this.dg_Cliente.Size = new System.Drawing.Size(794, 209);
            this.dg_Cliente.TabIndex = 16;
            // 
            // btn_Singleton
            // 
            this.btn_Singleton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Singleton.Location = new System.Drawing.Point(403, 249);
            this.btn_Singleton.Name = "btn_Singleton";
            this.btn_Singleton.Size = new System.Drawing.Size(194, 27);
            this.btn_Singleton.TabIndex = 17;
            this.btn_Singleton.Text = "Singleton";
            this.btn_Singleton.UseVisualStyleBackColor = true;
            this.btn_Singleton.Click += new System.EventHandler(this.btn_Singleton_Click);
            // 
            // ClienteCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ClienteCrud";
            this.Text = "ClienteCrud";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Cliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btm_Inserir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label lb_Sobrenome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label la_Ativo;
        private System.Windows.Forms.TextBox tb_Sobrenome;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.CheckBox cb_Ativo;
        private System.Windows.Forms.Label lb_ClienteId;
        private System.Windows.Forms.TextBox tb_ClienteId;
        private System.Windows.Forms.DataGridView dg_Cliente;
        private System.Windows.Forms.Button btn_Singleton;
    }
}