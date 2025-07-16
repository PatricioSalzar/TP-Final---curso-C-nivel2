using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Dominio_TP
{
    public class Articulo
    {
        public int Id { get; set; }
        [DisplayName("Codigo de articulo")]
        public string CodArt {  get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripcíon")]
        public string Descripcion { get; set; }
        public string Imagen {  get; set; }
        public decimal Precio { get; set; }
        public Marca Marca_articulo { get; set; }
        public Categoria Categoria_articulo { get; set; }
    }
}
//// a ver si anda el repositorio -_-.....
/// ahora el lo vuelvo a comprobar por que cre una rama por las dudas