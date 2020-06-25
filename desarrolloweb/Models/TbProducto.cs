using System;
using System.Collections.Generic;

namespace desarrolloweb.Models
{
    public partial class TbProducto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Rate { get; set; }
        public string Img { get; set; }
        public byte Activo { get; set; }
    }
}
