using DevExpress.ExpressApp.DC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vnb_IPM_2017.Module.BusinessObjects.Enumeration
{
    public enum ProjectStatusEnum
    {
        [XafDisplayName("Chuẩn bị đầu tư")]
        preparing = 0,
        [XafDisplayName("Đang thực hiện")]
        processing = 1,
        [XafDisplayName("Kết thúc đầu tư")]
        finishing = 2,
        [XafDisplayName("Đóng")]
        closed = 3,
        [XafDisplayName("Dừng thực hiện")]
        stopped = 4,
    }
}
