namespace TesteTeconofit.WF.Forms
{
    partial class ClienteDetalhes
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
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.lb_NameLabel = new System.Windows.Forms.Label();
            this.lb_SobrenomeLabel = new System.Windows.Forms.Label();
            this.lb_EmaiLabel = new System.Windows.Forms.Label();
            this.lb_AtivoLabel = new System.Windows.Forms.Label();
            this.lb_NameText = new System.Windows.Forms.Label();
            this.lb_SobrenomeText = new System.Windows.Forms.Label();
            this.lb_EmailText = new System.Windows.Forms.Label();
            this.lb_AtivoText = new System.Windows.Forms.Label();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.btn_Singleton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lb_Titulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_NameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_SobrenomeLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_EmaiLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_AtivoLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_NameText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_SobrenomeText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_EmailText, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_AtivoText, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.bt_Remove, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_Singleton, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Titulo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lb_Titulo, 4);
            this.lb_Titulo.Font = new System.Drawing.Font("Lucida Sans", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.Location = new System.Drawing.Point(3, 47);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(794, 55);
            this.lb_Titulo.TabIndex = 0;
            this.lb_Titulo.Text = "Detalhes do Cliente";
            this.lb_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_NameLabel
            // 
            this.lb_NameLabel.AutoSize = true;
            this.lb_NameLabel.Location = new System.Drawing.Point(3, 149);
            this.lb_NameLabel.Name = "lb_NameLabel";
            this.lb_NameLabel.Size = new System.Drawing.Size(49, 17);
            this.lb_NameLabel.TabIndex = 1;
            this.lb_NameLabel.Text = "Nome:";
            // 
            // lb_SobrenomeLabel
            // 
            this.lb_SobrenomeLabel.AutoSize = true;
            this.lb_SobrenomeLabel.Location = new System.Drawing.Point(3, 224);
            this.lb_SobrenomeLabel.Name = "lb_SobrenomeLabel";
            this.lb_SobrenomeLabel.Size = new System.Drawing.Size(85, 17);
            this.lb_SobrenomeLabel.TabIndex = 2;
            this.lb_SobrenomeLabel.Text = "Sobrenome:";
            // 
            // lb_EmaiLabel
            // 
            this.lb_EmaiLabel.AutoSize = true;
            this.lb_EmaiLabel.Location = new System.Drawing.Point(3, 299);
            this.lb_EmaiLabel.Name = "lb_EmaiLabel";
            this.lb_EmaiLabel.Size = new System.Drawing.Size(46, 17);
            this.lb_EmaiLabel.TabIndex = 3;
            this.lb_EmaiLabel.Text = "Email:";
            // 
            // lb_AtivoLabel
            // 
            this.lb_AtivoLabel.AutoSize = true;
            this.lb_AtivoLabel.Location = new System.Drawing.Point(3, 374);
            this.lb_AtivoLabel.Name = "lb_AtivoLabel";
            this.lb_AtivoLabel.Size = new System.Drawing.Size(43, 17);
            this.lb_AtivoLabel.TabIndex = 4;
            this.lb_AtivoLabel.Text = "Ativo:";
            // 
            // lb_NameText
            // 
            this.lb_NameText.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lb_NameText, 3);
            this.lb_NameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_NameText.Location = new System.Drawing.Point(203, 149);
            this.lb_NameText.Name = "lb_NameText";
            this.lb_NameText.Size = new System.Drawing.Size(594, 75);
            this.lb_NameText.TabIndex = 5;
            // 
            // lb_SobrenomeText
            // 
            this.lb_SobrenomeText.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lb_SobrenomeText, 3);
            this.lb_SobrenomeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_SobrenomeText.Location = new System.Drawing.Point(203, 224);
            this.lb_SobrenomeText.Name = "lb_SobrenomeText";
            this.lb_SobrenomeText.Size = new System.Drawing.Size(594, 75);
            this.lb_SobrenomeText.TabIndex = 6;
            // 
            // lb_EmailText
            // 
            this.lb_EmailText.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lb_EmailText, 3);
            this.lb_EmailText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_EmailText.Location = new System.Drawing.Point(203, 299);
            this.lb_EmailText.Name = "lb_EmailText";
            this.lb_EmailText.Size = new System.Drawing.Size(594, 75);
            this.lb_EmailText.TabIndex = 7;
            // 
            // lb_AtivoText
            // 
            this.lb_AtivoText.AutoSize = true;
            this.lb_AtivoText.Location = new System.Drawing.Point(203, 374);
            this.lb_AtivoText.Name = "lb_AtivoText";
            this.lb_AtivoText.Size = new System.Drawing.Size(0, 17);
            this.lb_AtivoText.TabIndex = 8;
            // 
            // bt_Remove
            // 
            this.bt_Remove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_Remove.Location = new System.Drawing.Point(603, 424);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(194, 23);
            this.bt_Remove.TabIndex = 9;
            this.bt_Remove.Text = "Remove";
            this.bt_Remove.UseVisualStyleBackColor = true;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // btn_Singleton
            // 
            this.btn_Singleton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Singleton.Location = new System.Drawing.Point(403, 424);
            this.btn_Singleton.Name = "btn_Singleton";
            this.btn_Singleton.Size = new System.Drawing.Size(194, 23);
            this.btn_Singleton.TabIndex = 10;
            this.btn_Singleton.Text = "Singleton";
            this.btn_Singleton.UseVisualStyleBackColor = true;
            this.btn_Singleton.Click += new System.EventHandler(this.btn_Singleton_Click);
            // 
            // ClienteDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ClienteDetalhes";
            this.Text = "ClienteDetalhes";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.Label lb_NameLabel;
        private System.Windows.Forms.Label lb_SobrenomeLabel;
        private System.Windows.Forms.Label lb_EmaiLabel;
        private System.Windows.Forms.Label lb_AtivoLabel;
        private System.Windows.Forms.Label lb_NameText;
        private System.Windows.Forms.Label lb_SobrenomeText;
        private System.Windows.Forms.Label lb_EmailText;
        private System.Windows.Forms.Label lb_AtivoText;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.Button btn_Singleton;
    }
}