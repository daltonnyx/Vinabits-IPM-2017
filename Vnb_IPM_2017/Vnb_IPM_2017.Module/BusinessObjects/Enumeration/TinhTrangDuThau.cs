using DevExpress.ExpressApp.DC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vnb_IPM_2017.Module.BusinessObjects.Enumeration
{
    public enum TinhTrangDuThau
    {
        [XafDisplayName("Đang chờ xét duyệt")]
        ChoDuyet = 0,
        [XafDisplayName("Đang xét duyệt")]
        DangXetDuyet = 1,
        [XafDisplayName("Được duyệt")]
        Duyet = 3,
        [XafDisplayName("Bị loại")]
        Loai = 4,
        [XafDisplayName("Đã hủy")]
        Huy = 5
    }
}
