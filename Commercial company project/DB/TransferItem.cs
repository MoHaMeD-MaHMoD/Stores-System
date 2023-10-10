//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Commercial_company_project.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransferItem
    {
        public int TransferID { get; set; }
        public Nullable<System.DateTime> TransferDate { get; set; }
        public Nullable<int> FromStoreID { get; set; }
        public Nullable<int> ToStoreID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<System.DateTime> ProductionDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual Store Store { get; set; }
        public virtual Store Store1 { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
