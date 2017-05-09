using PeruNet.Demo.BusinessEntity;
using PeruNet.Demo.BusinessLayer;
using PeruNet.Demo.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.WinApp
{
    class Program
    {
        private static MovimientoBL movimientoBL;
        static void Main(string[] args)
        {

            movimientoBL = new MovimientoBL();

            Console.WriteLine("Registrando un ingreso a almacén..Press any Key.");
            Console.ReadKey();

            RegistrarIngreso();

            Console.WriteLine("Registrando una salida de almacén..Press any Key.");
            Console.ReadKey();

            RegistrarSalida();

            Console.ReadKey();
        }

        static void RegistrarIngreso() {
            try
            {
                MovimientoBE movimiento = new MovimientoBE() {
                    Id=1,
                    FechaIngreso= DateTime.Now,
                    Proveedor="Mayorista A",
                    RUC="55555555555"
                };

                movimiento.Detalle.Add(new MovimientoDetalleBE() { Id=1, Cantidad=10, Producto= new ProductoBE() { Id=1 } });

                movimientoBL.RegistrarIngreso(movimiento);
            }
            catch (Exception ex)
            {
                LogManager.RegistrarLog(ex);
            }
           
            
        }

        static void RegistrarSalida() {
            try
            {
                MovimientoBE movimiento = new MovimientoBE()
                {
                    Id = 1,
                    FechaIngreso = DateTime.Now,
                    Proveedor = "Mayorista A",
                    RUC = "55555555555"
                };

                movimiento.Detalle.Add(new MovimientoDetalleBE() { Id = 1, Cantidad = 10, Producto = new ProductoBE() { Id = 1 } });

                movimientoBL.RegistrarSalida(movimiento);
            }
            catch (Exception ex)
            {
                LogManager.RegistrarLog(ex);
            }

        }



    }
}
