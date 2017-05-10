using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.Aplicacion
{
  public class IngresoDto
  {
    public string Ruc { get; set; }
    public string Proveedor { get; set; }
    public DateTime Fecha { get; set; }
    public IList<IngresoDetalleDto> Detalles { get; set; }
  }

  public class IngresoDetalleDto
  {
    public int IdProducto { get; set; }
    public decimal Cantidad { get; set; }
    public decimal Precio { get; set; }
  }
}
