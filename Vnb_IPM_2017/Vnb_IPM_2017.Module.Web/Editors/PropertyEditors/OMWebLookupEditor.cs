using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Web.Editors.ASPx;
using DevExpress.Web;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Vnb_IPM_2017.Module.BusinessObjects;

namespace Vnb_IPM_2017.Module.Web.PropertyEditors
{
    [PropertyEditor(typeof(Vnb_IPM_2017.Module.BusinessObjects.HinhThucThanhToan), "OMWebLookupEditor", false)]
    public class OMWebLookupEditor : ASPxLookupPropertyEditor
    {
        private const string STR_NullText = "";
        public OMWebLookupEditor(Type objectType, IModelMemberViewItem model)
            : base(objectType, model) {
        }
        protected override void CreateControlItems(object currentSelectedObject, System.Collections.ArrayList list, ASPxComboBox control, DevExpress.ExpressApp.Web.Editors.WebLookupEditorHelper helper)
        {
            base.CreateControlItems(currentSelectedObject, list, control, helper);
            control.IncrementalFilteringMode = DevExpress.Web.IncrementalFilteringMode.Contains;
            control.DropDownStyle = DevExpress.Web.DropDownStyle.DropDown;
            control.NullText = STR_NullText;
            var nullTextItem = control.Items.FindByText(this.NullText);
            if (nullTextItem != null)
            {
                nullTextItem.Text = STR_NullText;
            }
        }

        protected override void OnValueStored()
        {
            base.OnValueStored();
            //Tạo mới Nơi phát hành nếu chưa tồn tại
            if (View is DetailView && ((DetailView)View).ViewEditMode == ViewEditMode.Edit)
            {
                ASPxComboBox control = this.DropDownEdit.Controls[0] as ASPxComboBox;

                if (control.Text == control.Value.ToString())
                {
                    XPLiteObject doc = View.CurrentObject as XPLiteObject;
                    Type ObjType = CurrentObject.GetType();
                    UnitOfWork uow = new UnitOfWork(doc.Session.DataLayer);

                    HinhThucThanhToan current = uow.FindObject<HinhThucThanhToan>(new BinaryOperator("TieuDe", control.Text));
                    if (current == null)
                    {
                        current = new HinhThucThanhToan(uow);
                        current.TieuDe = control.Text;
                        current.Save();
                        uow.CommitTransaction();
                    }
                    PropertyInfo TieuDe = ObjType.GetProperty("HinhThucThanhToan");
                    TieuDe.SetValue(doc, doc.Session.GetObjectByKey<HinhThucThanhToan>(current.Oid));
                    doc.Save();
                    doc.Session.CommitTransaction();
                }
            }
        }
    }
}
