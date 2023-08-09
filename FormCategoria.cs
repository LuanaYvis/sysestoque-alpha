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
    public partial class FormCategoria : Form
    {
        ICollection<Categoria> categoria = new List<Categoria>();
        BindingSource bindingSourceCategoria = new BindingSource();

        public FormCategoria(){

            InitializeComponent();

            using (var db = new EstoqueContext()){

                categoria = db.Categoria.ToList();

                bindingSourceCategoria.DataSource = categoria;

                dgvCategoria.DataSource = bindingSourceCategoria;

            }
        }

        private void Categoria_Load(object sender, EventArgs e)
        {

        }
    }
}
