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
    
    public partial class Ms_Vehicle_Models
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ms_Vehicle_Models()
        {
            this.Ms_Vehicles = new HashSet<Ms_Vehicles>();
        }
    
        public int Model_ID { get; set; }
        public Nullable<int> Brand_ID { get; set; }
        public string Type { get; set; }
        public Nullable<decimal> OTR_Price { get; set; }
        public Nullable<decimal> Normal_Disc { get; set; }
        public Nullable<int> Year1 { get; set; }
        public Nullable<int> Year2 { get; set; }
        public Nullable<int> Year3 { get; set; }
        public Nullable<int> Year4 { get; set; }
        public Nullable<int> Year5 { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsKeur { get; set; }
        public Nullable<bool> IsTruck { get; set; }
        public Nullable<int> Asset_Rating { get; set; }
        public bool Active { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Cn_Users Cn_Users { get; set; }
        public virtual Cn_Users Cn_Users1 { get; set; }
        public virtual Ms_Vehicle_Brands Ms_Vehicle_Brands { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ms_Vehicles> Ms_Vehicles { get; set; }
    }
}
