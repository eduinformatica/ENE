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
    public partial class RegistroRequerimiento : Form
    {
        Usuario usuario = new Usuario();
        TipoRequerimiento tipoRequerimiento = new TipoRequerimiento();
        Prioridad prioridad = new Prioridad();
        Requerimiento requerimiento = new Requerimiento(); //Registar Requerimientos
        int vProfile, vUsuario;

        List<int> indice = new List<int>();

        public RegistroRequerimiento()
        {
            InitializeComponent();
        }

        public RegistroRequerimiento(String typeUser, String vUsuario)
        {
            InitializeComponent();
            this.vProfile = int.Parse(typeUser);
            this.vUsuario = int.Parse(vUsuario);
        }

        private void RegistroRequerimiento_Load(object sender, EventArgs e)
        {
            ListarTipoRequerimientos();
            ListarPrioridad();
            ListarDestinatarios();
        }

        private void btnListRequerimiento_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            ListaDeRequerimientos frmListaDeRequerimiento = new ListaDeRequerimientos();
            frmListaDeRequerimiento.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String mensaje = "";
            try {
                if (cbxAsignacion.SelectedIndex != 0 && cbxPrioridad.SelectedIndex != 0 && cbxTipoRequerimientos.SelectedIndex != 0)
                {
                    requerimiento.fecha = DateTime.Today;
                    requerimiento.usuarioAsignante = vUsuario; //idusuario
                    requerimiento.usuarioAsignado = indice[cbxAsignacion.SelectedIndex];
                    requerimiento.prioridad = cbxPrioridad.SelectedIndex;
                    requerimiento.tipoRequerimiento = cbxTipoRequerimientos.SelectedIndex;
                    requerimiento.estado = 1;
                    requerimiento.descripcion = txaDescripcionRequerimiento.Text;

                    mensaje = requerimiento.RegistrarRequerimiento();
                    MessageBox.Show("El requerimiento fue ingresado, el plazo para resolverlo es de "+mensaje+" dias", "!!Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Limpiamos los campos por cada requerimiento ingresado a la base de datos
                    cbxAsignacion.SelectedIndex = 0;
                    cbxPrioridad.SelectedIndex = 0;
                    cbxTipoRequerimientos.SelectedIndex = 0;
                    txaDescripcionRequerimiento.Text = "";
                }
                else {
                    MessageBox.Show("** Todos los campos son obligatorios..", "Warning Registro Requerimiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch (Exception ex) 
            {
                MessageBox.Show("Error " + ex.Message, "!!Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #region Metodos y Funciones Propias
        private void ListarPrioridad()
        {
            cbxPrioridad.DisplayMember = "nombrePrioridad";
            cbxPrioridad.ValueMember = "idprioridad";
            cbxPrioridad.DataSource = prioridad.ListPrioridad();
        }
        private void ListarTipoRequerimientos()
        {
            cbxTipoRequerimientos.DisplayMember = "nombre";
            cbxTipoRequerimientos.ValueMember = "idtipoRequerimiento";
            cbxTipoRequerimientos.DataSource = tipoRequerimiento.listTipoRequermiento();
        }

        private void btnClearCampos_Click(object sender, EventArgs e)
        {
            cbxAsignacion.SelectedIndex = 0;
            cbxPrioridad.SelectedIndex = 0;
            cbxTipoRequerimientos.SelectedIndex = 0;
            txaDescripcionRequerimiento.Text = "";
        }

        private void ListarDestinatarios()
        {
            cbxAsignacion.ValueMember = "idusuario";
            cbxAsignacion.DisplayMember = "usuarios";
            cbxAsignacion.DataSource = usuario.ListUsuarios(vUsuario); //idusuario

            DataTable data = usuario.ListUsuarios(vUsuario); //idusuario

            for (int i = 0; i < data.Rows.Count; i++)
            {
                indice.Add(int.Parse(data.Rows[i]["id"].ToString()));
            }
        }
        #endregion
    }
}
