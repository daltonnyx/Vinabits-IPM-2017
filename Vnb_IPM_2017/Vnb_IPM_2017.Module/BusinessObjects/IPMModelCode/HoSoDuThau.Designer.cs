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
    public partial class HoSoDuThau : FleAttachments
    {
        GoiThau fGoiThau;
        [Indexed(Name = @"goithau_idx")]
        [Association(@"HoSoDuThauReferencesGoiThau")]
        [DevExpress.Xpo.DisplayName(@"Gói thầu")]
        public GoiThau GoiThau
        {
            get { return fGoiThau; }
            set { SetPropertyValue<GoiThau>("GoiThau", ref fGoiThau, value); }
        }
        DateTime fNgayNopHS;
        [Indexed(Name = @"ngayhs_idx")]
        [DevExpress.Xpo.DisplayName(@"Ngày Nộp Hồ sơ")]
        public DateTime NgayNopHS
        {
            get { return fNgayNopHS; }
            set { SetPropertyValue<DateTime>("NgayNopHS", ref fNgayNopHS, value); }
        }
        double fTienCoc;
        [DevExpress.Xpo.DisplayName(@"Tiền đặt cọc")]
        public double TienCoc
        {
            get { return fTienCoc; }
            set { SetPropertyValue<double>("TienCoc", ref fTienCoc, value); }
        }
        double fGiaDuThau;
        [DevExpress.Xpo.DisplayName(@"Giá Dự thầu")]
        public double GiaDuThau
        {
            get { return fGiaDuThau; }
            set { SetPropertyValue<double>("GiaDuThau", ref fGiaDuThau, value); }
        }
        NhaDauTu fChuDauTu;
        [Indexed(Name = @"chudautu_idx")]
        [Association(@"HoSoDuThauReferencesNhaDauTu")]
        [DevExpress.Xpo.DisplayName(@"Chủ Đầu tư")]
        public NhaDauTu ChuDauTu
        {
            get { return fChuDauTu; }
            set { SetPropertyValue<NhaDauTu>("ChuDauTu", ref fChuDauTu, value); }
        }
        int fTienDoThiCong;
        [DevExpress.Xpo.DisplayName(@"Tiến độ thi công")]
        public int TienDoThiCong
        {
            get { return fTienDoThiCong; }
            set { SetPropertyValue<int>("TienDoThiCong", ref fTienDoThiCong, value); }
        }
        Vnb_IPM_2017.Module.BusinessObjects.Enumeration.TinhTrangDuThau fTinhTrang;
        [Indexed(Name = @"tinhtrang_idx")]
        [DevExpress.Xpo.DisplayName(@"Tình trạng")]
        public Vnb_IPM_2017.Module.BusinessObjects.Enumeration.TinhTrangDuThau TinhTrang
        {
            get { return fTinhTrang; }
            set { SetPropertyValue<Vnb_IPM_2017.Module.BusinessObjects.Enumeration.TinhTrangDuThau>("TinhTrang", ref fTinhTrang, value); }
        }
        NhanVien fNguoiDuyet;
        [Association(@"HoSoDuThauReferencesNhanVien")]
        [DevExpress.Xpo.DisplayName(@"Người duyệt")]
        public NhanVien NguoiDuyet
        {
            get { return fNguoiDuyet; }
            set { SetPropertyValue<NhanVien>("NguoiDuyet", ref fNguoiDuyet, value); }
        }
    }

}