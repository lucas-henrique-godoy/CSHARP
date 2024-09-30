using CadastroUsuario.Model;
using System;
using System.Windows.Forms;

namespace CadastroUsuario
{
    public partial class Frm_Cadastro : Form
    {
        public Frm_Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Usuario usuario = new Usuario();
                usuario.nome = txt_nome.Text;
                usuario.dataNascimento = Convert.ToDateTime(dtp_Nascimento.Text);
                usuario.cpf = mtxt_CPF.Text;
                usuario.telefone = mtxt_Telefone.Text;
                usuario.endereco = txt_Endereco.Text;

                //lbl_Usuarios.Items.Add(usuario);

                LimparCampos();
                

                MessageBox.Show("Usuário salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarCampos()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is MaskedTextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        MessageBox.Show("Existem campos em branco!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }

        private void LimparCampos()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is MaskedTextBox)
                {
                    control.Text = "";
                }
            }
        }
    }
}
