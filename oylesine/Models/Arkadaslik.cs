//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace oylesine.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Arkadaslik
    {
        public int ArkadaslikID { get; set; }
        public int Kullanici1ID { get; set; }
        public int Kullanici2ID { get; set; }
    
        public virtual Kullanicilar Kullanicilar { get; set; }
        public virtual Kullanicilar Kullanicilar1 { get; set; }
    }
}
