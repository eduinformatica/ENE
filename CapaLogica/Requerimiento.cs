using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using System.Data;

namespace CapaLogica
{
    public class Requerimiento
    {
        #region Atributos
        public int id { get; set; } //id requerimiento
        public DateTime fecha { get; set; }
        public int usuarioAsignante { get; set; }
        public int usuarioAsignado { get; set; }
        public int prioridad { get; set; }
        public int tipoRequerimiento { get; set; }
        public int estado { get; set; }
        public String descripcion { get; set; }
        #endregion

        Manejador manejador = new Manejador();

        public String RegistrarRequerimiento()
        {
            String sms = "";
            List<Parametros> list = new List<Parametros>();

            try
            {
                //Parametros de entradas (que van a la BD)
                list.Add(new Parametros("@fechaRequerimiento", fecha));
                list.Add(new Parametros("@usuarioAsignante", usuarioAsignante));
                list.Add(new Parametros("@usuarioAsignado", usuarioAsignado));
                list.Add(new Parametros("@prioridad_idprioridad", prioridad));
                list.Add(new Parametros("@tipoRequerimiento_idtipoRequerimiento", tipoRequerimiento));
                list.Add(new Parametros("@estado", estado));
                list.Add(new Parametros("@descripcion", descripcion));

                //Parametros de salida (que retorna el procedimiento almacenado)
                //list.Add(new Parametros("@sms", SqlDbType.VarChar, 100));
                list.Add(new Parametros("@sms", "", SqlDbType.VarChar, ParameterDirection.Output, 100));

                manejador.ExecuteStoredProcedure("RegistrarRequerimiento", list);
                sms = list[7].vValue.ToString();
            }
            catch (Exception)
            {
                throw;
            }

            return sms;
        }


        public DataTable ListRequerimientos(int idusuario = 0)
        {
            List<Parametros> list = new List<Parametros>();
            list.Add(new Parametros("@idusuario", idusuario));

            return manejador.ListShow("ListRequerimiento", list);
        }


        public String UpdateStatusRequerimiento()
        {
            return "";
        }

        public String DeleteRequerimiento()
        {
            return "";
        }
    }
}
