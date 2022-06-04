namespace primeiroWinForms
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
            this.BTOK = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.lblNumeroCasa = new System.Windows.Forms.Label();
            this.txtNumeroCasa = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTOK
            // 
            this.BTOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BTOK.Location = new System.Drawing.Point(99, 362);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(119, 61);
            this.BTOK.TabIndex = 0;
            this.BTOK.Text = "Cadastrar";
            this.BTOK.UseVisualStyleBackColor = true;
            this.BTOK.Click += new System.EventHandler(this.BT1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(356, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(99, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(376, 26);
            this.txtNome.TabIndex = 2;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblnome.Location = new System.Drawing.Point(19, 17);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(55, 20);
            this.lblnome.TabIndex = 3;
            this.lblnome.Text = "Nome:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblemail.Location = new System.Drawing.Point(19, 57);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(51, 20);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "e-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(99, 60);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(376, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEndereco.Location = new System.Drawing.Point(4, 150);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(78, 20);
            this.lblEndereco.TabIndex = 6;
            this.lblEndereco.Text = "Endereço";
            this.lblEndereco.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTelefone.Location = new System.Drawing.Point(8, 107);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblTelefone.TabIndex = 7;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBairro.Location = new System.Drawing.Point(8, 201);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 20);
            this.lblBairro.TabIndex = 8;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCidade.Location = new System.Drawing.Point(13, 254);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(59, 20);
            this.lblCidade.TabIndex = 9;
            this.lblCidade.Text = "Cidade";
            this.lblCidade.Click += new System.EventHandler(this.lblCidade_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSexo.Location = new System.Drawing.Point(22, 309);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(45, 20);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo";
            this.lblSexo.Click += new System.EventHandler(this.lblSexo_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTelefone.Location = new System.Drawing.Point(99, 107);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(376, 26);
            this.txtTelefone.TabIndex = 11;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEndereco.Location = new System.Drawing.Point(99, 153);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(202, 26);
            this.txtEndereco.TabIndex = 12;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBairro.Location = new System.Drawing.Point(99, 197);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(376, 26);
            this.txtBairro.TabIndex = 13;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCidade.Location = new System.Drawing.Point(99, 254);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(376, 26);
            this.txtCidade.TabIndex = 14;
            // 
            // txtSexo
            // 
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSexo.Location = new System.Drawing.Point(99, 306);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(376, 26);
            this.txtSexo.TabIndex = 15;
            // 
            // lblNumeroCasa
            // 
            this.lblNumeroCasa.AutoSize = true;
            this.lblNumeroCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumeroCasa.Location = new System.Drawing.Point(317, 159);
            this.lblNumeroCasa.Name = "lblNumeroCasa";
            this.lblNumeroCasa.Size = new System.Drawing.Size(26, 20);
            this.lblNumeroCasa.TabIndex = 16;
            this.lblNumeroCasa.Text = "Nº";
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumeroCasa.Location = new System.Drawing.Point(354, 156);
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.Size = new System.Drawing.Size(121, 26);
            this.txtNumeroCasa.TabIndex = 13;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(8, 460);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 485);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtNumeroCasa);
            this.Controls.Add(this.lblNumeroCasa);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTOK);
            this.Name = "Form1";
            this.Text = "Primeiro Windows Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTOK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label lblNumeroCasa;
        private System.Windows.Forms.TextBox txtNumeroCasa;
        private System.Windows.Forms.Label lblMsg;
    }
}

