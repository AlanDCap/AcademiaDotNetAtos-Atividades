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
            this.lv_tabelaCadastrados = new System.Windows.Forms.ListView();
            this.lv_idUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.tb_telefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_sincronizar = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_adicionar.Location = new System.Drawing.Point(12, 284);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(85, 54);
            this.bt_adicionar.TabIndex = 6;
            this.bt_adicionar.Text = "Adicionar";
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // bt_remover
            // 
            this.bt_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remover.Location = new System.Drawing.Point(103, 284);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(85, 54);
            this.bt_remover.TabIndex = 8;
            this.bt_remover.Text = "Remover";
            this.bt_remover.UseVisualStyleBackColor = true;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // lv_tabelaCadastrados
            // 
            this.lv_tabelaCadastrados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lv_idUsuario,
            this.lv_Nome,
            this.lv_email,
            this.lv_telefone,
            this.lv_endereco});
            this.lv_tabelaCadastrados.HideSelection = false;
            this.lv_tabelaCadastrados.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.lv_tabelaCadastrados.Location = new System.Drawing.Point(414, 44);
            this.lv_tabelaCadastrados.Name = "lv_tabelaCadastrados";
            this.lv_tabelaCadastrados.Size = new System.Drawing.Size(660, 294);
            this.lv_tabelaCadastrados.TabIndex = 10;
            this.lv_tabelaCadastrados.UseCompatibleStateImageBehavior = false;
            this.lv_tabelaCadastrados.View = System.Windows.Forms.View.Details;
            // 
            // lv_idUsuario
            // 
            this.lv_idUsuario.Text = "ID";
            this.lv_idUsuario.Width = 34;
            // 
            // lv_Nome
            // 
            this.lv_Nome.Text = "Nome";
            this.lv_Nome.Width = 132;
            // 
            // lv_email
            // 
            this.lv_email.Text = "e-mail";
            this.lv_email.Width = 171;
            // 
            // lv_telefone
            // 
            this.lv_telefone.Text = "Telefone";
            this.lv_telefone.Width = 119;
            // 
            // lv_endereco
            // 
            this.lv_endereco.Text = "Endereço";
            this.lv_endereco.Width = 197;
            // 
            // tb_endereco
            // 
            this.tb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_endereco.Location = new System.Drawing.Point(137, 108);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(249, 26);
            this.tb_endereco.TabIndex = 11;
            // 
            // tb_telefone
            // 
            this.tb_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_telefone.Location = new System.Drawing.Point(137, 140);
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(249, 26);
            this.tb_telefone.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefone";
            // 
            // bt_sincronizar
            // 
            this.bt_sincronizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sincronizar.Location = new System.Drawing.Point(303, 284);
            this.bt_sincronizar.Name = "bt_sincronizar";
            this.bt_sincronizar.Size = new System.Drawing.Size(105, 54);
            this.bt_sincronizar.TabIndex = 16;
            this.bt_sincronizar.Text = "Conectar / Sincronizar";
            this.bt_sincronizar.UseVisualStyleBackColor = true;
            this.bt_sincronizar.Click += new System.EventHandler(this.bt_sincronizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 355);
            this.Controls.Add(this.bt_sincronizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_telefone);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.lv_tabelaCadastrados);
            this.Controls.Add(this.bt_remover);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nomeUsuario);
            this.Controls.Add(this.tb_idUsuario);
            this.Name = "Form1";
            this.Text = "Cadastro de Usuários";
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
        private System.Windows.Forms.ListView lv_tabelaCadastrados;
        private System.Windows.Forms.ColumnHeader lv_idUsuario;
        private System.Windows.Forms.ColumnHeader lv_Nome;
        private System.Windows.Forms.ColumnHeader lv_email;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.TextBox tb_telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader lv_telefone;
        private System.Windows.Forms.ColumnHeader lv_endereco;
        private System.Windows.Forms.Button bt_sincronizar;
    }
}

