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
using Vnb_IPM_2017.Module.BusinessObjects;

namespace Vnb_IPM_2017.Module.Web.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class DuAnViewController : ViewController
    {
        IObjectSpace objspc;
        public DuAnViewController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void addHangMuc_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            
            objspc = Application.CreateObjectSpace();
            
            HangMucDuAn hangmuc = objspc.CreateObject<HangMucDuAn>();
            DuAn DuAn = View.CurrentObject as DuAn;
            hangmuc.DuAn = objspc.GetObject<DuAn>(DuAn);
            hangmuc.ThuTu = DuAn.HangMucDuAns.Count + 1;
            hangmuc.NgayCapNhat = hangmuc.NgayTao = DateTime.Now;
            hangmuc.NguoiTao = objspc.GetObject<NhanVien>(SecuritySystem.CurrentUser as NhanVien);
            DetailView dtview = Application.CreateDetailView(objspc, hangmuc);
            e.View = dtview;
            e.Maximized = true;
        }

        private void addHangMuc_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
            if(objspc != null)
            {
                objspc.CommitChanges();
            }
            View.ObjectSpace.Refresh();
        }

        private void addGoiThau_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
            if (objspc != null)
            {
                objspc.CommitChanges();
            }
            View.ObjectSpace.Refresh();
        }

        private void addGoiThau_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            objspc = Application.CreateObjectSpace();
            GoiThau goithau = objspc.CreateObject<GoiThau>();
            DuAn DuAn = View.CurrentObject as DuAn;
            goithau.DuAn = objspc.GetObject<DuAn>(DuAn);
            DetailView dtview = Application.CreateDetailView(objspc, goithau);
            e.View = dtview;
            e.Maximized = true;
        }

        private void addChiTiet_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            objspc = Application.CreateObjectSpace();
            CongViecDuAn dutoan = objspc.CreateObject<CongViecDuAn>();
            DuAn DuAn = View.CurrentObject as DuAn;
            dutoan.DuAn = objspc.GetObject<DuAn>(DuAn);
            dutoan.Type = BusinessObjects.Enumeration.DuToanQuyetToanEnum.DuToan;
            DetailView dtview = Application.CreateDetailView(objspc, dutoan);
            e.View = dtview;
            e.Maximized = true;
        }

        private void addChiTiet_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
            if (objspc != null)
            {
                objspc.CommitChanges();
            }
            View.ObjectSpace.Refresh();
        }
    }
}
