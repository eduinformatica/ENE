using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class Parametros
    {
        #region Parametros
        public String vName { get; set; }
        public Object vValue { get; set; }
        public SqlDbType typeOfData { get; set; }
        public Int32 vSize { get; set; }
        public ParameterDirection directionParameter { get; set; }
        #endregion


        #region Contructor de Entrada [El que envia los datos] {Envia}
        public Parametros(String vName, Object vValue) 
        {
            this.vName = vName;
            this.vValue = vValue;
            this.directionParameter = ParameterDirection.Input;
        }
        #endregion


        #region Contructores de Salida [El que recibe los datos] {Retorna}
        public Parametros(String vName, SqlDbType typeOfData, int vSize)
        {
            this.vName = vName;
            this.typeOfData = typeOfData;
            this.vSize = vSize;
            this.directionParameter = ParameterDirection.Output;
        }

        public Parametros(String vName, Object vValue, SqlDbType typeOfData, ParameterDirection Direccion, int vSize)
        {
            this.vName = vName;
            this.vValue = vValue;
            this.typeOfData = typeOfData;
            this.directionParameter = Direccion;
            this.vSize = vSize;
        }
        #endregion
    }
}
