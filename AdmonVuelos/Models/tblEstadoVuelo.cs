//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdmonVuelos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblEstadoVuelo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEstadoVuelo()
        {
            this.tblVuelos = new HashSet<tblVuelos>();
        }
    
        public int id { get; set; }
        public string EstadoVuelo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblVuelos> tblVuelos { get; set; }
    }
}
