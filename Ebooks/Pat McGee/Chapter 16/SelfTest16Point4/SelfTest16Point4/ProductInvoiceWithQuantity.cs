//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SelfTest16Point4
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductInvoiceWithQuantity
    {
        public int productID { get; set; }
        public int invoiceNum { get; set; }
        public Nullable<int> quantity { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
    }
}
