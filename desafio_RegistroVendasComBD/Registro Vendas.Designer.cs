namespace desafio_RegistroVendasComBD
{
    partial class RegistroVendas
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
            this.dg_listaVendas = new System.Windows.Forms.DataGridView();
            this.dg_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_precoUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tb_produto = new System.Windows.Forms.TextBox();
            this.numeric_qtd = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.lbl_totalVenda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_registrarVenda = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_IDcliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_listaVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_qtd)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_listaVendas
            // 
            this.dg_listaVendas.AllowUserToAddRows = false;
            this.dg_listaVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_listaVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_codigo,
            this.dg_produto,
            this.dg_qtd,
            this.dg_precoUn,
            this.dg_valorTotal,
            this.dg_idProduto});
            this.dg_listaVendas.Location = new System.Drawing.Point(12, 152);
            this.dg_listaVendas.Name = "dg_listaVendas";
            this.dg_listaVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_listaVendas.Size = new System.Drawing.Size(776, 413);
            this.dg_listaVendas.TabIndex = 0;
            // 
            // dg_codigo
            // 
            this.dg_codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dg_codigo.HeaderText = "Código";
            this.dg_codigo.Name = "dg_codigo";
            // 
            // dg_produto
            // 
            this.dg_produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dg_produto.HeaderText = "Produto";
            this.dg_produto.Name = "dg_produto";
            // 
            // dg_qtd
            // 
            this.dg_qtd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dg_qtd.HeaderText = "Quantidade";
            this.dg_qtd.Name = "dg_qtd";
            // 
            // dg_precoUn
            // 
            this.dg_precoUn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dg_precoUn.HeaderText = "Preço Unitário";
            this.dg_precoUn.Name = "dg_precoUn";
            // 
            // dg_valorTotal
            // 
            this.dg_valorTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dg_valorTotal.HeaderText = "Valor Total";
            this.dg_valorTotal.Name = "dg_valorTotal";
            // 
            // dg_idProduto
            // 
            this.dg_idProduto.HeaderText = "ID";
            this.dg_idProduto.Name = "dg_idProduto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Código";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(8, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Produto";
            // 
            // tb_codigo
            // 
            this.tb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(93, 44);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(199, 26);
            this.tb_codigo.TabIndex = 23;
            // 
            // tb_produto
            // 
            this.tb_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_produto.Location = new System.Drawing.Point(93, 76);
            this.tb_produto.Name = "tb_produto";
            this.tb_produto.Size = new System.Drawing.Size(351, 26);
            this.tb_produto.TabIndex = 22;
            // 
            // numeric_qtd
            // 
            this.numeric_qtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_qtd.Location = new System.Drawing.Point(93, 120);
            this.numeric_qtd.Name = "numeric_qtd";
            this.numeric_qtd.Size = new System.Drawing.Size(59, 26);
            this.numeric_qtd.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(8, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Qtd.";
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_adicionar.Location = new System.Drawing.Point(486, 9);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(88, 61);
            this.bt_adicionar.TabIndex = 28;
            this.bt_adicionar.Text = "Adicionar Produto";
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remover.Location = new System.Drawing.Point(580, 9);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(88, 61);
            this.bt_remover.TabIndex = 29;
            this.bt_remover.Text = "Remover Produto";
            this.bt_remover.UseVisualStyleBackColor = true;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // lbl_totalVenda
            // 
            this.lbl_totalVenda.AutoSize = true;
            this.lbl_totalVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalVenda.Location = new System.Drawing.Point(670, 122);
            this.lbl_totalVenda.Name = "lbl_totalVenda";
            this.lbl_totalVenda.Size = new System.Drawing.Size(0, 20);
            this.lbl_totalVenda.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(482, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Valor da Venda";
            // 
            // bt_registrarVenda
            // 
            this.bt_registrarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_registrarVenda.Location = new System.Drawing.Point(674, 9);
            this.bt_registrarVenda.Name = "bt_registrarVenda";
            this.bt_registrarVenda.Size = new System.Drawing.Size(88, 61);
            this.bt_registrarVenda.TabIndex = 33;
            this.bt_registrarVenda.Text = "Registrar Venda";
            this.bt_registrarVenda.UseVisualStyleBackColor = true;
            this.bt_registrarVenda.Click += new System.EventHandler(this.bt_registrarVenda_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(8, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "ID Cliente";
            // 
            // tb_IDcliente
            // 
            this.tb_IDcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IDcliente.Location = new System.Drawing.Point(93, 12);
            this.tb_IDcliente.Name = "tb_IDcliente";
            this.tb_IDcliente.Size = new System.Drawing.Size(199, 26);
            this.tb_IDcliente.TabIndex = 34;
            // 
            // RegistroVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 589);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_IDcliente);
            this.Controls.Add(this.bt_registrarVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_totalVenda);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeric_qtd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.tb_produto);
            this.Controls.Add(this.dg_listaVendas);
            this.Name = "RegistroVendas";
            this.Text = "Registro_Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dg_listaVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_qtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_listaVendas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_produto;
        private System.Windows.Forms.NumericUpDown numeric_qtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.Label lbl_totalVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_registrarVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_IDcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_precoUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_valorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_idProduto;
    }
}