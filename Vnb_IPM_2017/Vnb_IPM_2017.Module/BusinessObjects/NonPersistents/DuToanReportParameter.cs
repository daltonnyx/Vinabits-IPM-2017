using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.ReportsV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using Vnb_IPM_2017.Module.BusinessObjects.Enumeration;

namespace Vnb_IPM_2017.Module.BusinessObjects.NonPersistents
{
    [DomainComponent]
    public class DuToanReportParameter : ReportParametersObjectBase
    {
        public DuToanReportParameter(IObjectSpaceCreator objectSpaceCreator) : base(objectSpaceCreator)
        {
        }

        [XafDisplayName("Dự án")]
        public DuAn DuAn
        {
            get;set;
        }

        public override CriteriaOperator GetCriteria()
        {
            return CriteriaOperator.And(new BinaryOperator("DuAn.Oid", DuAn.Oid),new BinaryOperator("Type", DuToanQuyetToanEnum.DuToan));
        }

        public override SortProperty[] GetSorting()
        {
            List<SortProperty> sorting = new List<SortProperty>();
            sorting.Add(new SortProperty("TenCongViec", SortingDirection.Ascending));
            return sorting.ToArray();
        }

        protected override IObjectSpace CreateObjectSpace()
        {
            return objectSpaceCreator.CreateObjectSpace(typeof(CongViecDuAn));
        }
    }

    [DomainComponent]
    public class QuyetToanReportParameter : ReportParametersObjectBase
    {
        public QuyetToanReportParameter(IObjectSpaceCreator objectSpaceCreator) : base(objectSpaceCreator)
        {
        }

        [XafDisplayName("Dự án")]
        public DuAn DuAn
        {
            get; set;
        }

        public override CriteriaOperator GetCriteria()
        {
            return CriteriaOperator.And(new BinaryOperator("DuAn.Oid", DuAn.Oid), new BinaryOperator("Type", DuToanQuyetToanEnum.QuyetToan));
        }

        public override SortProperty[] GetSorting()
        {
            List<SortProperty> sorting = new List<SortProperty>();
            sorting.Add(new SortProperty("TenCongViec", SortingDirection.Ascending));
            return sorting.ToArray();
        }

        protected override IObjectSpace CreateObjectSpace()
        {
            return objectSpaceCreator.CreateObjectSpace(typeof(CongViecDuAn));
        }
    }
}
