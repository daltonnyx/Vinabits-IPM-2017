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
namespace Vnb_IPM_2017.Module.BusinessObjects.IPMModel
{

    public partial class KeHoachDauThau : XPObject
    {
        string fTieuDe;
        public string TieuDe
        {
            get { return fTieuDe; }
            set { SetPropertyValue<string>("TieuDe", ref fTieuDe, value); }
        }
        GoiThau fGoiThau;
        public GoiThau GoiThau
        {
            get { return fGoiThau; }
            set { SetPropertyValue<GoiThau>("GoiThau", ref fGoiThau, value); }
        }
        string fHinhThuc;
        public string HinhThuc
        {
            get { return fHinhThuc; }
            set { SetPropertyValue<string>("HinhThuc", ref fHinhThuc, value); }
        }
        string fPhuongThuc;
        public string PhuongThuc
        {
            get { return fPhuongThuc; }
            set { SetPropertyValue<string>("PhuongThuc", ref fPhuongThuc, value); }
        }
        string fNgayDuyet;
        public string NgayDuyet
        {
            get { return fNgayDuyet; }
            set { SetPropertyValue<string>("NgayDuyet", ref fNgayDuyet, value); }
        }
    }

}