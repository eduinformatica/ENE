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
        public String SesionInit() {
            List<Parametros> lst = new List<Parametros>();
            String vMessage = "";
            String vProfile = "";
            String vUsuario = "";

            try
            {
                lst.Add(new Parametros("@rut", rut));
                lst.Add(new Parametros("@clave", clave));

                lst.Add(new Parametros("@sms", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                lst.Add(new Parametros("@idperfil", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                lst.Add(new Parametros("@isUsuario", "", SqlDbType.VarChar, ParameterDirection.Output, 5));
                manejador.ExecuteStoredProcedure("SesionInit", lst);
                vMessage = lst[2].vValue.ToString();
                vProfile = lst[3].vValue.ToString();
                vUsuario = lst[4].vValue.ToString();

                return $"{vMessage}&{vProfile}&{vUsuario}";
            }
            catch (Exception ex)
            {
                vMessage = ex.Message;
                return "";
            }

        }
        #endregion
    }
}
