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
        Categoria categoria = new Categoria();
        BindingSource bindingSourceCategoria = new BindingSource();

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

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (dgvCategoria.SelectedRows.Count > 0)
            {

                categoria = dgvCategoria.SelectedRows[0].DataBoundItem as Categoria;

                //Remove a categoria do DataGridView
                bindingSourceCategoria.Remove(categoria);

                //Remove do Banco de Dados
                using (var db = new EstoqueContext())
                {
                    db.Categoria.Remove(categoria);
                    db.SaveChanges();

                }

            }

        }
    }
}
