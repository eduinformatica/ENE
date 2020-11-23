using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENE
{
    public partial class RegistroRequerimiento : Form
    {
        public RegistroRequerimiento()
        {
            InitializeComponent();
        }

        private void btnListRequerimiento_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            ListaDeRequerimientos frmListaDeRequerimiento = new ListaDeRequerimientos();
            frmListaDeRequerimiento.ShowDialog();
        }
    }
}
