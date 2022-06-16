namespace ProjetoDeGaragem
{
    partial class ListaEntradas
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
            this.dg_listaEntradas = new System.Windows.Forms.DataGridView();
            this.dg_listaVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_listaPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_listaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_listaHorarioEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_listaEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_listaEntradas
            // 
            this.dg_listaEntradas.AllowUserToAddRows = false;
            this.dg_listaEntradas.AllowUserToDeleteRows = false;
            this.dg_listaEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_listaEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_listaVeiculo,
            this.dg_listaPlaca,
            this.dg_listaNome,
            this.dg_listaHorarioEntrada});
            this.dg_listaEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_listaEntradas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_listaEntradas.Location = new System.Drawing.Point(0, 0);
            this.dg_listaEntradas.Name = "dg_listaEntradas";
            this.dg_listaEntradas.Size = new System.Drawing.Size(800, 450);
            this.dg_listaEntradas.TabIndex = 0;
            this.dg_listaEntradas.TabStop = false;
            // 
            // dg_listaVeiculo
            // 
            this.dg_listaVeiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dg_listaVeiculo.HeaderText = "Veículo";
            this.dg_listaVeiculo.Name = "dg_listaVeiculo";
            // 
            // dg_listaPlaca
            // 
            this.dg_listaPlaca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dg_listaPlaca.HeaderText = "Placa";
            this.dg_listaPlaca.Name = "dg_listaPlaca";
            // 
            // dg_listaNome
            // 
            this.dg_listaNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dg_listaNome.HeaderText = "Motorista";
            this.dg_listaNome.Name = "dg_listaNome";
            // 
            // dg_listaHorarioEntrada
            // 
            this.dg_listaHorarioEntrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dg_listaHorarioEntrada.HeaderText = "Entrada";
            this.dg_listaHorarioEntrada.Name = "dg_listaHorarioEntrada";
            // 
            // ListaEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_listaEntradas);
            this.Name = "ListaEntradas";
            this.Text = "Lista de Entradas de Veículos";
            ((System.ComponentModel.ISupportInitialize)(this.dg_listaEntradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_listaVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_listaPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_listaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_listaHorarioEntrada;
        internal System.Windows.Forms.DataGridView dg_listaEntradas;
    }
}