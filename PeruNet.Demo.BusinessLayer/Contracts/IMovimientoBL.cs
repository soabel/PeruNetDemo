using PeruNet.Demo.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.BusinessLayer.Contracts
{
    public interface IMovimientoBL
    {
        void RegistrarIngreso(MovimientoBE ingreso);
        void RegistrarSalida(MovimientoBE salida);

    }
}
