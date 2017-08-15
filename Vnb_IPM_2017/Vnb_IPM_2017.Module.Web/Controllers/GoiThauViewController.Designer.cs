namespace Vnb_IPM_2017.Module.Web.Controllers
{
    partial class GoiThauViewController
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
            DevExpress.ExpressApp.Actions.ChoiceActionItem choiceActionItem1 = new DevExpress.ExpressApp.Actions.ChoiceActionItem();
            DevExpress.ExpressApp.Actions.ChoiceActionItem choiceActionItem2 = new DevExpress.ExpressApp.Actions.ChoiceActionItem();
            DevExpress.ExpressApp.Actions.ChoiceActionItem choiceActionItem3 = new DevExpress.ExpressApp.Actions.ChoiceActionItem();
            DevExpress.ExpressApp.Actions.ChoiceActionItem choiceActionItem4 = new DevExpress.ExpressApp.Actions.ChoiceActionItem();
            DevExpress.ExpressApp.Actions.ChoiceActionItem choiceActionItem5 = new DevExpress.ExpressApp.Actions.ChoiceActionItem();
            DevExpress.ExpressApp.Actions.ChoiceActionItem choiceActionItem6 = new DevExpress.ExpressApp.Actions.ChoiceActionItem();
            this.addHoSoDuThau = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            this.changeStatus = new DevExpress.ExpressApp.Actions.SingleChoiceAction(this.components);
            // 
            // addHoSoDuThau
            // 
            this.addHoSoDuThau.AcceptButtonCaption = "Thêm";
            this.addHoSoDuThau.CancelButtonCaption = "Hủy";
            this.addHoSoDuThau.Caption = "Nộp HS Dự thầu";
            this.addHoSoDuThau.Category = "Edit";
            this.addHoSoDuThau.ConfirmationMessage = null;
            this.addHoSoDuThau.Id = "addHoSoDuThau";
            this.addHoSoDuThau.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.addHoSoDuThau.ToolTip = null;
            this.addHoSoDuThau.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.addHoSoDuThau.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.addHoSoDuThau_CustomizePopupWindowParams);
            this.addHoSoDuThau.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.addHoSoDuThau_Execute);
            // 
            // changeStatus
            // 
            this.changeStatus.Caption = "Cập nhật trạng thái";
            this.changeStatus.Category = "Edit";
            this.changeStatus.ConfirmationMessage = null;
            this.changeStatus.Id = "changeStatus";
            choiceActionItem1.Caption = "Đang chuẩn bị";
            choiceActionItem1.Data = "0";
            choiceActionItem1.ImageName = null;
            choiceActionItem1.Shortcut = null;
            choiceActionItem1.ToolTip = null;
            choiceActionItem2.Caption = "Mời thầu";
            choiceActionItem2.Data = "1";
            choiceActionItem2.ImageName = null;
            choiceActionItem2.Shortcut = null;
            choiceActionItem2.ToolTip = null;
            choiceActionItem3.Caption = "Dự thầu";
            choiceActionItem3.Data = "2";
            choiceActionItem3.ImageName = null;
            choiceActionItem3.Shortcut = null;
            choiceActionItem3.ToolTip = null;
            choiceActionItem4.Caption = "Mở thầu";
            choiceActionItem4.Data = "3";
            choiceActionItem4.ImageName = null;
            choiceActionItem4.Shortcut = null;
            choiceActionItem4.ToolTip = null;
            choiceActionItem5.Caption = "Chấm thầu";
            choiceActionItem5.Data = "4";
            choiceActionItem5.ImageName = null;
            choiceActionItem5.Shortcut = null;
            choiceActionItem5.ToolTip = null;
            choiceActionItem6.Caption = "Ký hợp đồng";
            choiceActionItem6.Data = "5";
            choiceActionItem6.ImageName = null;
            choiceActionItem6.Shortcut = null;
            choiceActionItem6.ToolTip = null;
            this.changeStatus.Items.Add(choiceActionItem1);
            this.changeStatus.Items.Add(choiceActionItem2);
            this.changeStatus.Items.Add(choiceActionItem3);
            this.changeStatus.Items.Add(choiceActionItem4);
            this.changeStatus.Items.Add(choiceActionItem5);
            this.changeStatus.Items.Add(choiceActionItem6);
            this.changeStatus.ItemType = DevExpress.ExpressApp.Actions.SingleChoiceActionItemType.ItemIsOperation;
            this.changeStatus.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.changeStatus.ToolTip = null;
            this.changeStatus.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.changeStatus.Execute += new DevExpress.ExpressApp.Actions.SingleChoiceActionExecuteEventHandler(this.changeStatus_Execute);
            // 
            // GoiThauViewController
            // 
            this.Actions.Add(this.addHoSoDuThau);
            this.Actions.Add(this.changeStatus);
            this.TargetObjectType = typeof(Vnb_IPM_2017.Module.BusinessObjects.GoiThau);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.PopupWindowShowAction addHoSoDuThau;
        private DevExpress.ExpressApp.Actions.SingleChoiceAction changeStatus;
    }
}
