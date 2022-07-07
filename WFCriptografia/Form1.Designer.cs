namespace WFCriptografia
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_frase = new System.Windows.Forms.TextBox();
            this.bt_criptografarAssimetrica = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_fraseCriptografada = new System.Windows.Forms.Label();
            this.bt_descriptografar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_criptografarSimetrico = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_chave = new System.Windows.Forms.TextBox();
            this.bt_descriptografarSimetrica = new System.Windows.Forms.Button();
            this.lbl_fraseDescriptografada = new System.Windows.Forms.Label();
            this.bt_descriptografarAes = new System.Windows.Forms.Button();
            this.bt_criptografarAes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frase:";
            // 
            // tb_frase
            // 
            this.tb_frase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_frase.Location = new System.Drawing.Point(73, 13);
            this.tb_frase.Name = "tb_frase";
            this.tb_frase.Size = new System.Drawing.Size(321, 26);
            this.tb_frase.TabIndex = 1;
            // 
            // bt_criptografarAssimetrica
            // 
            this.bt_criptografarAssimetrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_criptografarAssimetrica.Location = new System.Drawing.Point(73, 45);
            this.bt_criptografarAssimetrica.Name = "bt_criptografarAssimetrica";
            this.bt_criptografarAssimetrica.Size = new System.Drawing.Size(116, 61);
            this.bt_criptografarAssimetrica.TabIndex = 2;
            this.bt_criptografarAssimetrica.Text = "Criptografar Assimétrica";
            this.bt_criptografarAssimetrica.UseVisualStyleBackColor = true;
            this.bt_criptografarAssimetrica.Click += new System.EventHandler(this.bt_criptografar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Frase criptografada:";
            // 
            // lbl_fraseCriptografada
            // 
            this.lbl_fraseCriptografada.AutoEllipsis = true;
            this.lbl_fraseCriptografada.Location = new System.Drawing.Point(22, 272);
            this.lbl_fraseCriptografada.MaximumSize = new System.Drawing.Size(328, 500);
            this.lbl_fraseCriptografada.Name = "lbl_fraseCriptografada";
            this.lbl_fraseCriptografada.Size = new System.Drawing.Size(328, 79);
            this.lbl_fraseCriptografada.TabIndex = 4;
            // 
            // bt_descriptografar
            // 
            this.bt_descriptografar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_descriptografar.Location = new System.Drawing.Point(195, 45);
            this.bt_descriptografar.Name = "bt_descriptografar";
            this.bt_descriptografar.Size = new System.Drawing.Size(133, 61);
            this.bt_descriptografar.TabIndex = 5;
            this.bt_descriptografar.Text = "Descriptografar Assimétrica";
            this.bt_descriptografar.UseVisualStyleBackColor = true;
            this.bt_descriptografar.Click += new System.EventHandler(this.bt_descriptografar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Frase descriptografada";
            // 
            // bt_criptografarSimetrico
            // 
            this.bt_criptografarSimetrico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_criptografarSimetrico.Location = new System.Drawing.Point(497, 45);
            this.bt_criptografarSimetrico.Name = "bt_criptografarSimetrico";
            this.bt_criptografarSimetrico.Size = new System.Drawing.Size(133, 61);
            this.bt_criptografarSimetrico.TabIndex = 8;
            this.bt_criptografarSimetrico.Text = "Criptografar Simétrica";
            this.bt_criptografarSimetrico.UseVisualStyleBackColor = true;
            this.bt_criptografarSimetrico.Click += new System.EventHandler(this.bt_criptografarSimetrico_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(409, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chave";
            // 
            // tb_chave
            // 
            this.tb_chave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_chave.Location = new System.Drawing.Point(469, 13);
            this.tb_chave.Name = "tb_chave";
            this.tb_chave.Size = new System.Drawing.Size(300, 26);
            this.tb_chave.TabIndex = 10;
            // 
            // bt_descriptografarSimetrica
            // 
            this.bt_descriptografarSimetrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_descriptografarSimetrica.Location = new System.Drawing.Point(636, 45);
            this.bt_descriptografarSimetrica.Name = "bt_descriptografarSimetrica";
            this.bt_descriptografarSimetrica.Size = new System.Drawing.Size(133, 61);
            this.bt_descriptografarSimetrica.TabIndex = 11;
            this.bt_descriptografarSimetrica.Text = "Descriptografar Simétrica";
            this.bt_descriptografarSimetrica.UseVisualStyleBackColor = true;
            this.bt_descriptografarSimetrica.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_fraseDescriptografada
            // 
            this.lbl_fraseDescriptografada.AutoEllipsis = true;
            this.lbl_fraseDescriptografada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fraseDescriptografada.Location = new System.Drawing.Point(22, 374);
            this.lbl_fraseDescriptografada.MaximumSize = new System.Drawing.Size(328, 500);
            this.lbl_fraseDescriptografada.Name = "lbl_fraseDescriptografada";
            this.lbl_fraseDescriptografada.Size = new System.Drawing.Size(328, 79);
            this.lbl_fraseDescriptografada.TabIndex = 12;
            // 
            // bt_descriptografarAes
            // 
            this.bt_descriptografarAes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_descriptografarAes.Location = new System.Drawing.Point(195, 112);
            this.bt_descriptografarAes.Name = "bt_descriptografarAes";
            this.bt_descriptografarAes.Size = new System.Drawing.Size(133, 61);
            this.bt_descriptografarAes.TabIndex = 14;
            this.bt_descriptografarAes.Text = "Descriptografar AES";
            this.bt_descriptografarAes.UseVisualStyleBackColor = true;
            // 
            // bt_criptografarAes
            // 
            this.bt_criptografarAes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_criptografarAes.Location = new System.Drawing.Point(73, 112);
            this.bt_criptografarAes.Name = "bt_criptografarAes";
            this.bt_criptografarAes.Size = new System.Drawing.Size(116, 61);
            this.bt_criptografarAes.TabIndex = 13;
            this.bt_criptografarAes.Text = "Criptografar AES";
            this.bt_criptografarAes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 470);
            this.Controls.Add(this.bt_descriptografarAes);
            this.Controls.Add(this.bt_criptografarAes);
            this.Controls.Add(this.lbl_fraseDescriptografada);
            this.Controls.Add(this.bt_descriptografarSimetrica);
            this.Controls.Add(this.tb_chave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_criptografarSimetrico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_descriptografar);
            this.Controls.Add(this.lbl_fraseCriptografada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_criptografarAssimetrica);
            this.Controls.Add(this.tb_frase);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_frase;
        private System.Windows.Forms.Button bt_criptografarAssimetrica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_fraseCriptografada;
        private System.Windows.Forms.Button bt_descriptografar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_criptografarSimetrico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_chave;
        private System.Windows.Forms.Button bt_descriptografarSimetrica;
        private System.Windows.Forms.Label lbl_fraseDescriptografada;
        private System.Windows.Forms.Button bt_descriptografarAes;
        private System.Windows.Forms.Button bt_criptografarAes;
    }
}

