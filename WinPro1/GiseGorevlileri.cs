//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinPro1
{
    using System;
    using System.Collections.Generic;
    
    public partial class GiseGorevlileri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiseGorevlileri()
        {
            this.Biletler = new HashSet<Biletler>();
        }
    
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Görevli_Ismi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Biletler> Biletler { get; set; }
    }
}