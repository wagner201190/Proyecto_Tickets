//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Tickets
{
    using System;
    using System.Collections.Generic;
    
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            this.INCIDENTE = new HashSet<INCIDENTE>();
        }
    
        public int ID_USUARIO { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string CEDULA { get; set; }
        public string CORREO { get; set; }
        public string DIRECCION { get; set; }
        public string CLAVE { get; set; }
        public int ID_DEPARTAMENTO { get; set; }
        public int ID_ROL { get; set; }
    
        public virtual DEPARTAMENTO DEPARTAMENTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INCIDENTE> INCIDENTE { get; set; }
        public virtual ROL ROL { get; set; }
    }
}
