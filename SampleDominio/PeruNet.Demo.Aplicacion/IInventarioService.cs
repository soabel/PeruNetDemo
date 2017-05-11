using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.Aplicacion
{
  public interface IInventarioService
  {
    void RegistrarIngreso(int idAlmacen, IngresoDto ingreso);
  }
}
