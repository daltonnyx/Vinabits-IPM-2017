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

namespace Vnb_IPM_2017.Module.BusinessObjects
{
    //[DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class KhoiLuongDuAn : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public KhoiLuongDuAn(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        #region KichThuoc
        private float fdai;
        [XafDisplayName("Dài")]
        public float Dai
        {
            get
            {
                return fdai;
            }
            set
            {
                SetPropertyValue("Dai", ref fdai, value);
            }
        }

        private float frong;
        [XafDisplayName("Rộng")]
        public float Rong
        {
            get
            {
                return frong;
            }
            set
            {
                SetPropertyValue("Rong", ref frong, value);
            }
        }

        private float fcao;
        [XafDisplayName("Cao")]
        public float Cao
        {
            get
            {
                return fcao;
            }
            set
            {
                SetPropertyValue("Cao", ref fcao, value);
            }
        }
        #endregion

        private float fgiongNhau;
        [XafDisplayName("Giống nhau")]
        public float GiongNhau
        {
            get
            {
                return fgiongNhau;
            }
            set
            {
                SetPropertyValue("GiongNhau", ref fgiongNhau, value);
            }
        }

        private double fkhoiLuongThanhPhan;
        [XafDisplayName("Khối lượng thành phần")]
        public double KhoiLuongThanhPhan
        {
            get
            {
                return fkhoiLuongThanhPhan;
            }
            set
            {
                SetPropertyValue("KhoiLuongThanhPhan", ref fkhoiLuongThanhPhan, value);
            }
        }

        private double fkhoiLuongTongCong;
        [XafDisplayName("Khối lượng tổng cộng")]
        public double KhoiLuongTongCong
        {
            get
            {
                return fkhoiLuongTongCong;
            }
            set
            {
                SetPropertyValue("KhoiLuongTongCong", ref fkhoiLuongTongCong, value);
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