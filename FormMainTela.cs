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
    public partial class FormMainTela : Form{

        ICollection<Produto> ListaProduto = new List<Produto>();
        
        public FormMainTela()
        {
            InitializeComponent();
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
            using (var db = new EstoqueContext()){

                db.Produto.Add(produto);
                db.SaveChanges();

                ListaProduto = db.Produto.ToList();

                BindingSourceProduto.DataSource = ListaProduto;
                dgvsis.DataSource = BindingSourceProduto;
                dgvsis.Refresh();
            }
        }
    }
}
