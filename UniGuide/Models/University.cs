//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniGuide.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class University
    {
        public University()
        {
            this.UniversityComments = new HashSet<UniversityComment>();
            this.Faculties = new HashSet<Faculty>();
        }
    
        public int UniveristyID { get; set; }
        public string UniversityEng { get; set; }
        public string UniversityArb { get; set; }
        public string AboutUniversityEng { get; set; }
        public string AboutUniversityArb { get; set; }
        public int City { get; set; }
        public System.Data.Entity.Spatial.DbGeography Location { get; set; }
        public byte[] logo { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UniversityURL { get; set; }
        public Nullable<int> GlobalRank { get; set; }
        public Nullable<int> ContinetRank { get; set; }
        public Nullable<int> RegionalRank { get; set; }
        public Nullable<int> LocalRank { get; set; }
    
        public virtual City City1 { get; set; }
        public virtual ICollection<UniversityComment> UniversityComments { get; set; }
        public virtual ICollection<Faculty> Faculties { get; set; }
    }
}