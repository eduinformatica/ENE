using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaLogica;

namespace ENE
{
    public partial class ListaDeRequerimientos : Form
    {
        TipoRequerimiento tipoRequerimiento = new TipoRequerimiento();
        Prioridad prioridad = new Prioridad();
        Requerimiento requerimiento = new Requerimiento(); //Registar Requerimientos

        public ListaDeRequerimientos()
        {
            InitializeComponent();
        }

        private void ListaDeRequerimientos_Load(object sender, EventArgs e)
        {
            ListarTipoRequerimientos();
            ListarPrioridad();
        }




        #region Metodos y Funciones Propias
        private void ListarPrioridad()
        {
            cbxReadPrioridad.DisplayMember = "nombrePrioridad";
            cbxReadPrioridad.ValueMember = "idprioridad";
            cbxReadPrioridad.DataSource = prioridad.ListPrioridad();
        }
        private void ListarTipoRequerimientos()
        {
            cbxReadRequerimiento.DisplayMember = "nombre";
            cbxReadRequerimiento.ValueMember = "idtipoRequerimiento";
            cbxReadRequerimiento.DataSource = tipoRequerimiento.listTipoRequermiento();
        }

        public void eliminarRequerimiento()
        {
            StringBuilder sb = new StringBuilder();
            DialogResult alert = MessageBox.Show("Desea Eliminar el requerimiento??", "Eliminar Requerimeinto", MessageBoxButtons.YesNoCancel);
            //Deberia ir en la capa logica segun el profe
            if (alert == DialogResult.Yes && dgDetalleRequerimientos.CurrentRow.Cells != null)
            {
                foreach (DataGridViewCell item in dgDetalleRequerimientos.CurrentRow.Cells)
                {
                    sb.Append(" " + item.Value.ToString());
                }

                String[] fila = sb.ToString().Split(' ');
                requerimiento.id = int.Parse(fila[1]);
                String msj;
                msj = requerimiento.DeleteRequerimiento();

                MessageBox.Show(msj, "Exito Eliminar Requermiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarRequerimiento();
        }
    }
}
