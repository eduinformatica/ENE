using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class Manejador
    {
        #region Apertura y Cierre de Conexion
        SqlConnection conexion = new SqlConnection("Server=.;Database=ene; Integrated Security=True");

        private void OpenConexion() {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
        }

        private void CloseConexion() {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }
        #endregion





        #region Metodos y Funciones 
        public void ExecuteStoredProcedure(String nameProcedure, List<Parametros> lst) {
            SqlCommand cmd;

            try
            {
                OpenConexion();
                cmd = new SqlCommand(nameProcedure, conexion);
                //Especificamos que es lo que vamos a ejecutar (Stored Procedure)
                cmd.CommandType = CommandType.StoredProcedure;

                //Validamos que la lista de parametros no venga vacia
                if (lst != null)
                {
                    //Enviamos los datos
                    for (int i = 0; i < lst.Count; i++)
                    {
                        //Direccion de entrada
                        if (lst[i].directionParameter == ParameterDirection.Input) {
                            cmd.Parameters.AddWithValue(lst[i].vName, lst[i].vValue);
                        }
                        
                        //Direccion de salida
                        if (lst[i].directionParameter == ParameterDirection.Output)
                        {
                            cmd.Parameters.Add(lst[i].vName, lst[i].typeOfData, lst[i].vSize).Direction = ParameterDirection.Output;
                        }
                    }
                }
                else {
                    MessageBox.Show("Error DG-01, No existen argumentos a enviar", "!Aviso ENE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                cmd.ExecuteNonQuery();

                //Recibiendo los datos
                //Tomamos la respuesta, al parametro vValue, asignale lo que te retorne la respuesta
                for (int i = 0; i < lst.Count; i++) {
                    if (cmd.Parameters[i].Direction == ParameterDirection.Output) {
                        lst[i].vValue = cmd.Parameters[i].Value.ToString();
                    }
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Error: "+ex.Message, "!Aviso importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw ex;
            }
            CloseConexion();
        }


        public DataTable ListShow(String nameProcedure, List<Parametros> lst) {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter;

            try
            {
                dataAdapter = new SqlDataAdapter(nameProcedure, conexion);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++) {
                        dataAdapter.SelectCommand.Parameters.AddWithValue(lst[i].vName, lst[i].vValue);
                    }
                }
                else
                {
                    //Este mensaje sale cuando iniciamos session en si, siendo que llama al procedimiento almacencado
                    //MessageBox.Show("Error DG-02, No existen argumentos a enviar", "!Aviso ENE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                dataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "!Aviso importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
        #endregion
    }
}
