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
    
    public partial class insankaynaklaridetay
    {
        public int ikdetayID { get; set; }
        public string ikdetayBilgi { get; set; }
        public int dil { get; set; }
        public int ikID { get; set; }
    
        public virtual insankaynaklari insankaynaklari { get; set; }
    }
}
