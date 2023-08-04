using sysestoque_alpha.Models;
using System.Drawing.Text;

namespace sysestoque_alpha
{
    public partial class FormLogin : Form {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e){
            string Login = txbLogin.Text;
            string Senha = txbSenha.Text;

            Usuario usuario = null;
            //busca o usuario no banco de dados
            using (var db = new EstoqueContext()){
                usuario = db.Usuario.FirstOrDefault(X => X.Login == Login);
            }

            if (usuario != null){

                if (Senha == usuario.HashSenha)                    {
                    MessageBox.Show("Usuário logado com sucesso ");
                }else{
                    MessageBox.Show(" Acesso Negado! ");
                }
            }else{
                MessageBox.Show(" Acesso Negado! ");
            }
        }

        private void btnSenha_Click_1(object sender, EventArgs e){
            txbSenha.UseSystemPasswordChar = !txbSenha.UseSystemPasswordChar;
        }
    }
}