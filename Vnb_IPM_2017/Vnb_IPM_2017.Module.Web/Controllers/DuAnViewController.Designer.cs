namespace Vnb_IPM_2017.Module.Web.Controllers
{
    partial class DuAnViewController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addHangMuc = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            this.addGoiThau = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            this.addChiTiet = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            // 
            // addHangMuc
            // 
            this.addHangMuc.AcceptButtonCaption = null;
            this.addHangMuc.CancelButtonCaption = null;
            this.addHangMuc.Caption = "Thêm Hạng mục";
            this.addHangMuc.ConfirmationMessage = null;
            this.addHangMuc.Id = "addHangMuc";
            this.addHangMuc.TargetObjectType = typeof(Vnb_IPM_2017.Module.BusinessObjects.DuAn);
            this.addHangMuc.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.addHangMuc.ToolTip = null;
            this.addHangMuc.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.addHangMuc.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.addHangMuc_CustomizePopupWindowParams);
            this.addHangMuc.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.addHangMuc_Execute);
            // 
            // addGoiThau
            // 
            this.addGoiThau.AcceptButtonCaption = null;
            this.addGoiThau.CancelButtonCaption = null;
            this.addGoiThau.Caption = "Thêm gói thầu";
            this.addGoiThau.ConfirmationMessage = null;
            this.addGoiThau.Id = "addGoiThau";
            this.addGoiThau.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.addGoiThau.ToolTip = null;
            this.addGoiThau.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.addGoiThau.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.addGoiThau_CustomizePopupWindowParams);
            this.addGoiThau.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.addGoiThau_Execute);
            // 
            // addChiTiet
            // 
            this.addChiTiet.AcceptButtonCaption = null;
            this.addChiTiet.CancelButtonCaption = null;
            this.addChiTiet.Caption = "Thêm dự toán";
            this.addChiTiet.ConfirmationMessage = null;
            this.addChiTiet.Id = "addChiTiet";
            this.addChiTiet.ToolTip = null;
            this.addChiTiet.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.addChiTiet_CustomizePopupWindowParams);
            this.addChiTiet.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.addChiTiet_Execute);
            // 
            // DuAnViewController
            // 
            this.Actions.Add(this.addHangMuc);
            this.Actions.Add(this.addGoiThau);
            this.Actions.Add(this.addChiTiet);
            this.TargetObjectType = typeof(Vnb_IPM_2017.Module.BusinessObjects.DuAn);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.PopupWindowShowAction addHangMuc;
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction addGoiThau;
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction addChiTiet;
    }
}
