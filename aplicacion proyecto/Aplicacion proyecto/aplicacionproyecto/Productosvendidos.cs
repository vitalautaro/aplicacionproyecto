using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacionproyecto
{
    public class ProductoVendido
    {
        private int _id;
        private int _idProducto;
        private int _stock;
        private int _ventaId;

        public ProductoVendido(int id, int idProducto, int stock, int ventaId)
        {
            _id = id;
            _idProducto = idProducto;
            _stock = stock;
            _ventaId = ventaId;
        }

        public int Id { get => _id; set => _id = value; }
        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public int VentaId { get => _ventaId; set => _ventaId = value; }
    }
}