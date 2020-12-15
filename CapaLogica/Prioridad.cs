using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;
using System.Data;

namespace CapaLogica
{
    public class Prioridad
    {
        Manejador manejador = new Manejador();

        #region Atributos
        private int idprioridad;
        private String nombrePerfil;
        #endregion

        #region Constructor Vacio
        public Prioridad()
        {
            
        }
        #endregion

        #region Getters y Setters
        public int getIdPrioridad() 
        {
            return idprioridad;
        }
        public void setIdPrioridad(int idprioridad) 
        {
            this.idprioridad = idprioridad;
        }

        public String getNombrePerfil()
        {
            return nombrePerfil;
        }
        public void setNombrePrioridad(String nombrePerfil)
        {
            this.nombrePerfil = nombrePerfil;
        }
        #endregion


        #region Metodos y Funciones
        public DataTable ListPrioridad()
        {
            return manejador.ListShow("ListarPrioridad", null);
        }
        #endregion
    }
}
