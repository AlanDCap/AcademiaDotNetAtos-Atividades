namespace CadastroUsuario_DB
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            this.tb_idUsuario = new System.Windows.Forms.TextBox();
            this.tb_nomeUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.bt_remover = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_conectar = new System.Windows.Forms.ToolStripMenuItem();
            this.lv_tabelaCadastrados = new System.Windows.Forms.ListView();
            this.lv_idUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_idUsuario
            // 
            this.tb_idUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idUsuario.Location = new System.Drawing.Point(137, 44);
            this.tb_idUsuario.Name = "tb_idUsuario";
            this.tb_idUsuario.Size = new System.Drawing.Size(249, 26);
            this.tb_idUsuario.TabIndex = 0;
            // 
            // tb_nomeUsuario
            // 
            this.tb_nomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nomeUsuario.Location = new System.Drawing.Point(137, 76);
            this.tb_nomeUsuario.Name = "tb_nomeUsuario";
            this.tb_nomeUsuario.Size = new System.Drawing.Size(249, 26);
            this.tb_nomeUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID de Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_adicionar.Location = new System.Drawing.Point(174, 150);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(103, 33);
            this.bt_adicionar.TabIndex = 6;
            this.bt_adicionar.Text = "Adicionar";
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remover.Location = new System.Drawing.Point(283, 150);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(103, 33);
            this.bt_remover.TabIndex = 8;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_conectar});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // bt_conectar
            // 
            this.bt_conectar.Name = "bt_conectar";
            this.bt_conectar.Size = new System.Drawing.Size(180, 22);
            this.bt_conectar.Text = "Conectar";
            this.bt_conectar.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // lv_tabelaCadastrados
            // 
            this.lv_tabelaCadastrados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lv_idUsuario,
            this.lv_Nome,
            this.lv_email});
            this.lv_tabelaCadastrados.HideSelection = false;
            this.lv_tabelaCadastrados.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.lv_tabelaCadastrados.Location = new System.Drawing.Point(412, 44);
            this.lv_tabelaCadastrados.Name = "lv_tabelaCadastrados";
            this.lv_tabelaCadastrados.Size = new System.Drawing.Size(579, 194);
            this.lv_tabelaCadastrados.TabIndex = 10;
            this.lv_tabelaCadastrados.UseCompatibleStateImageBehavior = false;
            // 
            // lv_idUsuario
            // 
            this.lv_idUsuario.Text = "ID";
            // 
            // lv_Nome
            // 
            this.lv_Nome.Text = "Nome";
            // 
            // lv_email
            // 
            this.lv_email.Text = "e-mail";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 257);
            this.Controls.Add(this.lv_tabelaCadastrados);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nomeUsuario);
            this.Controls.Add(this.tb_idUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cadastro de Usuários";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_idUsuario;
        private System.Windows.Forms.TextBox tb_nomeUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bt_conectar;
        private System.Windows.Forms.ListView lv_tabelaCadastrados;
        private System.Windows.Forms.ColumnHeader lv_idUsuario;
        private System.Windows.Forms.ColumnHeader lv_Nome;
        private System.Windows.Forms.ColumnHeader lv_email;
    }
}

