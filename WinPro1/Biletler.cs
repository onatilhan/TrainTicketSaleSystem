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
    
    public partial class Biletler
    {
        public int BiletNumarasi { get; set; }
        public string KalkisNoktasi { get; set; }
        public string VarisNoktasi { get; set; }
        public string GidisTarihi { get; set; }
        public string DonusTarihi { get; set; }
        public int KisiSayisi { get; set; }
        public Nullable<int> CocukSayisi { get; set; }
        public string YonBilgisi { get; set; }
        public string İslemYapanId { get; set; }
        public string Musteri_Adı { get; set; }
        public Nullable<int> Bilet_Sayısı { get; set; }
        public Nullable<int> Tutar { get; set; }
        public string Saati { get; set; }
        public string DönüşSaati { get; set; }
    
        public virtual GiseGorevlileri GiseGorevlileri { get; set; }
    }
}
