namespace TesteTeconofit.WF
{
    partial class SingletonForm
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
            this.lb_Singleton = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_StateDtr = new System.Windows.Forms.Label();
            this.lb_StateDtrValue = new System.Windows.Forms.Label();
            this.lb_CountDataReceived = new System.Windows.Forms.Label();
            this.lb_CountDataReceivedValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lb_Singleton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 192);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lb_Singleton
            // 
            this.lb_Singleton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Singleton.AutoSize = true;
            this.lb_Singleton.Font = new System.Drawing.Font("Lucida Sans", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Singleton.Location = new System.Drawing.Point(273, 9);
            this.lb_Singleton.Name = "lb_Singleton";
            this.lb_Singleton.Size = new System.Drawing.Size(253, 55);
            this.lb_Singleton.TabIndex = 0;
            this.lb_Singleton.Text = "Singleton";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5063F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.49371F));
            this.tableLayoutPanel2.Controls.Add(this.lb_StateDtr, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_StateDtrValue, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_CountDataReceived, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_CountDataReceivedValue, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 77);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 112);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lb_StateDtr
            // 
            this.lb_StateDtr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_StateDtr.AutoSize = true;
            this.lb_StateDtr.Location = new System.Drawing.Point(3, 19);
            this.lb_StateDtr.Name = "lb_StateDtr";
            this.lb_StateDtr.Size = new System.Drawing.Size(78, 17);
            this.lb_StateDtr.TabIndex = 0;
            this.lb_StateDtr.Text = "State DTR:";
            // 
            // lb_StateDtrValue
            // 
            this.lb_StateDtrValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_StateDtrValue.AutoSize = true;
            this.lb_StateDtrValue.Location = new System.Drawing.Point(142, 19);
            this.lb_StateDtrValue.Name = "lb_StateDtrValue";
            this.lb_StateDtrValue.Size = new System.Drawing.Size(0, 17);
            this.lb_StateDtrValue.TabIndex = 1;
            // 
            // lb_CountDataReceived
            // 
            this.lb_CountDataReceived.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_CountDataReceived.AutoSize = true;
            this.lb_CountDataReceived.Location = new System.Drawing.Point(3, 75);
            this.lb_CountDataReceived.Name = "lb_CountDataReceived";
            this.lb_CountDataReceived.Size = new System.Drawing.Size(101, 17);
            this.lb_CountDataReceived.TabIndex = 2;
            this.lb_CountDataReceived.Text = "DataReceived:";
            // 
            // lb_CountDataReceivedValue
            // 
            this.lb_CountDataReceivedValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_CountDataReceivedValue.AutoSize = true;
            this.lb_CountDataReceivedValue.Location = new System.Drawing.Point(142, 75);
            this.lb_CountDataReceivedValue.Name = "lb_CountDataReceivedValue";
            this.lb_CountDataReceivedValue.Size = new System.Drawing.Size(0, 17);
            this.lb_CountDataReceivedValue.TabIndex = 3;
            // 
            // SingletonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 192);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SingletonForm";
            this.Text = "SingletonForm";
            this.Load += new System.EventHandler(this.SingletonForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_Singleton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lb_StateDtr;
        private System.Windows.Forms.Label lb_StateDtrValue;
        private System.Windows.Forms.Label lb_CountDataReceived;
        private System.Windows.Forms.Label lb_CountDataReceivedValue;
    }
}