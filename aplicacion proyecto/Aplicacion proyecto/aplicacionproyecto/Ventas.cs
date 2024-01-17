using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacionproyecto
{
    public class Venta
    {
        private int _id;
        private string _comentarios;
        private int _usuarioId;

        public Venta(int id, string comentarios, int usuarioId)
        {
            _id = id;
            _comentarios = comentarios;
            _usuarioId = usuarioId;
        }

        public int Id { get => _id; set => _id = value; }
        public string Comentarios { get => _comentarios; set => _comentarios = value; }
        public int usuarioId { get => _usuarioId; set => _usuarioId = value; }
    }
}