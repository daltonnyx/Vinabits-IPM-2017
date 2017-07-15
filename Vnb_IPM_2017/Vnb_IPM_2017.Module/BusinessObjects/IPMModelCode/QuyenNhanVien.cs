using System;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Security.Strategy;

namespace Vnb_IPM_2017.Module.BusinessObjects
{

    public class QuyenNhanVien : SecuritySystemRoleBase
    {

        public QuyenNhanVien(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }


        [Association("NhanViens-QuyenNhanViens")]
        public XPCollection<NhanVien> NhanViens
        {
            get
            {
                return GetCollection<NhanVien>("NhanViens");
            }
        }
    }

}