//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace attocaert.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_product
    {
        public tbl_product()
        {
            this.tbl_order = new HashSet<tbl_order>();
        }
    
        public int pro_id { get; set; }
        public string pro_name { get; set; }
        public Nullable<double> pro_price { get; set; }
        public string pro_desc { get; set; }
        public string pro_image { get; set; }
    
        public virtual ICollection<tbl_order> tbl_order { get; set; }
    }
}
