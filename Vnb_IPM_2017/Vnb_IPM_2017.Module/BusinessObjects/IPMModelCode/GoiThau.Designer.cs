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

    [DevExpress.Persistent.Base.DefaultClassOptions]
    public partial class GoiThau : XPObject
    {
        string fMaGoiThau;
        [Indexed(Name = @"mathau_idx")]
        [DevExpress.Xpo.DisplayName(@"Mã gói thầu")]
        public string MaGoiThau
        {
            get { return fMaGoiThau; }
            set { SetPropertyValue<string>("MaGoiThau", ref fMaGoiThau, value); }
        }
        string fTenGoiThau;
        [Indexed(Name = @"tenthau_idx")]
        [DevExpress.Xpo.DisplayName(@"Tên gói thầu")]
        public string TenGoiThau
        {
            get { return fTenGoiThau; }
            set { SetPropertyValue<string>("TenGoiThau", ref fTenGoiThau, value); }
        }
        DuAn fDuAn;
        [Association(@"GoiThauReferencesDuAn")]
        [DevExpress.Xpo.DisplayName(@"Dự án")]
        public DuAn DuAn
        {
            get { return fDuAn; }
            set { SetPropertyValue<DuAn>("DuAn", ref fDuAn, value); }
        }
        double fGiaDuToan;
        [DevExpress.Xpo.DisplayName(@"Giá dự toán")]
        public double GiaDuToan
        {
            get { return fGiaDuToan; }
            set { SetPropertyValue<double>("GiaDuToan", ref fGiaDuToan, value); }
        }
        double fGiaGoiThau;
        [DevExpress.Xpo.DisplayName(@"Giá gói thầu")]
        public double GiaGoiThau
        {
            get { return fGiaGoiThau; }
            set { SetPropertyValue<double>("GiaGoiThau", ref fGiaGoiThau, value); }
        }
        double fGiaTrungThau;
        [DevExpress.Xpo.DisplayName(@"Giá trúng thầu")]
        public double GiaTrungThau
        {
            get { return fGiaTrungThau; }
            set { SetPropertyValue<double>("GiaTrungThau", ref fGiaTrungThau, value); }
        }
        HangMucDuAn fHangMuc;
        [DevExpress.Xpo.DisplayName(@"Hạng mục")]
        public HangMucDuAn HangMuc
        {
            get { return fHangMuc; }
            set { SetPropertyValue<HangMucDuAn>("HangMuc", ref fHangMuc, value); }
        }
        DateTime fBatDau;
        [DevExpress.Xpo.DisplayName(@"Thời gian mở dự thầu")]
        public DateTime BatDau
        {
            get { return fBatDau; }
            set { SetPropertyValue<DateTime>("BatDau", ref fBatDau, value); }
        }
        DateTime fKetThuc;
        [DevExpress.Xpo.DisplayName(@"Thời gian đống dự thầu")]
        public DateTime KetThuc
        {
            get { return fKetThuc; }
            set { SetPropertyValue<DateTime>("KetThuc", ref fKetThuc, value); }
        }
        Vnb_IPM_2017.Module.BusinessObjects.Enumeration.HinhThucThau fHinhThuc;
        [DevExpress.Xpo.DisplayName(@"Hình thức lựa chọn")]
        public Vnb_IPM_2017.Module.BusinessObjects.Enumeration.HinhThucThau HinhThuc
        {
            get { return fHinhThuc; }
            set { SetPropertyValue<Vnb_IPM_2017.Module.BusinessObjects.Enumeration.HinhThucThau>("HinhThuc", ref fHinhThuc, value); }
        }
        Vnb_IPM_2017.Module.BusinessObjects.Enumeration.PhuongThucThau fPhuongThuc;
        [DevExpress.Xpo.DisplayName(@"Phương thức đấu thầu")]
        public Vnb_IPM_2017.Module.BusinessObjects.Enumeration.PhuongThucThau PhuongThuc
        {
            get { return fPhuongThuc; }
            set { SetPropertyValue<Vnb_IPM_2017.Module.BusinessObjects.Enumeration.PhuongThucThau>("PhuongThuc", ref fPhuongThuc, value); }
        }
        Vnb_IPM_2017.Module.BusinessObjects.Enumeration.TinhTrangGoiThau fTinhTrang;
        [Indexed(Name = @"tinhtrang_idx")]
        [DevExpress.Xpo.DisplayName(@"Tình trạng")]
        public Vnb_IPM_2017.Module.BusinessObjects.Enumeration.TinhTrangGoiThau TinhTrang
        {
            get { return fTinhTrang; }
            set { SetPropertyValue<Vnb_IPM_2017.Module.BusinessObjects.Enumeration.TinhTrangGoiThau>("TinhTrang", ref fTinhTrang, value); }
        }
        [DevExpress.Xpo.DisplayName(@"Hồ sơ mời thầu")]
        [Association(@"HoSoMoiThauReferencesGoiThau")]
        public XPCollection<HoSoMoiThau> HoSoMoiThaus { get { return GetCollection<HoSoMoiThau>("HoSoMoiThaus"); } }
        [DevExpress.Xpo.DisplayName(@"Hồ sơ dự thầu")]
        [Association(@"HoSoDuThauReferencesGoiThau")]
        public XPCollection<HoSoDuThau> HoSoDuThaus { get { return GetCollection<HoSoDuThau>("HoSoDuThaus"); } }
    }

}