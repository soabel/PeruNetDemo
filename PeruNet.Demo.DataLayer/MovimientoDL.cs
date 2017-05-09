using PeruNet.Demo.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.DataLayer
{
    public class MovimientoDL
    {
        public void RegistrarIngreso(MovimientoBE movimiento)
        {   
            Console.WriteLine("Se registro un ingreso");
        }

        public void RegistrarSalida(MovimientoBE movimiento)
        {
            Console.WriteLine("Se registro una salida");
        }

        
    }
}
