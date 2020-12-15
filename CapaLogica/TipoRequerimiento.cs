using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using System.Data;

namespace CapaLogica
{
    public class TipoRequerimiento
    {
        Manejador manejador = new Manejador();

        #region Atributos
        private int idtipoRequerimiento;
        private String nombre;
        #endregion

        #region Constructor Vacio
        public TipoRequerimiento()
        {
        }
        #endregion

        #region Getters y Setters
        public int getIdTipoRequerimiento()
        {
            return idtipoRequerimiento;
        }
        public void setIdTipoRequerimiento(int idtipoRequerimiento) 
        {
            this.idtipoRequerimiento = idtipoRequerimiento;
        }

        public String getNombe()
        {
            return nombre;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        #endregion


        #region Metodos y Funciones
        public DataTable listTipoRequermiento()
        {
            return manejador.ListShow("TipoRequerimiento", null);
        }
        #endregion
    }
}
