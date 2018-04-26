//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMO101.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class caseDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public caseDetail()
        {
            this.situationDetails = new HashSet<situationDetail>();
        }
    
        public int caseID { get; set; }
        public string description { get; set; }
        public string informantName { get; set; }
        public int informantPhone { get; set; }
        public System.DateTime dateTime { get; set; }
        public string location { get; set; }
        public int crisisLevel { get; set; }
        public double initialLat { get; set; }
        public double initialLng { get; set; }
        public string caseStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<situationDetail> situationDetails { get; set; }
        public virtual crisisLevel crisisLevel1 { get; set; }
    }
}
