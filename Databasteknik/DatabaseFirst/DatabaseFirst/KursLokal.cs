//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class KursLokal
    {
        public string Kurskod { get; set; }
        public int Lokalnummer { get; set; }
        public Nullable<System.DateTime> Datum { get; set; }
        public Nullable<System.TimeSpan> Tid { get; set; }
    
        public virtual Kurs Kurs { get; set; }
        public virtual Lokal Lokal { get; set; }
    }
}