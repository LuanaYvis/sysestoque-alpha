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
    public partial class FormProdutos : Form
    {
        ICollection<Produto> ListaProduto = new List<Produto>();

        Produto produto = new Produto();

        BindingSource BindingSourceProduto = new BindingSource();

        public FormProdutos()
        {
            InitializeComponent();

            teladedadosprod.AutoGenerateColumns = false;

            using (var db = new EstoqueContext())
            {



                ListaProduto = db.Produto.ToList();
                BindingSourceProduto.DataSource = ListaProduto;
                teladedadosprod.DataSource = BindingSourceProduto;



            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            produto.Id = null;
            produto.Nome = tbxNome.Text;
            produto.UnidadeMedidaId = 1; //Valor provisódio que deverá vir de um combobox
            produto.CategoriaId = 1; //Valor provisódio que deverá vir de um combobox
            produto.EstoqueMax = float.Parse(txbmax.Text);
            produto.EstoqueMin = float.Parse(txbmin.Text);
            produto.Estoque = 0;

            using (var db = new EstoqueContext())
            {
                db.Produto.Add(produto);
                db.SaveChanges();

                ListaProduto = db.Produto.ToList();

                BindingSourceProduto.DataSource = ListaProduto;

            }
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {

            if (teladedadosprod.SelectedRows.Count > 0)
            {

                produto = teladedadosprod.SelectedRows[0].DataBoundItem as Produto;

                BindingSourceProduto.Remove(produto);

                using (var db = new EstoqueContext())
                {
                    db.Produto.Remove(produto);
                    db.SaveChanges();

                }

            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void comboxcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {

        }

        private void barratextunidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void unidademedidatext_Click(object sender, EventArgs e)
        {

        }

        private void tbxNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
