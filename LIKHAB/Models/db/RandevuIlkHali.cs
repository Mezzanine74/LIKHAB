//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LIKHAB.Models.db
{
    using System;

    public partial class RandevuIlkHali
    {
        public int id { get; set; }
        public int Is { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Location { get; set; }
        public Nullable<bool> AllDay { get; set; }
        public Nullable<int> Type { get; set; }
        public string Subject { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Label { get; set; }
        public Nullable<System.DateTime> VerilisZamani { get; set; }
        public string AdiSoyadi { get; set; }
        public Nullable<System.DateTime> WhenUpdated { get; set; }
        public string WhoCreated { get; set; }
        public string WhoUpdated { get; set; }
        public Nullable<System.DateTime> WhenCreated { get; set; }
    }
}