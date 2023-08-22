using sysestoque_alpha.Models;
using System.Drawing.Text;
using System.Text;
using System.Security.Cryptography;

namespace sysestoque_alpha
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string Login = txbLogin1.Text;
            string Senha = txbSenha.Text;

            Usuario usuario = null;

            //busca o usuario no banco de dados
            using (var db = new EstoqueContext())
            {
                usuario = db.Usuario.FirstOrDefault(X => X.Login == Login);
            }

            if (usuario != null)
            {
                //calculo do hash -- utilizando a classe para construir nossa string
                StringBuilder sb = new StringBuilder();

                using (SHA512 sha512 = SHA512.Create())
                {
                    //Criptografando a senha inserida pelo usuário
                    //para comparar com a senha guardada no banco de de dados
                    byte[] hashValue = sha512.ComputeHash(Encoding.UTF8.GetBytes(Login));
                    foreach (byte b in hashValue)
                    {
                        sb.Append($"{b:x2}");
                    }
                }

                Senha = sb.ToString();

                if (usuario.HashSenha == Senha)
                {
                    //this.Hide();

                    /*
                     * Abre a tela principal, dando acesso ao todas as outras telas
                     * 
                    FormaMain formaMain = new FormaMain();
                    formaMain.Show();
                    */

                    MessageBox.Show("Usuário logado com sucesso ");
                }
                else
                {
                    MessageBox.Show(" Acesso Negado! ");
                }
            }
            else
            {
                MessageBox.Show(" Acesso Negado! ");
            }
        }

        private void btnSenha_Click_1(object sender, EventArgs e)
        {
            txbLogin1.UseSystemPasswordChar = !txbLogin1.UseSystemPasswordChar;
        }
    }
}