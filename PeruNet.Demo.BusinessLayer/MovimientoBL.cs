using PeruNet.Demo.BusinessEntity;
using PeruNet.Demo.BusinessLayer.Contracts;
using PeruNet.Demo.DataLayer;
using PeruNet.Demo.DataLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.BusinessLayer
{
    public class MovimientoBL: IMovimientoBL
    {
        IMovimientoDL movimientoDL;
        IProductoDL productoDL;
        public MovimientoBL(IMovimientoDL movimientoDL, IProductoDL productoDL) {
            this.movimientoDL = movimientoDL;
            this.productoDL = productoDL;
        }
        public void RegistrarIngreso(MovimientoBE ingreso) {
            this.movimientoDL.RegistrarIngreso(ingreso);

            foreach (var detalle in ingreso.Detalle)
            {
                var producto = productoDL.ObtenerProducto(detalle.Producto.Id);

                this.productoDL.IncrementarStock(producto, detalle.Cantidad);
            }
        }

        public void RegistrarSalida(MovimientoBE salida) {
            if (ValidarSalida(salida)) {
                this.movimientoDL.RegistrarSalida(salida);

                foreach (var detalle in salida.Detalle)
                {
                    var producto = productoDL.ObtenerProducto(detalle.Producto.Id);
                    this.productoDL.DisminuirStock(producto, detalle.Cantidad);
                }                
            }
        }

        private bool ValidarSalida(MovimientoBE salida) {
            bool resultado=true;

            foreach (var detalle in salida.Detalle)
            {
                var producto = productoDL.ObtenerProducto(detalle.Producto.Id);

                if (!this.ValidarStock(producto, detalle.Cantidad))
                {
                    resultado = false;
                    break;
                }
            }

            return resultado;
        }
        
        private bool ValidarStock(ProductoBE producto, int cantidad) {
            return (producto.StockActual - cantidad) >= 0;
        }

    }
}
