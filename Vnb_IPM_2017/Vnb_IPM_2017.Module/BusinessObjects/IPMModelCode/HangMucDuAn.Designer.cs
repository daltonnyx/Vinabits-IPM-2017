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

    public partial class HangMucDuAn : XPObject
    {
        string fTieuDe;
        [DevExpress.Xpo.DisplayName(@"Tiêu đề")]
        public string TieuDe
        {
            get { return fTieuDe; }
            set { SetPropertyValue<string>("TieuDe", ref fTieuDe, value); }
        }
        int fSoLuong;
        [DevExpress.Xpo.DisplayName(@"Số lượng")]
        public int SoLuong
        {
            get { return fSoLuong; }
            set { SetPropertyValue<int>("SoLuong", ref fSoLuong, value); }
        }
        double fTongDauTu;
        [DevExpress.Xpo.DisplayName(@"Tổng mức đầu tư")]
        public double TongDauTu
        {
            get { return fTongDauTu; }
            set { SetPropertyValue<double>("TongDauTu", ref fTongDauTu, value); }
        }
        int fThuTu;
        [Indexed(Name = @"thutu_idx")]
        [DevExpress.Xpo.DisplayName(@"Thứ tự")]
        public int ThuTu
        {
            get { return fThuTu; }
            set { SetPropertyValue<int>("ThuTu", ref fThuTu, value); }
        }
        string fGhiChu;
        [Size(1024)]
        [DevExpress.Xpo.DisplayName(@"Ghi chú")]
        public string GhiChu
        {
            get { return fGhiChu; }
            set { SetPropertyValue<string>("GhiChu", ref fGhiChu, value); }
        }
        DateTime fNgayTao;
        [DevExpress.Xpo.DisplayName(@"Ngày tạo")]
        public DateTime NgayTao
        {
            get { return fNgayTao; }
            set { SetPropertyValue<DateTime>("NgayTao", ref fNgayTao, value); }
        }
        NhanVien fNguoiTao;
        [Association(@"HangMucDuAnReferencesNhanVien")]
        [DevExpress.Xpo.DisplayName(@"Người tạo")]
        public NhanVien NguoiTao
        {
            get { return fNguoiTao; }
            set { SetPropertyValue<NhanVien>("NguoiTao", ref fNguoiTao, value); }
        }
        DateTime fNgayCapNhat;
        [DevExpress.Xpo.DisplayName(@"Ngày cập nhật")]
        public DateTime NgayCapNhat
        {
            get { return fNgayCapNhat; }
            set { SetPropertyValue<DateTime>("NgayCapNhat", ref fNgayCapNhat, value); }
        }
        string fNoiDung;
        [Size(SizeAttribute.Unlimited)]
        [DevExpress.Xpo.DisplayName(@"Nội dung")]
        public string NoiDung
        {
            get { return fNoiDung; }
            set { SetPropertyValue<string>("NoiDung", ref fNoiDung, value); }
        }
        DuAn fDuAn;
        [Indexed(Name = @"duanIdx")]
        [Association(@"HangMucDuAnReferencesDuAn")]
        [DevExpress.Xpo.DisplayName(@"Dự án")]
        public DuAn DuAn
        {
            get { return fDuAn; }
            set { SetPropertyValue<DuAn>("DuAn", ref fDuAn, value); }
        }
        string fTienDo;
        [DevExpress.Xpo.DisplayName(@"Tiến độ")]
        public string TienDo
        {
            get { return fTienDo; }
            set { SetPropertyValue<string>("TienDo", ref fTienDo, value); }
        }
    }

}
