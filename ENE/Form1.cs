using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ENE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String inpUsuario = "dgomez";
            String inpClave = "123456";

            if (!txtUsuario.Text.Equals("") && !txtPassword.Text.Equals(""))
            {
                if (txtUsuario.Text.Equals(inpUsuario) && txtPassword.Text.Equals(inpClave))
                {
                    btnIngresar.Text = "Ingresando...";
                }
                else
                {
                    MessageBox.Show("!!Usuario y Contraseñas Incorrectas", "ENE - INSTITUTO AIEP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("** Todos los campos deben ser llenados", "ENE - INSTITUTO AIEP", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }


}