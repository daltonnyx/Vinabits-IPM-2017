using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using Vnb_IPM_2017.Module.BusinessObjects.Enumeration;

namespace Vnb_IPM_2017.Module.BusinessObjects
{
    //[DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class ChiTietDuAn : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public ChiTietDuAn(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private float fkhoiLuong;
        [XafDisplayName("Khối lượng")]
        public float KhoiLuong
        {
            get
            {
                return fkhoiLuong;
            }
            set
            {
                SetPropertyValue("KhoiLuong", ref fkhoiLuong, value);
            }
        }
        private double fdonGiaVatLieu;
        [XafDisplayName("Đơn giá vật liệu")]
        public double DonGiaVatLieu
        {
            get
            {
                return fdonGiaVatLieu;
            }
            set
            {
                SetPropertyValue("DonGiaVatLieu", ref fdonGiaVatLieu, value);
            }
        }
        private double fdonGiaNhanCong;
        [XafDisplayName("Đơn giá nhân công")]
        public double DonGiaNhanCong
        {
            get
            {
                return fdonGiaNhanCong;
            }
            set
            {
                SetPropertyValue("DonGiaNhanCong", ref fdonGiaNhanCong, value);
            }
        }
        private double fdonGiaMTC;
        [XafDisplayName("Đơn giá MTC")]
        public double DonGiaMTC
        {
            get
            {
                return fdonGiaMTC;
            }
            set
            {
                SetPropertyValue("DonGiaMTC", ref fdonGiaMTC, value);
            }
        }
        [XafDisplayName("Thành tiền vật liệu")]
        [NonPersistent]
        public double ThanhTienVatLieu
        {
            get
            {
                return this.DonGiaNhanCong * this.KhoiLuong;
            }
        }
        [XafDisplayName("Thành tiền nhân công")]
        [NonPersistent]
        public double ThanhTienNhanCong
        {
            get
            {
                return this.DonGiaNhanCong * this.KhoiLuong;
            }
        }
        [XafDisplayName("Thành tiền MTC")]
        [NonPersistent]
        public double ThanhTienMTC
        {
            get
            {
                return this.DonGiaMTC * this.KhoiLuong;
            }
        }

        private CongViecDuAn fcongViec;
        [Browsable(false)]
        public CongViecDuAn CongViec
        {
            get
            {
                return fcongViec;
            }
            set
            {
                SetPropertyValue("CongViec", ref fcongViec, value);
            }
        }
    }
}