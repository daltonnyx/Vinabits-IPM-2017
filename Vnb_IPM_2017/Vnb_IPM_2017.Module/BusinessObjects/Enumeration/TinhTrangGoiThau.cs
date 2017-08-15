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
        MoiThau = 1,
        [XafDisplayName("Dự thầu")]
        DuThau = 2,
        [XafDisplayName("Mở thầu")]
        MoThau = 3,
        [XafDisplayName("Chấm thầu")]
        ChamThau = 4,
        [XafDisplayName("Ký hợp đồng")]
        KyHopDong = 5,
    }
}
