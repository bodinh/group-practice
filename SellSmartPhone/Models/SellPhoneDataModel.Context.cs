﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SellSmartPhone.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SellphonesEntities : DbContext
    {
        public SellphonesEntities()
            : base("name=SellphonesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<BaoHanh> BaoHanhs { get; set; }
        public virtual DbSet<Binhluan> Binhluans { get; set; }
        public virtual DbSet<ChitietDH> ChitietDHs { get; set; }
        public virtual DbSet<DonhangKH> DonhangKHs { get; set; }
        public virtual DbSet<HangSX> HangSXes { get; set; }
        public virtual DbSet<Hopdong> Hopdongs { get; set; }
        public virtual DbSet<Khuyenmai> Khuyenmais { get; set; }
        public virtual DbSet<LoaiSP> LoaiSPs { get; set; }
        public virtual DbSet<Nhacungcap> Nhacungcaps { get; set; }
        public virtual DbSet<Sanpham> Sanphams { get; set; }
        public virtual DbSet<SPkhuyenmai> SPkhuyenmais { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Thongsokythuat> Thongsokythuats { get; set; }
    
        public virtual int addproduct(Nullable<int> maSP, string tenSP, Nullable<int> loaiSP, Nullable<int> hangSX, string xuatxu, Nullable<double> gia, string mota, string anh, Nullable<int> isnew, Nullable<int> ishot)
        {
            var maSPParameter = maSP.HasValue ?
                new ObjectParameter("MaSP", maSP) :
                new ObjectParameter("MaSP", typeof(int));
    
            var tenSPParameter = tenSP != null ?
                new ObjectParameter("TenSP", tenSP) :
                new ObjectParameter("TenSP", typeof(string));
    
            var loaiSPParameter = loaiSP.HasValue ?
                new ObjectParameter("LoaiSP", loaiSP) :
                new ObjectParameter("LoaiSP", typeof(int));
    
            var hangSXParameter = hangSX.HasValue ?
                new ObjectParameter("HangSX", hangSX) :
                new ObjectParameter("HangSX", typeof(int));
    
            var xuatxuParameter = xuatxu != null ?
                new ObjectParameter("Xuatxu", xuatxu) :
                new ObjectParameter("Xuatxu", typeof(string));
    
            var giaParameter = gia.HasValue ?
                new ObjectParameter("Gia", gia) :
                new ObjectParameter("Gia", typeof(double));
    
            var motaParameter = mota != null ?
                new ObjectParameter("Mota", mota) :
                new ObjectParameter("Mota", typeof(string));
    
            var anhParameter = anh != null ?
                new ObjectParameter("Anh", anh) :
                new ObjectParameter("Anh", typeof(string));
    
            var isnewParameter = isnew.HasValue ?
                new ObjectParameter("Isnew", isnew) :
                new ObjectParameter("Isnew", typeof(int));
    
            var ishotParameter = ishot.HasValue ?
                new ObjectParameter("Ishot", ishot) :
                new ObjectParameter("Ishot", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addproduct", maSPParameter, tenSPParameter, loaiSPParameter, hangSXParameter, xuatxuParameter, giaParameter, motaParameter, anhParameter, isnewParameter, ishotParameter);
        }
    
        public virtual int addthongsokythuat(Nullable<int> maSP, string thuoctinh, string giatri)
        {
            var maSPParameter = maSP.HasValue ?
                new ObjectParameter("MaSP", maSP) :
                new ObjectParameter("MaSP", typeof(int));
    
            var thuoctinhParameter = thuoctinh != null ?
                new ObjectParameter("Thuoctinh", thuoctinh) :
                new ObjectParameter("Thuoctinh", typeof(string));
    
            var giatriParameter = giatri != null ?
                new ObjectParameter("Giatri", giatri) :
                new ObjectParameter("Giatri", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("addthongsokythuat", maSPParameter, thuoctinhParameter, giatriParameter);
        }
    
        public virtual ObjectResult<get_product_discount_Result> get_product_discount()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_product_discount_Result>("get_product_discount");
        }
    }
}
