using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vnb_IPM_2017.Module.BusinessObjects.NonPersistents
{
    [DomainComponent, VisibleInReportsAttribute]
    public class DuAnReportObject
    {
        [DevExpress.Xpo.DisplayName(@"Tên dự án")]
        public string TenDuAn
        {
            get;
            set;
        }
        [DevExpress.Xpo.DisplayName(@"Mã Dự án")]
        public string MaDuAn
        {
            get;
            set;
        }
        [DevExpress.Xpo.DisplayName(@"Bắt đầu")]
        public short BatDau
        {
            get;
            set;
        }
        [DevExpress.Xpo.DisplayName(@"Kết thúc")]
        public short KetThuc
        {
            get;
            set;
        }
        [DevExpress.Xpo.DisplayName(@"Tổng mức đầu tư")]
        public double TongMucDauTu
        {
            get;
            set;
        }
        [DevExpress.Xpo.DisplayName(@"Giá trị quyết toán")]
        public double QuyetToan
        {
            get;
            set;
        }
        [DevExpress.Xpo.DisplayName(@"Mức độ ưu tiên")]
        public Vnb_IPM_2017.Module.BusinessObjects.Enumeration.PriorityEnum UuTien
        {
            get;
            set;
        }
        [DevExpress.Xpo.DisplayName(@"Trạng thái")]
        public Vnb_IPM_2017.Module.BusinessObjects.Enumeration.ProjectStatusEnum TrangThai
        {
            get;
            set;
        }
        [DevExpress.Xpo.DisplayName(@"Nội dung")]
        public string NoiDung
        {
            get;
            set;
        }
        [DevExpress.Xpo.DisplayName(@"Phân loại")]
        public LoaiDuAn LoaiDuAn
        {
            get;
            set;
        }
        [DevExpress.Xpo.DisplayName(@"Trưởng dự án")]
        public NhanVien TruongDuAn
        {
            get;
            set;
        }
        [DevExpress.Xpo.DisplayName(@"Hạng mục dự án")]

        public string HangMucDuAns {
            get;
            set;
        }

        [DevExpress.Xpo.DisplayName(@"Tiến độ")]
        public int TienDo
        {
            get;
            set;
        }

        [DevExpress.Xpo.DisplayName(@"Gói thầu")]
        public string GoiThaus {
            get;
            set;
        }
    }
}
