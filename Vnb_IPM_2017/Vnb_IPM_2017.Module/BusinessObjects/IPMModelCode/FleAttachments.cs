using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.DC;

namespace Vnb_IPM_2017.Module.BusinessObjects
{

    public partial class FleAttachments : IMultiUpload
    {
        public FleAttachments(Session session) : base(session) { }

        [Association("Files_FileAttachment",typeof(FileUploads))]
        public XPCollection FileAttachments
        {
            get
            {
                return GetCollection("FileAttachments");
            }
        }

        [NonPersistent]
        [XafDisplayName("Upload Files")]
        [VisibleInListView(false)]
        [ModelDefault("PropertyEditorType", "Vnb_IPM_2017.Module.Web.PropertyEditors.MultiFileUploadEditor")]
        public string MultiUpload
        {
            get; set;
        }

        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
