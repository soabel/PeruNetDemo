using PeruNet.Demo.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeruNet.Demo.DataLayer.Contracts
{
    public interface IProductoDL
    {
        void IncrementarStock(ProductoBE producto, int cantidad);
        void DisminuirStock(ProductoBE producto, int cantidad);
        ProductoBE ObtenerProducto(int idProducto);
    }
}
