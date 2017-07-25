using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;

namespace Vnb_IPM_2017.Module.BusinessObjects
{
    
    public partial class ThanhToan
    {
        public ThanhToan(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
