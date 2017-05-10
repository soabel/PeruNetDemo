using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using PeruNet.Demo.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.Persistencia.NHibernate.Mapas
{
  public class MovimientoDetalleMapa: ClassMapping<MovimientoDetalle>
  {
    public MovimientoDetalleMapa()
    {
      Id(c => c.Id, a => a.Generator(Generators.Identity));
      ManyToOne(c => c.Producto, a => a.Column("IdProducto"));
      Property(c => c.Cantidad);
      Property(c => c.Precio);
      ManyToOne(c => c.Cabecera, a => a.Column("IdMovimiento"));
    }
  }
}
