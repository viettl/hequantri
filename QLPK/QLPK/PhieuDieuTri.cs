//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLPK
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuDieuTri
    {
        public string MaPDT { get; set; }
        public Nullable<System.DateTime> NgayThang { get; set; }
        public string TinhTrang { get; set; }
        public string BenhNhan { get; set; }
        public System.DateTime NgayLap { get; set; }
        public System.DateTime NguoiLap { get; set; }
    
        public virtual BenhNhan BenhNhan1 { get; set; }
    }
}
