//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Otelwebsitesi
{
    using System;
    using System.Collections.Generic;
    
    public partial class restuarantdetay
    {
        public int restuarantdetayID { get; set; }
        public string restuaranddetayBilgi { get; set; }
        public int dil { get; set; }
        public int restuarantID { get; set; }
    
        public virtual Restuarant Restuarant { get; set; }
    }
}
