using sysestoque_alpha.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysestoque_alpha
{
    public partial class FormCategoria : Form
    {
        ICollection<Categoria> listaCategoria = new List<Categoria>();
        BindingSource bindingSourceCategoria = new BindingSource();

        Categoria categoria = new Categoria();

        private bool EstaAtualizando = false;
        public FormCategoria()
        {

            InitializeComponent();

            using (var db = new EstoqueContext())
            {

                listaCategoria = db.Categoria.ToList();

                bindingSourceCategoria.DataSource = listaCategoria;

                dgvCategoria.DataSource = bindingSourceCategoria;

            }
        }

        private void Categoria_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e) {

            if (dgvCategoria.SelectedRows.Count > 0) {

                var result = MessageBox.Show("Você deseja mesmo excluir essa informação",
                                                "Excluir",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question );

                if (result == DialogResult.Yes) {
                    // Executa a Lógica de acordo com a resposta
                }

                categoria = dgvCategoria.SelectedRows[0].DataBoundItem as Categoria;

                //Remove a categoria do DataGridView
                bindingSourceCategoria.Remove(categoria);

                //Remove do Banco de Dados
                using (var db = new EstoqueContext()) {
                    db.Categoria.Remove(categoria);
                    db.SaveChanges();

                }

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            categoria.Id = null;
            categoria.Nome = txtNome.Text;
            categoria.Descricao = txtDescricao.Text;

            using (var db = new EstoqueContext())
            {
                db.Categoria.Add(categoria);
                db.SaveChanges();

                listaCategoria = db.Categoria.ToList();

                bindingSourceCategoria.DataSource = listaCategoria;

                dgvCategoria.DataSource = bindingSourceCategoria;

                dgvCategoria.Refresh();


            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.SelectedRows.Count > 0)
            {
                categoria = dgvCategoria.SelectedRows[0].DataBoundItem as Categoria;

                txtID.Text = categoria.Id.ToString();
                txtNome.Text = categoria.Nome;
                txtDescricao.Text = categoria.Descricao;

                EstaAtualizando = true;
            }
        }
    }
}

