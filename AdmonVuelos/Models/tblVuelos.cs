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
    
    public partial class tblVuelos
    {
        public int id { get; set; }
        public int CiudadOrigenId { get; set; }
        public int CiudadDestinoId { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.TimeSpan HoraSalida { get; set; }
        public System.TimeSpan Horallegada { get; set; }
        public int NroVueloId { get; set; }
        public int AerolineaId { get; set; }
        public int EstadoId { get; set; }
        public string CondicionVuelo { get; set; }
    
        public virtual tblAerolineas tblAerolineas { get; set; }
        public virtual tblCiudades tblCiudades { get; set; }
        public virtual tblCiudades tblCiudades1 { get; set; }
        public virtual tblEstadoVuelo tblEstadoVuelo { get; set; }
        public virtual tblNumeroVuelo tblNumeroVuelo { get; set; }
    }
}
