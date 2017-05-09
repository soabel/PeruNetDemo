namespace PeruNet.Demo.DataLayer
{
    using PeruNet.Demo.BusinessEntity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class ProductoDL
    {
        private static List<ProductoBE>  listaBaseProductos = new List<ProductoBE>();

        public ProductoDL() {
            //Inicializar lsita de productos
            listaBaseProductos.Add(new ProductoBE() { Id = 1, Descripcion = "Lapicero Faber Castell 035 Azul", Precio = 1.5M, StockActual = 50 });
            listaBaseProductos.Add(new ProductoBE() { Id = 2, Descripcion = "Cartucheran para utiles", Precio = 10M, StockActual = 10 });
            listaBaseProductos.Add(new ProductoBE() { Id = 3, Descripcion = "Libro coquito Primer grado", Precio = 20M, StockActual = 5 });
            listaBaseProductos.Add(new ProductoBE() { Id = 4, Descripcion = "Vinifan cuadernos", Precio = 1.5M, StockActual = 200 });

        }
        public void IncrementarStock(ProductoBE producto, int cantidad) {
            producto.StockActual += cantidad;
            Console.WriteLine("Se incrementó el stock en {0}. Nuevo Stock: {1}", cantidad, producto.StockActual);
        }
        public void DisminuirStock(ProductoBE producto, int cantidad)
        {
            producto.StockActual -= cantidad;
            Console.WriteLine("Se disminuyó el stock en {0}. Nuevo Stock: {1}", cantidad, producto.StockActual);
        }

        public ProductoBE ObtenerProducto(int idProducto) {

            var producto = listaBaseProductos.Where(x => x.Id == idProducto).FirstOrDefault();
            return producto;

        }
    }
}
