//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrustAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ms_Vehicle_Brands
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ms_Vehicle_Brands()
        {
            this.Ms_Vehicle_Models = new HashSet<Ms_Vehicle_Models>();
        }
    
        public int Brand_ID { get; set; }
        public string Brand_Name { get; set; }
        public string Description { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Cn_Users Cn_Users { get; set; }
        public virtual Cn_Users Cn_Users1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ms_Vehicle_Models> Ms_Vehicle_Models { get; set; }
    }
}