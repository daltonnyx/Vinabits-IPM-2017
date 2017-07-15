using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Vnb_IPM_2017.Module.BusinessObjects
{

    public partial class GoiThau
    {
        public GoiThau(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
