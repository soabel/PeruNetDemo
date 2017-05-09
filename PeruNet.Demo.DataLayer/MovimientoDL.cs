using PeruNet.Demo.BusinessEntity;
using PeruNet.Demo.DataLayer.Contracts;
using PeruNet.Demo.DataLayer.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.DataLayer
{
    public class MovimientoDL: IMovimientoDL
    {
        IDataAccess dataAccess;
        public MovimientoDL(IDataAccess dataAccess) {
            this.dataAccess = dataAccess;
        }

        public void RegistrarIngreso(MovimientoBE ingreso)
        {   
            Console.WriteLine("Se registro un ingreso");
            this.dataAccess.ExecuteNonQuery("Almacen.RegistrarMovimiento", new { });
        }

        public void RegistrarSalida(MovimientoBE salida)
        {
            Console.WriteLine("Se registro una salida");
            this.dataAccess.ExecuteNonQuery("Almacen.RegistrarMovimiento", new { });
        }

        
    }
}
