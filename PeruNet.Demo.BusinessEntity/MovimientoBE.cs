using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.BusinessEntity
{
    public class MovimientoBE
    {
        public MovimientoBE() {
            this.Detalle = new List<MovimientoDetalleBE>();
        }
        public int Id { get; set; }
        public string RUC { get; set; }
        public string Proveedor { get; set; }
        public DateTime FechaIngreso { get; set; }
        public ICollection<MovimientoDetalleBE> Detalle { get; set; }
    }


}
