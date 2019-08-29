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
    
    public partial class Cn_Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cn_Users()
        {
            this.Ms_Customer_CompanyGroups = new HashSet<Ms_Customer_CompanyGroups>();
            this.Ms_Customers = new HashSet<Ms_Customers>();
            this.Ms_Customer_CompanyGroups1 = new HashSet<Ms_Customer_CompanyGroups>();
            this.Ms_Customers1 = new HashSet<Ms_Customers>();
            this.Ms_Vehicles = new HashSet<Ms_Vehicles>();
            this.Ms_Vehicle_Brands = new HashSet<Ms_Vehicle_Brands>();
            this.Ms_Vehicle_Models = new HashSet<Ms_Vehicle_Models>();
            this.Ms_Vehicles1 = new HashSet<Ms_Vehicles>();
            this.Ms_Vehicle_Brands1 = new HashSet<Ms_Vehicle_Brands>();
            this.Ms_Vehicle_Models1 = new HashSet<Ms_Vehicle_Models>();
            this.Tr_BSTKBefores = new HashSet<Tr_BSTKBefores>();
            this.Tr_BSTKBefores1 = new HashSet<Tr_BSTKBefores>();
            this.Tr_BSTKAfters = new HashSet<Tr_BSTKAfters>();
            this.Tr_BSTKAfters1 = new HashSet<Tr_BSTKAfters>();
        }
    
        public int User_ID { get; set; }
        public string NIK { get; set; }
        public string User_Name { get; set; }
        public string Full_Name { get; set; }
        public string Password { get; set; }
        public Nullable<int> Directorat_ID { get; set; }
        public Nullable<int> GM_ID { get; set; }
        public Nullable<int> Division_ID { get; set; }
        public Nullable<int> Department_ID { get; set; }
        public Nullable<int> Title_ID { get; set; }
        public Nullable<int> Role_ID { get; set; }
        public string Pic { get; set; }
        public byte[] Paraf { get; set; }
        public byte[] Sign { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ms_Customer_CompanyGroups> Ms_Customer_CompanyGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ms_Customers> Ms_Customers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ms_Customer_CompanyGroups> Ms_Customer_CompanyGroups1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ms_Customers> Ms_Customers1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ms_Vehicles> Ms_Vehicles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ms_Vehicle_Brands> Ms_Vehicle_Brands { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ms_Vehicle_Models> Ms_Vehicle_Models { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ms_Vehicles> Ms_Vehicles1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ms_Vehicle_Brands> Ms_Vehicle_Brands1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ms_Vehicle_Models> Ms_Vehicle_Models1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tr_BSTKBefores> Tr_BSTKBefores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tr_BSTKBefores> Tr_BSTKBefores1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tr_BSTKAfters> Tr_BSTKAfters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tr_BSTKAfters> Tr_BSTKAfters1 { get; set; }
    }
}
