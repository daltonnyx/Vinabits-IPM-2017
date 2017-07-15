using DevExpress.ExpressApp.DC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vnb_IPM_2017.Module.BusinessObjects.Enumeration
{
    public enum PhuongThucThau
    {
        [XafDisplayName("Một túi hồ sơ")]
        MotTuiHoSo = 0,
        [XafDisplayName("Hai túi hồ sơ")]
        HaiTuiHoSo = 1,
        [XafDisplayName("Hai giai đoạn")]
        HaiGiaiDoan = 2
    }
}
