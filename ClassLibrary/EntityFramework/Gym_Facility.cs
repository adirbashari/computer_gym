//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gym_Facility
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gym_Facility()
        {
            this.Facility_Video_Link = new HashSet<Facility_Video_Link>();
            this.Trainer_Facility_Recommendation = new HashSet<Trainer_Facility_Recommendation>();
        }
    
        public int Facility_Code { get; set; }
        public string Facility_Name { get; set; }
        public string Category { get; set; }
        public string Picture { get; set; }
        public bool Big_Muscle { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facility_Video_Link> Facility_Video_Link { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trainer_Facility_Recommendation> Trainer_Facility_Recommendation { get; set; }
    }
}