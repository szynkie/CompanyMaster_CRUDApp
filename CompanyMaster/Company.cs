//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyMaster
{
    using System;
    using System.Collections.Generic;
    
    public partial class Company
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public int CityFK { get; set; }
        public int BSegFK { get; set; }
    
        public virtual BusinessSegment BusinessSegment { get; set; }
        public virtual City City { get; set; }
    }
}