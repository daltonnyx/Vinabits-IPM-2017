using DevExpress.ExpressApp.DC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vnb_IPM_2017.Module.BusinessObjects.Enumeration
{
    public enum PriorityEnum
    {
        [XafDisplayName("Rất thấp")]
        verylow = 0,
        [XafDisplayName("Thấp")]
        low = 1,
        [XafDisplayName("Trung bình")]
        medium = 2,
        [XafDisplayName("Cao")]
        high = 3,
        [XafDisplayName("Rất cao")]
        veryhigh = 4
    }
}
