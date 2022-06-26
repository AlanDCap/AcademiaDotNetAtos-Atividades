namespace desafio_RegistroVendasComBD
{
    partial class Inicio
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
            this.tb_registrarCliente = new System.Windows.Forms.Button();
            this.bt_registrarProduto = new System.Windows.Forms.Button();
            this.bt_registrarVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_registrarCliente
            // 
            this.tb_registrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_registrarCliente.Location = new System.Drawing.Point(33, 36);
            this.tb_registrarCliente.Name = "tb_registrarCliente";
            this.tb_registrarCliente.Size = new System.Drawing.Size(106, 63);
            this.tb_registrarCliente.TabIndex = 0;
            this.tb_registrarCliente.Text = "Registrar Cliente";
            this.tb_registrarCliente.UseVisualStyleBackColor = true;
            this.tb_registrarCliente.Click += new System.EventHandler(this.tb_registrarCliente_Click);
            // 
            // bt_registrarProduto
            // 
            this.bt_registrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_registrarProduto.Location = new System.Drawing.Point(145, 36);
            this.bt_registrarProduto.Name = "bt_registrarProduto";
            this.bt_registrarProduto.Size = new System.Drawing.Size(106, 63);
            this.bt_registrarProduto.TabIndex = 1;
            this.bt_registrarProduto.Text = "Registrar Produto";
            this.bt_registrarProduto.UseVisualStyleBackColor = true;
            this.bt_registrarProduto.Click += new System.EventHandler(this.bt_registrarProduto_Click);
            // 
            // bt_registrarVenda
            // 
            this.bt_registrarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_registrarVenda.Location = new System.Drawing.Point(257, 36);
            this.bt_registrarVenda.Name = "bt_registrarVenda";
            this.bt_registrarVenda.Size = new System.Drawing.Size(106, 63);
            this.bt_registrarVenda.TabIndex = 2;
            this.bt_registrarVenda.Text = "Registrar Venda";
            this.bt_registrarVenda.UseVisualStyleBackColor = true;
            this.bt_registrarVenda.Click += new System.EventHandler(this.bt_registrarVenda_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 136);
            this.Controls.Add(this.bt_registrarVenda);
            this.Controls.Add(this.bt_registrarProduto);
            this.Controls.Add(this.tb_registrarCliente);
            this.Name = "Inicio";
            this.Text = "Controle de Vendas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tb_registrarCliente;
        private System.Windows.Forms.Button bt_registrarProduto;
        private System.Windows.Forms.Button bt_registrarVenda;
    }
}

