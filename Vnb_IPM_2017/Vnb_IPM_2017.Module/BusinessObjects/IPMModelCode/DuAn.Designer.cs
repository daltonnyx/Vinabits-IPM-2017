﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Vnb_IPM_2017.Module.BusinessObjects
{

    public partial class DuAn : XPObject
    {
        string fTenDuAn;
        [Indexed(Name = @"tenduan_idx")]
        [DevExpress.Xpo.DisplayName(@"Tên dự án")]
        public string TenDuAn
        {
            get { return fTenDuAn; }
            set { SetPropertyValue<string>("TenDuAn", ref fTenDuAn, value); }
        }
        string fMaDuAn;
        [Indexed(Name = @"maduan_idx")]
        [DevExpress.Xpo.DisplayName(@"Mã Dự án")]
        public string MaDuAn
        {
            get { return fMaDuAn; }
            set { SetPropertyValue<string>("MaDuAn", ref fMaDuAn, value); }
        }
        short fBatDau;
        [DevExpress.Xpo.DisplayName(@"Bắt đầu")]
        public short BatDau
        {
            get { return fBatDau; }
            set { SetPropertyValue<short>("BatDau", ref fBatDau, value); }
        }
        short fKetThuc;
        [DevExpress.Xpo.DisplayName(@"Kết thúc")]
        public short KetThuc
        {
            get { return fKetThuc; }
            set { SetPropertyValue<short>("KetThuc", ref fKetThuc, value); }
        }
        double fTongMucDauTu;
        [DevExpress.Xpo.DisplayName(@"Tổng mức đầu tư")]
        public double TongMucDauTu
        {
            get { return fTongMucDauTu; }
            set { SetPropertyValue<double>("TongMucDauTu", ref fTongMucDauTu, value); }
        }
        double fQuyetToan;
        [DevExpress.Xpo.DisplayName(@"Giá trị quyết toán")]
        public double QuyetToan
        {
            get { return fQuyetToan; }
            set { SetPropertyValue<double>("QuyetToan", ref fQuyetToan, value); }
        }
        Vnb_IPM_2017.Module.BusinessObjects.Enumeration.PriorityEnum fUuTien;
        [Indexed(Name = @"uutien_idx")]
        [DevExpress.Xpo.DisplayName(@"Mức độ ưu tiên")]
        public Vnb_IPM_2017.Module.BusinessObjects.Enumeration.PriorityEnum UuTien
        {
            get { return fUuTien; }
            set { SetPropertyValue<Vnb_IPM_2017.Module.BusinessObjects.Enumeration.PriorityEnum>("UuTien", ref fUuTien, value); }
        }
        Vnb_IPM_2017.Module.BusinessObjects.Enumeration.ProjectStatusEnum fTrangThai;
        [DevExpress.Xpo.DisplayName(@"Trạng thái")]
        public Vnb_IPM_2017.Module.BusinessObjects.Enumeration.ProjectStatusEnum TrangThai
        {
            get { return fTrangThai; }
            set { SetPropertyValue<Vnb_IPM_2017.Module.BusinessObjects.Enumeration.ProjectStatusEnum>("TrangThai", ref fTrangThai, value); }
        }
        string fNoiDung;
        [Size(SizeAttribute.Unlimited)]
        [DevExpress.Xpo.DisplayName(@"Nội dung")]
        public string NoiDung
        {
            get { return fNoiDung; }
            set { SetPropertyValue<string>("NoiDung", ref fNoiDung, value); }
        }
        LoaiDuAn fLoaiDuAn;
        [Indexed(Name = @"loaiduan_idx")]
        [Association(@"DuAnReferencesLoaiDuAn")]
        [DevExpress.Xpo.DisplayName(@"Phân loại")]
        public LoaiDuAn LoaiDuAn
        {
            get { return fLoaiDuAn; }
            set { SetPropertyValue<LoaiDuAn>("LoaiDuAn", ref fLoaiDuAn, value); }
        }
        string fTienDo;
        public string TienDo
        {
            get { return fTienDo; }
            set { SetPropertyValue<string>("TienDo", ref fTienDo, value); }
        }
        NhanVien fTruongDuAn;
        [Association(@"DuAnReferencesNhanVien")]
        [DevExpress.Xpo.DisplayName(@"Trưởng dự án")]
        public NhanVien TruongDuAn
        {
            get { return fTruongDuAn; }
            set { SetPropertyValue<NhanVien>("TruongDuAn", ref fTruongDuAn, value); }
        }
        [DevExpress.Xpo.DisplayName(@"Hạng mục dự án")]
        [Association(@"HangMucDuAnReferencesDuAn")]
        public XPCollection<HangMucDuAn> HangMucDuAns { get { return GetCollection<HangMucDuAn>("HangMucDuAns"); } }
        [DevExpress.Xpo.DisplayName(@"Gói thầu")]
        [Association(@"GoiThauReferencesDuAn")]
        public XPCollection<GoiThau> GoiThaus { get { return GetCollection<GoiThau>("GoiThaus"); } }
    }

}