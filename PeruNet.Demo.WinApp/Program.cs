using PeruNet.Demo.BusinessEntity;
using PeruNet.Demo.BusinessLayer;
using PeruNet.Demo.BusinessLayer.Contracts;
using PeruNet.Demo.DataLayer;
using PeruNet.Demo.DataLayer.Contracts;
using PeruNet.Demo.DataLayer.DataAccess;
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
        private static IMovimientoBL movimientoBL;
        private static ILogManager logManager;
        static void Main(string[] args)
        {
            StarUp();

            Console.WriteLine("Registrando un ingreso a almacén..Press any Key.");
            Console.ReadKey();

            RegistrarIngreso();

            Console.WriteLine("Registrando una salida de almacén..Press any Key.");
            Console.ReadKey();

            RegistrarSalida();

            Console.ReadKey();
        }

        static void StarUp() {
            //Reemplazar con framework IoC
            IDataAccess dataAccess = new SQLServerDataAccess();
            IMovimientoDL movimientoDL = new MovimientoDL(dataAccess);
            IProductoDL productoDL = new ProductoDL(dataAccess);

            movimientoBL = new MovimientoBL(movimientoDL, productoDL);
            logManager = new LogManager();
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
                logManager.Error(ex);
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
                logManager.Error(ex);
            }

        }



    }
}
