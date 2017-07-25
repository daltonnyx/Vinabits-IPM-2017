using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;

namespace Vnb_IPM_2017.Module.BusinessObjects
{
    [XafDefaultProperty("TieuDe")]
    public partial class HinhThucThanhToan
    {
        public HinhThucThanhToan(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
