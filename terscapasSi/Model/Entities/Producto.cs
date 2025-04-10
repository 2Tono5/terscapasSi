using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terscapasSi.Model.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CodigoBarras { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Categoria { get; set; }
        public int Stock { get; set; }

    }
}
