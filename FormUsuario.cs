using Microsoft.EntityFrameworkCore;
using sysestoque_alpha.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysestoque_alpha
{
    public partial class FormUsuario : Form
    {

        ICollection<Usuario> ListaUsuario = new List<Usuario>();
        Usuario usuario = new Usuario();

        BindingSource bindingSourceUsuario = new BindingSource();


        private bool EstaAtualizando = false;
        public FormUsuario()
        {
            InitializeComponent();

            using (var db = new EstoqueContext())
            {
                ListaUsuario = db.Usuario.ToList();
                bindingSourceUsuario.DataSource = ListaUsuario;
                dgvUsuario.DataSource = bindingSourceUsuario;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {

                var result = MessageBox.Show("Você deseja mesmo excluir essas informações?",
                                                "Excluir",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Executa a lógica de acordo com a resposta
                }

                usuario = dgvUsuario.SelectedRows[0].DataBoundItem as Usuario;

                //Remove a categoria do Datagridview
                bindingSourceUsuario.Remove(usuario);

                //Remove do Bnaco de Dados
                using (var db = new EstoqueContext())
                {
                    db.Usuario.Remove(usuario);
                    db.SaveChanges();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {

            try
            {
                if (EstaAtualizando)
                {

                    usuario.Login = txtLogin.Text;
                    usuario.HashSenha = txtSenha.Text;
                    usuario.Nome = txtNome.Text;
                    usuario.Telefone = txtTelefone.Text;
                    usuario.Email = txtEmail.Text;

                    using (var db = new EstoqueContext())
                    {
                        db.Usuario.Add(usuario);
                        db.SaveChanges();

                        ListaUsuario = db.Usuario.ToList();
                        bindingSourceUsuario.DataSource = ListaUsuario;
                        dgvUsuario.DataSource = bindingSourceUsuario;
                        dgvUsuario.Refresh();
                    }
                }
                else
                {
                    usuario.Login = txtLogin.Text;
                    usuario.HashSenha = txtSenha.Text;
                    usuario.Nome = txtNome.Text;
                    usuario.Telefone = txtTelefone.Text;
                    usuario.Email = txtEmail.Text;

                    using (var db = new EstoqueContext())
                    {
                        db.Usuario.Add(usuario);
                        db.SaveChanges();

                        ListaUsuario = db.Usuario.ToList();
                        bindingSourceUsuario.DataSource = ListaUsuario;
                        dgvUsuario.DataSource = bindingSourceUsuario;
                        dgvUsuario.Refresh();
                    }
                }
            }
            catch (DbUpdateException erro)
            {
                MessageBox.Show("Já existi um CNPJ '(fornecedor.cnpj)' cadastrado no banco de dados",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
            }
            catch (Exception erro)
            {
                MessageBox.Show(
                        erro.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                usuario = dgvUsuario.SelectedRows[0].DataBoundItem as Usuario;

                txtLogin.Text = usuario.Login.ToString();
                txtSenha.Text = usuario.HashSenha;
                txtNome.Text = usuario.Nome;
                txtTelefone.Text = usuario.Telefone;
                txtEmail.Text = usuario.Email;

                EstaAtualizando = true;
            }
        }
    }
}
