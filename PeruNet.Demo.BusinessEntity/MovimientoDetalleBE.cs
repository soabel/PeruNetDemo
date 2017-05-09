using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.BusinessEntity
{
    public class MovimientoDetalleBE
    {
        public MovimientoDetalleBE() {
            this.Producto = new ProductoBE();
        }
        public int Id { get; set; }
        public ProductoBE Producto { get; set; }
        public int Cantidad { get; set; }
    }
}
