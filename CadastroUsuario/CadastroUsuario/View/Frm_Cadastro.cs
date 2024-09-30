using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        // Método que é chamado quando o botão "Salvar" é clicado.
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // A linha abaixo faz o seguinte:
            // Atribui o valor do texto que está no campo de entrada (txt_Nome)
            // ao texto que será exibido no rótulo (lbl_Resultado).
            lbl_Resultado.Text = txt_Nome.Text;
        }

        // Método que é chamado quando o botão "Cancelar" é clicado.
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            // Fecha a janela atual da aplicação.
            this.Close();
        }
    }
}
