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
    public partial class unidadedemediaforms : Form
    {
        ICollection<UnidadeMedida> listaUnidadeMedida = new List<UnidadeMedida>();

        UnidadeMedida unidademedida = new UnidadeMedida();
       
        BindingSource BindingSourceUnidadeMedida = new BindingSource();

        public unidadedemediaforms()
        {
            InitializeComponent();
            using (var db = new EstoqueContext())
            {
                listaUnidadeMedida = db.UnidadeMedida.ToList();

                BindingSourceUnidadeMedida.DataSource = unidademedida;

                teladedadosUM.DataSource = BindingSourceUnidadeMedida;
            }
        }


        private void teladedadosUM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bntExcluir_Click(object sender, EventArgs e){

            if(teladedadosUM.SelectedRows.Count > 0)
            {
                unidademedida = teladedadosUM.SelectedRows[0].DataBoundItem as UnidadeMedida;

                BindingSourceUnidadeMedida.Remove(unidademedida);

                using(var db = new EstoqueContext())
                {
                    db.UnidadeMedida.Remove(unidademedida);
                    db.SaveChanges();

                }
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
