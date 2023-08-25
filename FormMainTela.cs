using Microsoft.EntityFrameworkCore;
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
    public partial class FormMainTela : Form
    {

        ICollection<Produto> ListaProduto = new List<Produto>();

        Produto produto = new Produto();

        BindingSource BindingSourceProduto = new BindingSource();

        public FormMainTela()
        {
            InitializeComponent();
            dgvsis.AutoGenerateColumns = false;

            using (var db = new EstoqueContext())
            {

                ListaProduto = db.Produto
                                .Include(p => p.Categoria)
                                .Include(p => p.UnidadeMedida)
                                .Include(p => p.Fornecedor)
                                .ToList();

                BindingSourceProduto.DataSource = ListaProduto;
                dgvsis.DataSource = BindingSourceProduto;

            }
        }

        private void adicionarFonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adicionarNotaDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvsis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvsis_Click(object sender, EventArgs e)
        {
            if (dgvsis.SelectedRows.Count > 0 ){
                produto = dgvsis.SelectedRows[0].DataBoundItem as Produto;
                 
                txtestmi.Text = produto.EstoqueMin.ToString();
                txtestme.Text = produto.EstoqueMedio.ToString();
                txtEstma.Text = produto.EstoqueMax.ToString();  

            }
        }
    }
}
