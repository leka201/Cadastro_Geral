namespace Cadastro_Geral
{
    partial class Cadastro_Clientes
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_nascimento = new System.Windows.Forms.Label();
            this.lbl_CEP = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_nome.Location = new System.Drawing.Point(33, 44);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(83, 26);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome: ";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_cpf.Location = new System.Drawing.Point(448, 232);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(68, 26);
            this.lbl_cpf.TabIndex = 2;
            this.lbl_cpf.Text = "CPF: ";
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_nascimento.Location = new System.Drawing.Point(33, 226);
            this.lbl_nascimento.Name = "lbl_nascimento";
            this.lbl_nascimento.Size = new System.Drawing.Size(222, 26);
            this.lbl_nascimento.TabIndex = 3;
            this.lbl_nascimento.Text = "Data de Nascimento: ";
            // 
            // lbl_CEP
            // 
            this.lbl_CEP.AutoSize = true;
            this.lbl_CEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_CEP.Location = new System.Drawing.Point(33, 179);
            this.lbl_CEP.Name = "lbl_CEP";
            this.lbl_CEP.Size = new System.Drawing.Size(70, 26);
            this.lbl_CEP.TabIndex = 4;
            this.lbl_CEP.Text = "CEP: ";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_email.Location = new System.Drawing.Point(33, 131);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(80, 26);
            this.lbl_email.TabIndex = 5;
            this.lbl_email.Text = "Email: ";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbl_telefone.Location = new System.Drawing.Point(33, 85);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(107, 26);
            this.lbl_telefone.TabIndex = 6;
            this.lbl_telefone.Text = "Telefone: ";
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Tomato;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_sair.Location = new System.Drawing.Point(76, 293);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(147, 54);
            this.btn_sair.TabIndex = 7;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Lime;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_salvar.Location = new System.Drawing.Point(576, 293);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(150, 54);
            this.btn_salvar.TabIndex = 8;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txt_nome.Location = new System.Drawing.Point(141, 41);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(633, 32);
            this.txt_nome.TabIndex = 9;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox2.Location = new System.Drawing.Point(542, 226);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 32);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox3.Location = new System.Drawing.Point(141, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(633, 32);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox4.Location = new System.Drawing.Point(141, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(633, 32);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox5.Location = new System.Drawing.Point(141, 82);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(633, 32);
            this.textBox5.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(252, 226);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 32);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // Cadastro_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_CEP);
            this.Controls.Add(this.lbl_nascimento);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Cadastro_Clientes";
            this.Text = "Cadastro_Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_nascimento;
        private System.Windows.Forms.Label lbl_CEP;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}