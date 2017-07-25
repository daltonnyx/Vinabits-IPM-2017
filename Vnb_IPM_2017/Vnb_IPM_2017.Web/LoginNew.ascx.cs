using System;
using System.Collections.Generic;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Web.Controls;
using DevExpress.ExpressApp.Web.Templates;
namespace Vnb_IPM_2017.Web
{
    public partial class LoginNew : TemplateContent, IXafPopupWindowControlContainer
    {
        public override void SetStatus(ICollection<string> statusMessages)
        {
        }
        public override IActionContainer DefaultContainer
        {
            get { return null; }
        }
        public override object ViewSiteControl
        {
            get { return viewSiteControl; }
        }
        public XafPopupWindowControl XafPopupWindowControl
        {
            get { return PopupWindowControl; }
        }
        public override void BeginUpdate()
        {
            base.BeginUpdate();
            this.PopupActions.BeginUpdate();
        }
        public override void EndUpdate()
        {
            this.PopupActions.EndUpdate();
            base.EndUpdate();
        }
        //public ThemedImageControl HeaderImageControl { get { return TIC; } }
    }
}
