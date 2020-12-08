using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CapaNegocio;
using CapaLogica;

namespace ENE
{
    public partial class RegistroRequerimiento : Form
    {
        //Requerimiento requerimiento = new Requerimiento();
        Usuario usuario = new Usuario();
        //Prioridad prioridad = new Prioridad();
        int vProfile, vUsuario;

        List<int> indice = new List<int>();

        //TipoRequerimiento tipoRequerimiento = new TipoRequerimiento();

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

        private void btnListRequerimiento_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            ListaDeRequerimientos frmListaDeRequerimiento = new ListaDeRequerimientos();
            frmListaDeRequerimiento.ShowDialog();
        }
    }
}
