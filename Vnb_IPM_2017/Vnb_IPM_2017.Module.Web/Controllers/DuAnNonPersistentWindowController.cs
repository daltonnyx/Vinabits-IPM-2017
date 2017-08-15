using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using Vnb_IPM_2017.Module.BusinessObjects.NonPersistents;
using System.ComponentModel;
using Vnb_IPM_2017.Module.BusinessObjects;

namespace Vnb_IPM_2017.Module.Web.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppWindowControllertopic.aspx.
    public partial class DuAnNonPersistentWindowController : WindowController
    {
        public DuAnNonPersistentWindowController()
        {
            InitializeComponent();
            // Target required Windows (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target Window.
            Application.ObjectSpaceCreated += Application_ObjectSpaceCreated;
        }

        private void Application_ObjectSpaceCreated(object sender, ObjectSpaceCreatedEventArgs e)
        {
            if(e.ObjectSpace is NonPersistentObjectSpace)
            {
                ((NonPersistentObjectSpace)e.ObjectSpace).ObjectsGetting += DuAnNonPersistentWindowController_ObjectsGetting;
            }
        }

        private void DuAnNonPersistentWindowController_ObjectsGetting(object sender, ObjectsGettingEventArgs e)
        {
            if(e.ObjectType.Name == "DuAnReportObject") { 
                BindingList<DuAnReportObject> objects = new BindingList<DuAnReportObject>();
                IObjectSpace objspc = Application.CreateObjectSpace();
                IList<DuAn> duans = objspc.GetObjects<DuAn>();
                foreach(DuAn duan in duans)
                {
                    string hang_muc = string.Join(", ",duan.HangMucDuAns.Select<HangMucDuAn, string>(hangmuc => hangmuc.TieuDe));
                    int avgTienDo = duan.HangMucDuAns.Sum(hangmuc => hangmuc.TienDo) / duan.HangMucDuAns.Count;
                    objects.Add(new DuAnReportObject()
                    {
                        MaDuAn = duan.MaDuAn,
                        TenDuAn = duan.TenDuAn,
                        LoaiDuAn = duan.LoaiDuAn,
                        TrangThai = duan.TrangThai,
                        HangMucDuAns = hang_muc,
                        TienDo = avgTienDo,
                        TongMucDauTu = duan.TongMucDauTu,
                        BatDau = duan.BatDau,
                        KetThuc = duan.KetThuc,
                        QuyetToan = duan.QuyetToan,
                        TruongDuAn = duan.TruongDuAn,
                    
                    });
                }
                e.Objects = objects;
            }
        }

        protected override void OnDeactivated()
        {
            Application.ObjectSpaceCreated -= Application_ObjectSpaceCreated;
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}
