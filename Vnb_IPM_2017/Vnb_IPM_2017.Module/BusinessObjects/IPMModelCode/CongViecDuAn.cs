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
    [DefaultClassOptions]
    [ImageName("Achive")]
    [DefaultProperty("TenCongViec")]
    [XafDisplayName("Công việc")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class CongViecDuAn : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public CongViecDuAn(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        private string fmaHieu;
        [XafDisplayName("Mã hiệu")]
        public string MaHieu
        {
            get
            {
                return fmaHieu;
            }
            set
            {
                SetPropertyValue("MaHieu", ref fmaHieu, value);
            }
        }

        private string ftenCongViec;
        [XafDisplayName("Tên công việc")]
        [Size(256)]
        public string TenCongViec
        {
            get
            {
                return ftenCongViec;
            }
            set
            {
                SetPropertyValue("TenCongViec", ref ftenCongViec, value);
            }
        }

        private string fdonVi;
        [XafDisplayName("Đơn vị tính")]
        public string DonVi
        {
            get
            {
                return fdonVi;
            }
            set
            {
                SetPropertyValue("DonVi", ref fdonVi, value);
            }
        }

        private DuAn fduAn;
        [XafDisplayName("Dự án")]
        [Association("DuAn-Chitiets")]
        [ImmediatePostData]
        public DuAn DuAn
        {
            get
            {
                return this.HangMuc == null ? fduAn : HangMuc.DuAn;
            }
            set
            {
                SetPropertyValue("DuAn", ref fduAn, value);
            }
        }

        private HangMucDuAn fhangMuc;
        [XafDisplayName("Hạng mục")]
        [DataSourceCriteria(@"DuAn.Oid = '@This.DuAn.Oid'")]
        public HangMucDuAn HangMuc
        {
            get
            {
                return fhangMuc;
            }
            set
            {
                SetPropertyValue("HangMuc", ref fhangMuc, value);
            }
        }

        private DuToanQuyetToanEnum ftype;
        [XafDisplayName("Kiểu")]
        public DuToanQuyetToanEnum Type
        {
            get
            {
                return ftype;
            }
            set
            {
                SetPropertyValue("Type", ref ftype, value);
            }
        }

        private ChiTietDuAn fchiTietDuAn;
        [Browsable(false)]
        public ChiTietDuAn ChiTietDuAn
        {
            get
            {
                return fchiTietDuAn;
            }
            set
            {
                SetPropertyValue("ChiTietDuAn", ref fchiTietDuAn, value);
            }
        }

        private KhoiLuongDuAn fkhoiLuongDuAn;
        [Browsable(false)]
        public KhoiLuongDuAn KhoiLuongDuAn
        {
            get
            {
                return fkhoiLuongDuAn;
            }
            set
            {
                SetPropertyValue("KhoiLuongDuAn", ref fkhoiLuongDuAn, value);
            }
        }

        #region ChiTietDuAn
        private float fkhoiLuong;
        [XafDisplayName("Khối lượng")]
        [NonPersistent]
        
        public float KhoiLuong
        {
            get
            {
                fkhoiLuong = this.ChiTietDuAn == null ? 0 : this.ChiTietDuAn.KhoiLuong;
                return fkhoiLuong;
            }
            set
            {
                SetPropertyValue("KhoiLuong", ref fkhoiLuong, value);
            }
        }

        private double fdonGiaVatLieu;
        [XafDisplayName("Đơn giá vật liệu")]
        [NonPersistent]
        
        public double DonGiaVatLieu
        {
            get
            {
                fdonGiaVatLieu = this.ChiTietDuAn == null ? 0 : this.ChiTietDuAn.DonGiaVatLieu;
                return fdonGiaVatLieu;
            }
            set
            {
                SetPropertyValue("DonGiaVatLieu", ref fdonGiaVatLieu, value);
            }
        }

        private double fdonGiaNhanCong;
        [NonPersistent]
        [XafDisplayName("Đơn giá nhân công")]
        
        public double DonGiaNhanCong
        {
            get
            {
                fdonGiaNhanCong = this.ChiTietDuAn == null ? 0 : this.ChiTietDuAn.DonGiaNhanCong;
                return fdonGiaNhanCong;
            }
            set
            {
                SetPropertyValue("DonGiaNhanCong", ref fdonGiaNhanCong, value);
            }
        }

        private double fdonGiaMTC;
        [NonPersistent]
        [XafDisplayName("Đơn giá MTC")]
        public double DonGiaMTC
        {
            get
            {
                fdonGiaMTC = this.ChiTietDuAn == null ? 0 : this.ChiTietDuAn.DonGiaMTC;
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
        #endregion
        #region KhoiLuongDuAn

        private float fdai;
        [NonPersistent]
        [XafDisplayName("Dài")]
        public float Dai
        {
            get
            {
                fdai = this.KhoiLuongDuAn == null ? 0 : this.KhoiLuongDuAn.Dai;
                return fdai;
            }
            set
            {
                SetPropertyValue("Dai", ref fdai, value);
            }
        }

        private float frong;
        [NonPersistent]
        [XafDisplayName("Rộng")]
        public float Rong
        {
            get
            {
                frong = this.KhoiLuongDuAn == null ? 0 : this.KhoiLuongDuAn.Rong;
                return frong;
            }
            set
            {
                SetPropertyValue("Rong", ref frong, value);
            }
        }

        private float fcao;
        [NonPersistent]
        [XafDisplayName("Cao")]
        public float Cao
        {
            get
            {
                fcao = this.KhoiLuongDuAn == null ? 0 : this.KhoiLuongDuAn.Cao;
                return fcao;
            }
            set
            {
                SetPropertyValue("Cao", ref fcao, value);
            }
        }

        private float fgiongNhau;
        [NonPersistent]
        [XafDisplayName("Giống nhau")]
        public float GiongNhau
        {
            get
            {
                fgiongNhau = this.KhoiLuongDuAn == null ? 0 : this.KhoiLuongDuAn.GiongNhau;
                return fgiongNhau;
            }
            set
            {
                SetPropertyValue("GiongNhau", ref fgiongNhau, value);
            }
        }

        private double fkhoiLuongThanhPhan;
        [NonPersistent]
        [XafDisplayName("Khối lượng thành phần")]
        public double KhoiLuongThanhPhan
        {
            get
            {
                fkhoiLuongThanhPhan = this.KhoiLuongDuAn == null ? 0 : this.KhoiLuongDuAn.KhoiLuongThanhPhan;
                return fkhoiLuongThanhPhan;
            }
            set
            {
                SetPropertyValue("KhoiLuongThanhPhan", ref fkhoiLuongThanhPhan, value);
            }
        }

        private double fkhoiLuongTongCong;
        [NonPersistent]
        [XafDisplayName("Khối lượng tổng cộng")]
        public double KhoiLuongTongCong
        {
            get
            {
                fkhoiLuongTongCong = this.KhoiLuongDuAn == null ? 0 : this.KhoiLuongDuAn.KhoiLuongTongCong;
                return fkhoiLuongTongCong;
            }
            set
            {
                SetPropertyValue("KhoiLuongTongCong", ref fkhoiLuongTongCong, value);
            }
        }
        #endregion

        protected override void OnSaving()
        {
            base.OnSaving();
            if (this.ChiTietDuAn == null) { 
                ChiTietDuAn chitiet = new ChiTietDuAn(this.Session)
                {
                    CongViec = this,
                    DonGiaMTC = this.fdonGiaMTC,
                    DonGiaNhanCong = this.fdonGiaNhanCong,
                    DonGiaVatLieu = this.fdonGiaVatLieu,
                    KhoiLuong = this.fkhoiLuong,
                };
                this.ChiTietDuAn = chitiet;
            }
            else
            {
                this.ChiTietDuAn.DonGiaMTC = this.fdonGiaMTC;
                this.ChiTietDuAn.DonGiaNhanCong = this.fdonGiaNhanCong;
                this.ChiTietDuAn.DonGiaVatLieu = this.fdonGiaVatLieu;
                this.ChiTietDuAn.KhoiLuong = this.fkhoiLuong;
            }
            if(this.KhoiLuongDuAn == null) { 
                KhoiLuongDuAn khoiluong = new KhoiLuongDuAn(this.Session)
                {
                    CongViec = this,
                    Cao = this.fcao,
                    Dai = this.fdai,
                    Rong = this.frong,
                    GiongNhau = this.fgiongNhau,
                    KhoiLuongThanhPhan = this.fkhoiLuongThanhPhan
                };
                this.KhoiLuongDuAn = khoiluong;
            }
            else
            {
                this.KhoiLuongDuAn.Cao = this.fcao;
                this.KhoiLuongDuAn.Dai = this.fdai;
                this.KhoiLuongDuAn.Rong = this.frong;
                this.KhoiLuongDuAn.GiongNhau = this.fgiongNhau;
                this.KhoiLuongDuAn.KhoiLuongThanhPhan = this.fkhoiLuongThanhPhan;
            }
        }
        protected override void OnDeleting()
        {
            base.OnDeleting();
            this.ChiTietDuAn.Delete();
            this.KhoiLuongDuAn.Delete();
        }
    }
}