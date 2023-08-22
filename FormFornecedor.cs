using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using sysestoque_alpha.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysestoque_alpha
{


    public partial class FormFornecedor : Form
    {


        ICollection<Fornecedor> listaFornecedores = new List<Fornecedor>();
        Fornecedor fornecedor = new Fornecedor();
        BindingSource BindingSourceFornecedor = new BindingSource();

        private bool EstaAtualizando = false;


        public FormFornecedor()
        {

            InitializeComponent();
            using (var db = new EstoqueContext())
            {

                listaFornecedores = db.Fornecedor.ToList();

                BindingSourceFornecedor.DataSource = listaFornecedores;

                dgvFornecedor.DataSource = BindingSourceFornecedor;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormFornecedor_Load(object sender, EventArgs e)
        {





        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            if (dgvFornecedor.SelectedRows.Count > 0)
            {

                fornecedor = dgvFornecedor.SelectedRows[0].DataBoundItem as Fornecedor;

                BindingSourceFornecedor.Remove(fornecedor);

                using (var db = new EstoqueContext())
                {

                    db.Fornecedor.Remove(fornecedor);
                    db.SaveChanges();

                }

            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (EstaAtualizando)
            {
                fornecedor.cnpj = textCNPJ.Text;
                fornecedor.Nome = textnome.Text;
                fornecedor.endereco = textendereco.Text;
                fornecedor.fone = textfone.Text;
                fornecedor.email = textemail.Text;

                using (var db = new EstoqueContext())
                {
                    db.Fornecedor.Update(fornecedor);
                    db.SaveChanges();

                    listaFornecedores = db.Fornecedor.ToList();
                    BindingSourceFornecedor.DataSource = listaFornecedores;

                    dgvFornecedor.DataSource = BindingSourceFornecedor;

                    dgvFornecedor.Refresh();

                }


            }
            else
            {
                fornecedor.cnpj = textCNPJ.Text;
                fornecedor.Nome = textnome.Text;
                fornecedor.endereco = textendereco.Text;
                fornecedor.fone = textfone.Text;
                fornecedor.email = textemail.Text;

                using (var db = new EstoqueContext())
                {

                    db.Fornecedor.Add(fornecedor);
                    db.SaveChanges();

                    listaFornecedores = db.Fornecedor.ToList();
                    BindingSourceFornecedor.DataSource = listaFornecedores;

                    dgvFornecedor.DataSource = BindingSourceFornecedor;

                    dgvFornecedor.Refresh();

                }
            }
        }


        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            fornecedor = dgvFornecedor.SelectedRows[0].DataBoundItem as Fornecedor;

            textCNPJ.Text = fornecedor.cnpj;
            textnome.Text = fornecedor.Nome;
            textendereco.Text = fornecedor.endereco;
            textfone.Text = fornecedor.fone;
            textemail.Text = fornecedor.email;

            EstaAtualizando = true;
        }
    }
}

