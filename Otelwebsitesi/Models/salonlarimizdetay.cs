//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Otelwebsitesi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class salonlarimizdetay
    {
        public int salondetayID { get; set; }
        public string salondetayBilgi { get; set; }
        public int dil { get; set; }
        public int salonlarID { get; set; }
    
        public virtual Salonlar Salonlar { get; set; }
    }
}
