using DevExpress.ExpressApp.DC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vnb_IPM_2017.Module.BusinessObjects.Enumeration
{
    public enum TinhTrangGoiThau
    {
        [XafDisplayName("Đang chuẩn bị")]
        DangChuanBi = 0,
        [XafDisplayName("Mời thầu")]
        MoiThau = 2,
        [XafDisplayName("Dự thầu")]
        DuThau = 3,
        [XafDisplayName("Mở thầu")]
        MoThau = 4,
        [XafDisplayName("Chấm thầu")]
        ChamThau = 5,
        [XafDisplayName("Ký hợp đồng")]
        KyHopDong = 6,
    }
}
