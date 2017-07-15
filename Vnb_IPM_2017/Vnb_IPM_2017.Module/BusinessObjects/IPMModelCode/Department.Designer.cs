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
    public partial class PhongBan : XPObject
    {
        string fTenDayDu;
        [DevExpress.Xpo.DisplayName(@"Tên phòng ban")]
        public string TenDayDu
        {
            get { return fTenDayDu; }
            set { SetPropertyValue<string>("TenDayDu", ref fTenDayDu, value); }
        }
        string fVanPhong;
        [DevExpress.Xpo.DisplayName(@"Văn phòng")]
        public string VanPhong
        {
            get { return fVanPhong; }
            set { SetPropertyValue<string>("VanPhong", ref fVanPhong, value); }
        }
        PhongBan fDonviCapTren;
        [Association(@"PhongBanReferencesPhongBan")]
        [DevExpress.Xpo.DisplayName(@"Cấp trên")]
        public PhongBan DonviCapTren
        {
            get { return fDonviCapTren; }
            set { SetPropertyValue<PhongBan>("DonviCapTren", ref fDonviCapTren, value); }
        }
        [DevExpress.Xpo.DisplayName(@"Nhân viên")]
        [Association(@"NhanVienReferencesPhongBan")]
        public XPCollection<NhanVien> NhanViens { get { return GetCollection<NhanVien>("NhanViens"); } }
        [DevExpress.Xpo.DisplayName(@"Đơn vi con")]
        [Association(@"PhongBanReferencesPhongBan")]
        public XPCollection<PhongBan> PhongBans { get { return GetCollection<PhongBan>("PhongBans"); } }
    }

}
