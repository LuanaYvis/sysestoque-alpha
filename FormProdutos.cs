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

namespace sysestoque_alpha{
    public partial class FormProdutos : Form{
        ICollection<Produto> Produto = new List<Produto>(); 
        BindingSource BindingSourceProduto = new BindingSource();

        public FormProdutos()
        {
            InitializeComponent();

            using (var db = new EstoqueContext()){

                Produto = db.Produto.ToList();
                
                BindingSourceProduto.DataSource = Produto;

                teladedados.DataSource = BindingSourceProduto;



            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
