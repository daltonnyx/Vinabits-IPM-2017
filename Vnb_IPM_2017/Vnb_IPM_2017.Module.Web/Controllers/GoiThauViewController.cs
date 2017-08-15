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
using Vnb_IPM_2017.Module.BusinessObjects.Enumeration;

namespace Vnb_IPM_2017.Module.Web.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class GoiThauViewController : ViewController
    {

        IObjectSpace objspc;

        public GoiThauViewController()
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

        private void addHoSoDuThau_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            objspc = Application.CreateObjectSpace();
            HoSoDuThau hoso = objspc.CreateObject<HoSoDuThau>();
            hoso.GoiThau = objspc.GetObject<GoiThau>(View.CurrentObject as GoiThau);
            hoso.NgayNopHS = DateTime.Now;
            //hoso.NguoiDuyet = objspc.GetObject<NhanVien>(SecuritySystem.CurrentUser as NhanVien);
            DetailView dtView = Application.CreateDetailView(objspc, hoso);
            e.View = dtView;
            e.Maximized = true;
        }

        private void addHoSoDuThau_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
            if (objspc != null)
                objspc.CommitChanges();
            View.ObjectSpace.Refresh();
        }

        private void changeStatus_Execute(object sender, SingleChoiceActionExecuteEventArgs e)
        {
            int status = Convert.ToInt16(e.SelectedChoiceActionItem.Data);
            GoiThau goiThau = View.CurrentObject as GoiThau;
            goiThau.TinhTrang = (TinhTrangGoiThau)status;
            View.ObjectSpace.CommitChanges();
            View.ObjectSpace.Refresh();
        }
    }
}
