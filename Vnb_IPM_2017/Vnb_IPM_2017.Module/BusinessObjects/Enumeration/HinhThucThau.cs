using DevExpress.ExpressApp.DC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vnb_IPM_2017.Module.BusinessObjects.Enumeration
{
    public enum HinhThucThau
    {
        [XafDisplayName("Đấu thầu rộng rãi")]
        RongRai = 0,
        [XafDisplayName("Đấu thầu hạn chế")]
        HanChe = 1,
        [XafDisplayName("Chỉ định thầu")]
        ChiDinh = 2,
        [XafDisplayName("Mua sắm trực tiếp")]
        MuaSam = 3,
        [XafDisplayName("Chào hàng cạnh tranh trong mua sắm hàng hóa")]
        ChaoHang = 4,
        [XafDisplayName("Tự thực hiện")]
        TuThucHien = 5,
        [XafDisplayName("Lựa chọn nhà thầu trong trường hợp đặc biệt")]
        LuaChon = 6
    }
}
