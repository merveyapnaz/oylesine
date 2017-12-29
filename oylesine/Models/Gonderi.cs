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
    
    public partial class Gonderi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gonderi()
        {
            this.Begenis = new HashSet<Begeni>();
            this.Yorums = new HashSet<Yorum>();
        }
    
        public int GonderiId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Icerik { get; set; }
        public Nullable<int> MedyaId { get; set; }
        public System.DateTime Tarih { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Begeni> Begenis { get; set; }
        public virtual Medya Medya { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yorum> Yorums { get; set; }
    }
}
