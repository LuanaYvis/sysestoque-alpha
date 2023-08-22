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


                //combo box 

                cbxcat.DataSource = db.Categoria.ToList();
                cbxcat.DisplayMember = "Categoria";
                cbxcat.ValueMember = "Id";
                cbxcat.SelectedIndex = -1;


                cbxUM.DataSource = db.UnidadeMedida.ToList();
                cbxUM.DisplayMember = "Unidade de Medida";
                cbxUM.ValueMember = "id";
                cbxUM.SelectedIndex = -1;


                //Lista de Produtos

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

                var result = MessageBox.Show(" Você deseja mesmo excluir permanentemente essa infromação ? ",
                                                    "Excluir",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    // Execute a lógica  de acordo com a resposta
                }

                produto = teladedadosprod.SelectedRows[0].DataBoundItem as Produto;

                //Remove a categoriado datagridview

                BindingSourceProduto.Remove(produto);

                // Remove da Banco de Dados
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

        private void cbxUM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
