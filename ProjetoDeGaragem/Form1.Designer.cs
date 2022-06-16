namespace ProjetoDeGaragem
{
    partial class principal
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bt_registrarEntrada = new System.Windows.Forms.Button();
            this.bt_registrarSaida = new System.Windows.Forms.Button();
            this.bt_finalizarExpediente = new System.Windows.Forms.Button();
            this.dg_veiculosEstacionados = new System.Windows.Forms.DataGridView();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_mostrarSaida = new System.Windows.Forms.Button();
            this.tb_Motorista = new System.Windows.Forms.TextBox();
            this.tb_placa = new System.Windows.Forms.TextBox();
            this.cb_tipoVeiculo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharAlttF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbl_vagas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dg_veiculosEstacionados)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(318, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 26);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.TabStop = false;
            // 
            // bt_registrarEntrada
            // 
            this.bt_registrarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_registrarEntrada.Location = new System.Drawing.Point(13, 492);
            this.bt_registrarEntrada.Name = "bt_registrarEntrada";
            this.bt_registrarEntrada.Size = new System.Drawing.Size(99, 59);
            this.bt_registrarEntrada.TabIndex = 1;
            this.bt_registrarEntrada.Text = "Registrar Entrada";
            this.bt_registrarEntrada.UseVisualStyleBackColor = true;
            this.bt_registrarEntrada.Click += new System.EventHandler(this.bt_registrarEntrada_Click);
            // 
            // bt_registrarSaida
            // 
            this.bt_registrarSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_registrarSaida.Location = new System.Drawing.Point(118, 492);
            this.bt_registrarSaida.Name = "bt_registrarSaida";
            this.bt_registrarSaida.Size = new System.Drawing.Size(94, 59);
            this.bt_registrarSaida.TabIndex = 2;
            this.bt_registrarSaida.Text = "Registrar Saída";
            this.bt_registrarSaida.UseVisualStyleBackColor = true;
            this.bt_registrarSaida.Click += new System.EventHandler(this.bt_registrarSaida_Click);
            // 
            // bt_finalizarExpediente
            // 
            this.bt_finalizarExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_finalizarExpediente.Location = new System.Drawing.Point(318, 492);
            this.bt_finalizarExpediente.Name = "bt_finalizarExpediente";
            this.bt_finalizarExpediente.Size = new System.Drawing.Size(108, 59);
            this.bt_finalizarExpediente.TabIndex = 3;
            this.bt_finalizarExpediente.Text = "Finalizar Expediente";
            this.bt_finalizarExpediente.UseVisualStyleBackColor = true;
            this.bt_finalizarExpediente.Click += new System.EventHandler(this.bt_finalizarExpediente_Click);
            // 
            // dg_veiculosEstacionados
            // 
            this.dg_veiculosEstacionados.AllowUserToAddRows = false;
            this.dg_veiculosEstacionados.AllowUserToDeleteRows = false;
            this.dg_veiculosEstacionados.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dg_veiculosEstacionados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_veiculosEstacionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_veiculosEstacionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo,
            this.placa,
            this.Motorista,
            this.data,
            this.horario});
            this.dg_veiculosEstacionados.Location = new System.Drawing.Point(452, 53);
            this.dg_veiculosEstacionados.Name = "dg_veiculosEstacionados";
            this.dg_veiculosEstacionados.ReadOnly = true;
            this.dg_veiculosEstacionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_veiculosEstacionados.Size = new System.Drawing.Size(747, 498);
            this.dg_veiculosEstacionados.TabIndex = 4;
            // 
            // tipo
            // 
            this.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tipo.HeaderText = "Veículo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 150;
            // 
            // placa
            // 
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            this.placa.ReadOnly = true;
            this.placa.Width = 150;
            // 
            // Motorista
            // 
            this.Motorista.HeaderText = "Motorista";
            this.Motorista.Name = "Motorista";
            this.Motorista.ReadOnly = true;
            this.Motorista.Width = 150;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // horario
            // 
            this.horario.HeaderText = "Horário de Entrada";
            this.horario.Name = "horario";
            this.horario.ReadOnly = true;
            this.horario.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Veículos Estacionados";
            // 
            // bt_mostrarSaida
            // 
            this.bt_mostrarSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mostrarSaida.Location = new System.Drawing.Point(218, 492);
            this.bt_mostrarSaida.Name = "bt_mostrarSaida";
            this.bt_mostrarSaida.Size = new System.Drawing.Size(94, 59);
            this.bt_mostrarSaida.TabIndex = 6;
            this.bt_mostrarSaida.Text = "Mostar Entradas";
            this.bt_mostrarSaida.UseVisualStyleBackColor = true;
            this.bt_mostrarSaida.Click += new System.EventHandler(this.bt_mostrarSaida_Click);
            // 
            // tb_Motorista
            // 
            this.tb_Motorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Motorista.Location = new System.Drawing.Point(118, 169);
            this.tb_Motorista.Name = "tb_Motorista";
            this.tb_Motorista.Size = new System.Drawing.Size(308, 26);
            this.tb_Motorista.TabIndex = 9;
            // 
            // tb_placa
            // 
            this.tb_placa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_placa.Location = new System.Drawing.Point(118, 137);
            this.tb_placa.Name = "tb_placa";
            this.tb_placa.Size = new System.Drawing.Size(308, 26);
            this.tb_placa.TabIndex = 8;
            // 
            // cb_tipoVeiculo
            // 
            this.cb_tipoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipoVeiculo.FormattingEnabled = true;
            this.cb_tipoVeiculo.Items.AddRange(new object[] {
            "Moto",
            "Carro"});
            this.cb_tipoVeiculo.Location = new System.Drawing.Point(118, 103);
            this.cb_tipoVeiculo.Name = "cb_tipoVeiculo";
            this.cb_tipoVeiculo.Size = new System.Drawing.Size(308, 28);
            this.cb_tipoVeiculo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Veículo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Placa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Motorista";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.abrirToolStripMenuItem1,
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.fecharAlttF4ToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.abrirToolStripMenuItem.Text = "Novo";
            // 
            // abrirToolStripMenuItem1
            // 
            this.abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            this.abrirToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.abrirToolStripMenuItem1.Text = "Abrir";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como";
            // 
            // fecharAlttF4ToolStripMenuItem
            // 
            this.fecharAlttF4ToolStripMenuItem.Name = "fecharAlttF4ToolStripMenuItem";
            this.fecharAlttF4ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.fecharAlttF4ToolStripMenuItem.Text = "Fechar (Altt + F4)";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // janelaToolStripMenuItem
            // 
            this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            this.janelaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.janelaToolStripMenuItem.Text = "Janela";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.visualizarToolStripMenuItem,
            this.janelaToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1212, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbl_vagas
            // 
            this.lbl_vagas.AutoSize = true;
            this.lbl_vagas.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_vagas.Enabled = false;
            this.lbl_vagas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vagas.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_vagas.Location = new System.Drawing.Point(13, 441);
            this.lbl_vagas.Name = "lbl_vagas";
            this.lbl_vagas.Size = new System.Drawing.Size(0, 28);
            this.lbl_vagas.TabIndex = 14;
            this.lbl_vagas.UseCompatibleTextRendering = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 563);
            this.Controls.Add(this.lbl_vagas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_tipoVeiculo);
            this.Controls.Add(this.tb_placa);
            this.Controls.Add(this.tb_Motorista);
            this.Controls.Add(this.bt_mostrarSaida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_veiculosEstacionados);
            this.Controls.Add(this.bt_finalizarExpediente);
            this.Controls.Add(this.bt_registrarSaida);
            this.Controls.Add(this.bt_registrarEntrada);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "principal";
            this.Text = "Garagem do João Júnior";
            ((System.ComponentModel.ISupportInitialize)(this.dg_veiculosEstacionados)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bt_registrarEntrada;
        private System.Windows.Forms.Button bt_registrarSaida;
        private System.Windows.Forms.Button bt_finalizarExpediente;
        private System.Windows.Forms.DataGridView dg_veiculosEstacionados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_mostrarSaida;
        private System.Windows.Forms.TextBox tb_Motorista;
        private System.Windows.Forms.TextBox tb_placa;
        private System.Windows.Forms.ComboBox cb_tipoVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharAlttF4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lbl_vagas;
        private System.Windows.Forms.Timer timer1;
    }
}

