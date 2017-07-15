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
    public partial class HoSoMoiThau : FleAttachments
    {
        string fTieuDe;
        [Indexed(Name = @"tieude_idx")]
        [DevExpress.Xpo.DisplayName(@"Tiêu đề")]
        public string TieuDe
        {
            get { return fTieuDe; }
            set { SetPropertyValue<string>("TieuDe", ref fTieuDe, value); }
        }
        GoiThau fGoiThau;
        [Indexed(Name = @"goithau_idx")]
        [Association(@"HoSoMoiThauReferencesGoiThau")]
        [DevExpress.Xpo.DisplayName(@"Gói thầu")]
        public GoiThau GoiThau
        {
            get { return fGoiThau; }
            set { SetPropertyValue<GoiThau>("GoiThau", ref fGoiThau, value); }
        }
        string fNoiDung;
        [Size(SizeAttribute.Unlimited)]
        [DevExpress.Xpo.DisplayName(@"Nội dung")]
        public string NoiDung
        {
            get { return fNoiDung; }
            set { SetPropertyValue<string>("NoiDung", ref fNoiDung, value); }
        }
        DateTime fNgayBatDau;
        [DevExpress.Xpo.DisplayName(@"Ngày bắt đầu")]
        public DateTime NgayBatDau
        {
            get { return fNgayBatDau; }
            set { SetPropertyValue<DateTime>("NgayBatDau", ref fNgayBatDau, value); }
        }
        DateTime fNgayDuyet;
        [DevExpress.Xpo.DisplayName(@"Ngày bắt đầu")]
        public DateTime NgayDuyet
        {
            get { return fNgayDuyet; }
            set { SetPropertyValue<DateTime>("NgayDuyet", ref fNgayDuyet, value); }
        }
        DateTime fNgayPhatHanh;
        [DevExpress.Xpo.DisplayName(@"Ngày phát hành")]
        public DateTime NgayPhatHanh
        {
            get { return fNgayPhatHanh; }
            set { SetPropertyValue<DateTime>("NgayPhatHanh", ref fNgayPhatHanh, value); }
        }
        NhanVien fNguoiKy;
        [Indexed(Name = @"nguoiduyet_idx")]
        [DevExpress.Xpo.DisplayName(@"Người ký")]
        public NhanVien NguoiKy
        {
            get { return fNguoiKy; }
            set { SetPropertyValue<NhanVien>("NguoiKy", ref fNguoiKy, value); }
        }
    }

}