﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PTTKHT.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PTTKHTEntities : DbContext
    {
        public PTTKHTEntities()
            : base("name=PTTKHTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietDonNhapHang> ChiTietDonNhapHangs { get; set; }
        public virtual DbSet<ChiTietDonTraHangNCC> ChiTietDonTraHangNCCs { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<DoiTacQuangCao> DoiTacQuangCaos { get; set; }
        public virtual DbSet<DonNhapHang> DonNhapHangs { get; set; }
        public virtual DbSet<DonTraHangCC> DonTraHangCCs { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HopDong> HopDongs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiHoang> LoaiHoangs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<ThanhToan> ThanhToans { get; set; }
        public virtual DbSet<TinNhan> TinNhans { get; set; }
    }
}
