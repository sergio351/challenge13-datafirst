//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Challenge13Datafirst__.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class Caracteristica
    {
        public int Id { get; set; }
        public Nullable<int> ProductoID { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> Ancho { get; set; }
        public Nullable<decimal> Largo { get; set; }
        public Nullable<decimal> Peso { get; set; }
    
        public virtual Producto Producto { get; set; }
    }
}
