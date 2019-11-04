﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharpchainWebAPI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class qlnhEntities1 : DbContext
    {
        public qlnhEntities1()
            : base("name=qlnhEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_ban> tbl_ban { get; set; }
        public virtual DbSet<tbl_chitiethoadon> tbl_chitiethoadon { get; set; }
        public virtual DbSet<tbl_chitiethoadonnhap> tbl_chitiethoadonnhap { get; set; }
        public virtual DbSet<tbl_hoadon> tbl_hoadon { get; set; }
        public virtual DbSet<tbl_hoadon_tam> tbl_hoadon_tam { get; set; }
        public virtual DbSet<tbl_hoadonnhap> tbl_hoadonnhap { get; set; }
        public virtual DbSet<tbl_khuyenmai> tbl_khuyenmai { get; set; }
        public virtual DbSet<tbl_loaisp> tbl_loaisp { get; set; }
        public virtual DbSet<tbl_menu> tbl_menu { get; set; }
        public virtual DbSet<tbl_phanquyen> tbl_phanquyen { get; set; }
        public virtual DbSet<tbl_taikhoan> tbl_taikhoan { get; set; }
        public virtual DbSet<tbl_luumatkhau> tbl_luumatkhau { get; set; }
    
        public virtual int kiemtrakhoa(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("kiemtrakhoa", idParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual ObjectResult<sp_chitiethd_Result> sp_chitiethd(Nullable<int> maHD)
        {
            var maHDParameter = maHD.HasValue ?
                new ObjectParameter("maHD", maHD) :
                new ObjectParameter("maHD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_chitiethd_Result>("sp_chitiethd", maHDParameter);
        }
    
        public virtual int sp_chuyendoidulieu(Nullable<int> iMaHD, Nullable<int> iMaNV)
        {
            var iMaHDParameter = iMaHD.HasValue ?
                new ObjectParameter("iMaHD", iMaHD) :
                new ObjectParameter("iMaHD", typeof(int));
    
            var iMaNVParameter = iMaNV.HasValue ?
                new ObjectParameter("iMaNV", iMaNV) :
                new ObjectParameter("iMaNV", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_chuyendoidulieu", iMaHDParameter, iMaNVParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_datHang(string value, Nullable<int> maban)
        {
            var valueParameter = value != null ?
                new ObjectParameter("value", value) :
                new ObjectParameter("value", typeof(string));
    
            var mabanParameter = maban.HasValue ?
                new ObjectParameter("maban", maban) :
                new ObjectParameter("maban", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_datHang", valueParameter, mabanParameter);
        }
    
        public virtual int sp_DoiMatKhau(string matKhauCu, string sMatKhau, Nullable<int> id, ObjectParameter trangthai)
        {
            var matKhauCuParameter = matKhauCu != null ?
                new ObjectParameter("matKhauCu", matKhauCu) :
                new ObjectParameter("matKhauCu", typeof(string));
    
            var sMatKhauParameter = sMatKhau != null ?
                new ObjectParameter("sMatKhau", sMatKhau) :
                new ObjectParameter("sMatKhau", typeof(string));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DoiMatKhau", matKhauCuParameter, sMatKhauParameter, idParameter, trangthai);
        }
    
        public virtual int sp_doiMatKhauByAdmin(string matKhauAdmin, string sMatKhau, string sTenDangNhap, ObjectParameter trangthai)
        {
            var matKhauAdminParameter = matKhauAdmin != null ?
                new ObjectParameter("matKhauAdmin", matKhauAdmin) :
                new ObjectParameter("matKhauAdmin", typeof(string));
    
            var sMatKhauParameter = sMatKhau != null ?
                new ObjectParameter("sMatKhau", sMatKhau) :
                new ObjectParameter("sMatKhau", typeof(string));
    
            var sTenDangNhapParameter = sTenDangNhap != null ?
                new ObjectParameter("sTenDangNhap", sTenDangNhap) :
                new ObjectParameter("sTenDangNhap", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_doiMatKhauByAdmin", matKhauAdminParameter, sMatKhauParameter, sTenDangNhapParameter, trangthai);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_dsnv(string action)
        {
            var actionParameter = action != null ?
                new ObjectParameter("action", action) :
                new ObjectParameter("action", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dsnv", actionParameter);
        }
    
        public virtual int sp_get_dsthucdon(string action)
        {
            var actionParameter = action != null ?
                new ObjectParameter("action", action) :
                new ObjectParameter("action", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_get_dsthucdon", actionParameter);
        }
    
        public virtual int sp_get_dsthucdon_km(string action)
        {
            var actionParameter = action != null ?
                new ObjectParameter("action", action) :
                new ObjectParameter("action", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_get_dsthucdon_km", actionParameter);
        }
    
        public virtual ObjectResult<sp_getban_Result> sp_getban()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getban_Result>("sp_getban");
        }
    
        public virtual ObjectResult<sp_getCTHD_Result> sp_getCTHD(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getCTHD_Result>("sp_getCTHD", idParameter);
        }
    
        public virtual ObjectResult<sp_getCTHD_km_Result> sp_getCTHD_km(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getCTHD_km_Result>("sp_getCTHD_km", idParameter);
        }
    
        public virtual ObjectResult<sp_getdsloaihang_Result> sp_getdsloaihang()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getdsloaihang_Result>("sp_getdsloaihang");
        }
    
        public virtual ObjectResult<sp_getHD_Result> sp_getHD()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getHD_Result>("sp_getHD");
        }
    
        public virtual int sp_getMK(string sTenDN, ObjectParameter sMatKhau)
        {
            var sTenDNParameter = sTenDN != null ?
                new ObjectParameter("sTenDN", sTenDN) :
                new ObjectParameter("sTenDN", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_getMK", sTenDNParameter, sMatKhau);
        }
    
        public virtual ObjectResult<sp_getMKGN_Result> sp_getMKGN()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getMKGN_Result>("sp_getMKGN");
        }
    
        public virtual int sp_giaohang(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_giaohang", iDParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_hoadon_Result> sp_hoadon()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_hoadon_Result>("sp_hoadon");
        }
    
        public virtual int sp_huymon(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_huymon", iDParameter);
        }
    
        public virtual int sp_khuyenmai(Nullable<int> idMatHang, Nullable<double> tiLe, Nullable<System.DateTime> thoiGianBatDau, Nullable<System.DateTime> thoiGianKetThuc)
        {
            var idMatHangParameter = idMatHang.HasValue ?
                new ObjectParameter("idMatHang", idMatHang) :
                new ObjectParameter("idMatHang", typeof(int));
    
            var tiLeParameter = tiLe.HasValue ?
                new ObjectParameter("tiLe", tiLe) :
                new ObjectParameter("tiLe", typeof(double));
    
            var thoiGianBatDauParameter = thoiGianBatDau.HasValue ?
                new ObjectParameter("thoiGianBatDau", thoiGianBatDau) :
                new ObjectParameter("thoiGianBatDau", typeof(System.DateTime));
    
            var thoiGianKetThucParameter = thoiGianKetThuc.HasValue ?
                new ObjectParameter("thoiGianKetThuc", thoiGianKetThuc) :
                new ObjectParameter("thoiGianKetThuc", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_khuyenmai", idMatHangParameter, tiLeParameter, thoiGianBatDauParameter, thoiGianKetThucParameter);
        }
    
        public virtual int sp_lapchitiethoadon(string value)
        {
            var valueParameter = value != null ?
                new ObjectParameter("value", value) :
                new ObjectParameter("value", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_lapchitiethoadon", valueParameter);
        }
    
        public virtual int sp_lapchitiethoadonxuat(string value)
        {
            var valueParameter = value != null ?
                new ObjectParameter("value", value) :
                new ObjectParameter("value", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_lapchitiethoadonxuat", valueParameter);
        }
    
        public virtual int sp_lapHoaDonNhap(Nullable<int> iMaNguoiLap, ObjectParameter imaHDNhap)
        {
            var iMaNguoiLapParameter = iMaNguoiLap.HasValue ?
                new ObjectParameter("iMaNguoiLap", iMaNguoiLap) :
                new ObjectParameter("iMaNguoiLap", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_lapHoaDonNhap", iMaNguoiLapParameter, imaHDNhap);
        }
    
        public virtual ObjectResult<sp_lastlogin_Result> sp_lastlogin(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_lastlogin_Result>("sp_lastlogin", idParameter);
        }
    
        public virtual ObjectResult<sp_loadHoaDonTam_Result> sp_loadHoaDonTam(Nullable<int> iMaHD)
        {
            var iMaHDParameter = iMaHD.HasValue ?
                new ObjectParameter("iMaHD", iMaHD) :
                new ObjectParameter("iMaHD", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_loadHoaDonTam_Result>("sp_loadHoaDonTam", iMaHDParameter);
        }
    
        public virtual ObjectResult<sp_login_Result> sp_login(string sTenDangNhap, string sMatKhau)
        {
            var sTenDangNhapParameter = sTenDangNhap != null ?
                new ObjectParameter("sTenDangNhap", sTenDangNhap) :
                new ObjectParameter("sTenDangNhap", typeof(string));
    
            var sMatKhauParameter = sMatKhau != null ?
                new ObjectParameter("sMatKhau", sMatKhau) :
                new ObjectParameter("sMatKhau", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_login_Result>("sp_login", sTenDangNhapParameter, sMatKhauParameter);
        }
    
        public virtual int sp_luu(string id, string value)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var valueParameter = value != null ?
                new ObjectParameter("value", value) :
                new ObjectParameter("value", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_luu", idParameter, valueParameter);
        }
    
        public virtual int sp_luuMK(string sTenDN, string sMatKhau)
        {
            var sTenDNParameter = sTenDN != null ?
                new ObjectParameter("sTenDN", sTenDN) :
                new ObjectParameter("sTenDN", typeof(string));
    
            var sMatKhauParameter = sMatKhau != null ?
                new ObjectParameter("sMatKhau", sMatKhau) :
                new ObjectParameter("sMatKhau", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_luuMK", sTenDNParameter, sMatKhauParameter);
        }
    
        public virtual ObjectResult<sp_quyen_Result> sp_quyen()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_quyen_Result>("sp_quyen");
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_themMoiMenu(string sTenSP, Nullable<int> iDonGia, string sDonViTinh, Nullable<int> iMaLoaiSP)
        {
            var sTenSPParameter = sTenSP != null ?
                new ObjectParameter("sTenSP", sTenSP) :
                new ObjectParameter("sTenSP", typeof(string));
    
            var iDonGiaParameter = iDonGia.HasValue ?
                new ObjectParameter("iDonGia", iDonGia) :
                new ObjectParameter("iDonGia", typeof(int));
    
            var sDonViTinhParameter = sDonViTinh != null ?
                new ObjectParameter("sDonViTinh", sDonViTinh) :
                new ObjectParameter("sDonViTinh", typeof(string));
    
            var iMaLoaiSPParameter = iMaLoaiSP.HasValue ?
                new ObjectParameter("iMaLoaiSP", iMaLoaiSP) :
                new ObjectParameter("iMaLoaiSP", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_themMoiMenu", sTenSPParameter, iDonGiaParameter, sDonViTinhParameter, iMaLoaiSPParameter);
        }
    
        public virtual int sp_themNV(string sTaiKhoan, string sTenNguoiDung, Nullable<int> gioiTinh, string sDT, string sDiaChi, Nullable<int> chucvu)
        {
            var sTaiKhoanParameter = sTaiKhoan != null ?
                new ObjectParameter("sTaiKhoan", sTaiKhoan) :
                new ObjectParameter("sTaiKhoan", typeof(string));
    
            var sTenNguoiDungParameter = sTenNguoiDung != null ?
                new ObjectParameter("sTenNguoiDung", sTenNguoiDung) :
                new ObjectParameter("sTenNguoiDung", typeof(string));
    
            var gioiTinhParameter = gioiTinh.HasValue ?
                new ObjectParameter("GioiTinh", gioiTinh) :
                new ObjectParameter("GioiTinh", typeof(int));
    
            var sDTParameter = sDT != null ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(string));
    
            var sDiaChiParameter = sDiaChi != null ?
                new ObjectParameter("sDiaChi", sDiaChi) :
                new ObjectParameter("sDiaChi", typeof(string));
    
            var chucvuParameter = chucvu.HasValue ?
                new ObjectParameter("chucvu", chucvu) :
                new ObjectParameter("chucvu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_themNV", sTaiKhoanParameter, sTenNguoiDungParameter, gioiTinhParameter, sDTParameter, sDiaChiParameter, chucvuParameter);
        }
    
        public virtual int sp_update_menu(string iMaSP, string update)
        {
            var iMaSPParameter = iMaSP != null ?
                new ObjectParameter("iMaSP", iMaSP) :
                new ObjectParameter("iMaSP", typeof(string));
    
            var updateParameter = update != null ?
                new ObjectParameter("update", update) :
                new ObjectParameter("update", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_update_menu", iMaSPParameter, updateParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<v_dshd_Result> v_dshd(Nullable<System.DateTime> ngay, Nullable<System.DateTime> tu)
        {
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("ngay", ngay) :
                new ObjectParameter("ngay", typeof(System.DateTime));
    
            var tuParameter = tu.HasValue ?
                new ObjectParameter("tu", tu) :
                new ObjectParameter("tu", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<v_dshd_Result>("v_dshd", ngayParameter, tuParameter);
        }
    
        public virtual ObjectResult<v_dshd1_Result> v_dshd1(Nullable<System.DateTime> tuNgay)
        {
            var tuNgayParameter = tuNgay.HasValue ?
                new ObjectParameter("tuNgay", tuNgay) :
                new ObjectParameter("tuNgay", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<v_dshd1_Result>("v_dshd1", tuNgayParameter);
        }
    }
}
