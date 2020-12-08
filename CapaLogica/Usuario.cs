using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using System.Data;

namespace CapaLogica
{
    public class Usuario
    {
        Manejador manejador = new Manejador();

        #region Atributos
        public int idusuario { get; set; }
        public String rut { get; set; }
        public String apaterno { get; set; }
        public String amaterno { get; set; }
        public String clave { get; set; }
        public int perfil_idperfil { get; set; }
        #endregion


        #region Metodos y Funciones
        //Metodo para iniciar sesion
        public String Authentication() {
            List<Parametros> list = new List<Parametros>();
            String vMessage = "";
            String vProfile = "";
            String vUsuario = "";

            try
            {
                //Parametros de entrada, que recoje del formulario login para iniciar sesion
                list.Add(new Parametros("@rut", rut));
                list.Add(new Parametros("@clave", clave));
                
                //Parametros de salida, del procedimiento almecenado del SQLServer
                list.Add(new Parametros("@sms", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                list.Add(new Parametros("@idperfil", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                list.Add(new Parametros("@idusuario", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                manejador.ExecuteStoredProcedure("SesionInit", list);
                vMessage = list[2].vValue.ToString();
                vProfile = list[3].vValue.ToString();
                vUsuario = list[4].vValue.ToString();

                return $"{vMessage}&{vProfile}&{vUsuario}";
            }
            catch (Exception ex)
            {
                vMessage = ex.Message;
                //return "";
                return vMessage;
            }

        }
        #endregion
    }
}
