//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PTTKHT
{
    using System;
    using System.Collections.Generic;
    
    public partial class HangHoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HangHoa()
        {
            this.ChiTietDonNhapHangs = new HashSet<ChiTietDonNhapHang>();
            this.ChiTietDonTraHangNCCs = new HashSet<ChiTietDonTraHangNCC>();
            this.ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            this.Comments = new HashSet<Comment>();
            this.TinNhans = new HashSet<TinNhan>();
        }
    
        public int ID { get; set; }
        public string TenHH { get; set; }
        public Nullable<int> NhapMax { get; set; }
        public Nullable<int> SLmin { get; set; }
        public int NCC { get; set; }
        public int QuanLy { get; set; }
        public Nullable<int> SoLuongTra { get; set; }
        public int LoaiHang { get; set; }
        public Nullable<double> DonGia { get; set; }
        public Nullable<int> SoLuongTon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonNhapHang> ChiTietDonNhapHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonTraHangNCC> ChiTietDonTraHangNCCs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual LoaiHoang LoaiHoang { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TinNhan> TinNhans { get; set; }
    }
}
