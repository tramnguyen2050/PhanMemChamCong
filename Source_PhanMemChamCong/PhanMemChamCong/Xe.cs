//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhanMemChamCong
{
    using System;
    using System.Collections.Generic;
    
    public partial class Xe
    {
        public Xe()
        {
            this.DonGiaoHangs = new HashSet<DonGiaoHang>();
        }
    
        public int MaXe { get; set; }
        public string BienSo { get; set; }
    
        public virtual ICollection<DonGiaoHang> DonGiaoHangs { get; set; }
    }
}
