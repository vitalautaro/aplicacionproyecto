﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacionproyecto
{
    public class Producto
    {
        private int _id;
        private string _descripcion;
        private double _costo;
        private double _precioVenta;
        private int _stock;
        private int _usuarioId;

        public Producto(int id, string descripcion, double costo,
            double precioVenta, int stock, int idUsuario)
        {
            _id = id;
            _descripcion = descripcion;
            _costo = costo;
            _precioVenta = precioVenta;
            _stock = stock;
            _usuarioId = idUsuario;
        }

        public int Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public double Costo { get => _costo; set => _costo = value; }
        public double PrecioVenta { get => _precioVenta; set => _precioVenta = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public int usuarioId { get => _usuarioId; set => _usuarioId = value; }

        public string MostrarDatos()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Producto: {this.Descripcion} \n");
            sb.AppendLine($"Stock: {this.Stock} \n");
            sb.AppendLine($"Precio de Venta: {this.PrecioVenta} \n");
            return sb.ToString();
        }

    }

}