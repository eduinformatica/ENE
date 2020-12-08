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
using CapaLogica;

namespace ENE
{
    public partial class Login : Form
    {
        Usuario usuario = new Usuario();
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!(txtRut.Text.Trim().Equals("")) && !(txtPassword.Text.Trim().Equals("")))
            {
                String message = "";

                usuario.rut = txtRut.Text;
                usuario.clave = txtPassword.Text;
                message = usuario.Authentication();
                String[] variables = message.Split('&');

                if (variables[0].Equals("Usuario y contraseña no válido")) //Se compara con el texto del mensaje en el procedimiento almacenado
                {
                    MessageBox.Show(variables[0], "!!Aviso importante.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtRut.Clear();
                    txtRut.Focus();
                    txtPassword.Clear();
                }
                else {
                    //RegistroRequerimiento registroRequerimiento = new RegistroRequerimiento(variables[1], variables[2]);
                    RegistroRequerimiento registroRequerimiento = new RegistroRequerimiento();
                    MessageBox.Show("Bienvenido Sr(a) "+ variables[0], "ENE - Rubro Sanitario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    registroRequerimiento.ShowDialog();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Por Favor Ingrese su Usuario y Contraseña.", "!!Aviso ENE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar)) //Habilito para borrar, lo que usuario escribe
            {
                e.Handled = false;
            }   
            else if (e.KeyChar.ToString().Equals("k") || e.KeyChar.ToString().Equals("K"))
                    {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}