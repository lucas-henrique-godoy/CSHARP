namespace CadastroUsuario
{
    partial class Frm_Cadastro
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
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Data_Nascimento = new System.Windows.Forms.Label();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.lbl_Usuarios = new System.Windows.Forms.ListBox();
            this.dtp_Nascimento = new System.Windows.Forms.DateTimePicker();
            this.mtxt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(24, 8);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome";
            this.lbl_Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Data_Nascimento
            // 
            this.lbl_Data_Nascimento.AutoSize = true;
            this.lbl_Data_Nascimento.Location = new System.Drawing.Point(24, 59);
            this.lbl_Data_Nascimento.Name = "lbl_Data_Nascimento";
            this.lbl_Data_Nascimento.Size = new System.Drawing.Size(89, 13);
            this.lbl_Data_Nascimento.TabIndex = 1;
            this.lbl_Data_Nascimento.Text = "Data Nascimento";
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.Location = new System.Drawing.Point(208, 59);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(27, 13);
            this.lbl_CPF.TabIndex = 2;
            this.lbl_CPF.Text = "CPF";
            this.lbl_CPF.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Location = new System.Drawing.Point(24, 110);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_Telefone.TabIndex = 3;
            this.lbl_Telefone.Text = "Telefone";
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Location = new System.Drawing.Point(24, 161);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(53, 13);
            this.lbl_Endereco.TabIndex = 4;
            this.lbl_Endereco.Text = "Endereço";
            this.lbl_Endereco.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(24, 30);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(287, 20);
            this.txt_nome.TabIndex = 5;
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Location = new System.Drawing.Point(24, 183);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(287, 20);
            this.txt_Endereco.TabIndex = 9;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(125, 275);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(0, 13);
            this.lbl_Resultado.TabIndex = 10;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(472, 209);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(114, 32);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(346, 209);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(120, 32);
            this.btn_Salvar.TabIndex = 12;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // lbl_Usuarios
            // 
            this.lbl_Usuarios.FormattingEnabled = true;
            this.lbl_Usuarios.Location = new System.Drawing.Point(346, 30);
            this.lbl_Usuarios.Name = "lbl_Usuarios";
            this.lbl_Usuarios.Size = new System.Drawing.Size(240, 173);
            this.lbl_Usuarios.TabIndex = 13;
            // 
            // dtp_Nascimento
            // 
            this.dtp_Nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Nascimento.Location = new System.Drawing.Point(27, 81);
            this.dtp_Nascimento.Name = "dtp_Nascimento";
            this.dtp_Nascimento.Size = new System.Drawing.Size(104, 20);
            this.dtp_Nascimento.TabIndex = 14;
            // 
            // mtxt_CPF
            // 
            this.mtxt_CPF.Location = new System.Drawing.Point(211, 84);
            this.mtxt_CPF.Mask = "000.000.000-00";
            this.mtxt_CPF.Name = "mtxt_CPF";
            this.mtxt_CPF.Size = new System.Drawing.Size(100, 20);
            this.mtxt_CPF.TabIndex = 15;
            // 
            // mtxt_Telefone
            // 
            this.mtxt_Telefone.Location = new System.Drawing.Point(27, 132);
            this.mtxt_Telefone.Mask = "(00)00000-0000";
            this.mtxt_Telefone.Name = "mtxt_Telefone";
            this.mtxt_Telefone.Size = new System.Drawing.Size(100, 20);
            this.mtxt_Telefone.TabIndex = 16;
            // 
            // Frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 253);
            this.Controls.Add(this.mtxt_Telefone);
            this.Controls.Add(this.mtxt_CPF);
            this.Controls.Add(this.dtp_Nascimento);
            this.Controls.Add(this.lbl_Usuarios);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.txt_Endereco);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_Endereco);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.lbl_CPF);
            this.Controls.Add(this.lbl_Data_Nascimento);
            this.Controls.Add(this.lbl_Nome);
            this.Name = "Frm_Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Data_Nascimento;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.Label lbl_Endereco;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.ListBox lbl_Usuarios;
        private System.Windows.Forms.DateTimePicker dtp_Nascimento;
        private System.Windows.Forms.MaskedTextBox mtxt_CPF;
        private System.Windows.Forms.MaskedTextBox mtxt_Telefone;
    }
}

