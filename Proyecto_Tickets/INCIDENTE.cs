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
    
    public partial class INCIDENTE
    {
        public int ID_INCIDENTE { get; set; }
        public Nullable<int> ID_USUARIO { get; set; }
        public Nullable<int> ID_CATEGORIA { get; set; }
        public Nullable<int> ID_PRIORIDAD { get; set; }
        public Nullable<int> ID_ESTADO { get; set; }
        public Nullable<int> ID_ORIGEN { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public System.DateTime FECHA_ACTUALIZACION { get; set; }
        public System.TimeSpan DURACION { get; set; }
        public string MOTIVO_CIERRE { get; set; }
    
        public virtual CANAL_ORIGEN CANAL_ORIGEN { get; set; }
        public virtual CATEGORIA CATEGORIA { get; set; }
        public virtual ESTADO ESTADO { get; set; }
        public virtual PRIORIDAD PRIORIDAD { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
