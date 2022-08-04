using MetododeAutenticacao.Classes;
using System;
using System.Windows.Forms;

namespace MetododeAutenticacao.Desktop
{
    public partial class TelaAutenticacao : Form
    {
        public TelaAutenticacao()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //objeto é uma instância da classe
            /*
             * 1-Coloque o nome da classe
             * 2-Defina o objeto
             * 3-Sinal de "="
             * 4-Operador New
             * 5-Chamada ao construtor ()
             * 
             * aluno1.Nome = "Bruno";
             * aluno1.Telefone = "6646464646";
             * 
             * QuaTurmaTop aluno2 = new QuaTurmaTop();
             * aluno2.Nome = "Carioca";
             * aluno2.Telefone = "4545555";
             * 
             * 
             */

            Usuario usuario = new Usuario();
            usuario.Login = textLogin.Text;
            usuario.Senha = textSenha.Text;
            // MessageBox.Show("Seja Bem Vindo!!" + usuario.Login);
            // MessageBox.Show($"Seja Bem Vindo!! {usuario.Login}!");
            if (usuario.Login.Equals(""))
            {
                MessageBox.Show("Login obrigatorio");
                textLogin.Focus();
            }
            else if (usuario.Senha.Equals(""))
            {
                MessageBox.Show("Senha Obrigatorio" + usuario.Senha);
                textSenha.Focus();
                
            }
            else
            {
                MessageBox.Show("Seja Bem Vindo!!" + usuario.Login);
                new TelaCadUsuario().Show();
            }
        }
    }
}
