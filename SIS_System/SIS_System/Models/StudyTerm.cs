//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIS_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudyTerm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudyTerm()
        {
            this.Registrations = new HashSet<Registration>();
            this.TeachingAssignments = new HashSet<TeachingAssignment>();
        }
    
        public string TermID { get; set; }
        public string TermName { get; set; }
        public System.DateTime TermStartDate { get; set; }
        public System.DateTime TermEndDate { get; set; }
        public int TermYear { get; set; }
        public string TermSeason { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registration> Registrations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeachingAssignment> TeachingAssignments { get; set; }
    }
}
