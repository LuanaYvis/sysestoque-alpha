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

            using (var db = new EstoqueContext())
            {

                ListaProduto = db.Produto.ToList();

                BindingSourceProduto.DataSource = produto;

                teladedadosprod.DataSource = BindingSourceProduto;



            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

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
    }
}
