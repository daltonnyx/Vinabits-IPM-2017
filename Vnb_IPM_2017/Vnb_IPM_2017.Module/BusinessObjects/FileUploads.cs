using System;
using System.ComponentModel;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.DC;
using System.IO;

namespace Vnb_IPM_2017.Module.BusinessObjects
{
    [Persistent, XafDefaultProperty("FileName")]
    [XafDisplayName("File uploads")]
    [ImageName("Action_FileAttachment_Attach")]
    public class FileUploads : XPLiteObject
    {
        private string filename = String.Empty;
        private string name = String.Empty;
        private string fileext = String.Empty;
        private string filetype = String.Empty;
        private string filerealpath = String.Empty;
        private string fileurl = String.Empty;
        private long filesize = 0; //in byte
        private DateTime dateuploaded = DateTime.Now;
        private FleAttachments owner;

        public FileUploads(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
            if (Session.IsNewObject(this))
            {
                dateuploaded = DateTime.Now;
            }
        }

        [Key(AutoGenerate = true), Persistent, Browsable(false)]
        public long Oid { get; set; }

        [Size(1024)]
        [VisibleInListView(false), VisibleInDetailView(false)]
        public string Name
        {
            get { return name; }
            set { SetPropertyValue("Name", ref name, value); }
        }

        [Size(SizeAttribute.Unlimited)]
        [ModelDefault("PropertyEditorType", "Vnb_IPM_2017.Module.Web.PropertyEditors.ASPxUploadToFileUploadsEditors")]
        public string FileName
        {
            get { return filename; }
            set { SetPropertyValue("FileName", ref filename, value); }
        }

        [Size(1024)]
        [VisibleInListView(false), VisibleInDetailView(false)]
        public string FileType
        {
            get { return filetype; }
            set { SetPropertyValue("FileType", ref filetype, value); }
        }

        public string FileExt
        {
            get { return fileext; }
            set { SetPropertyValue("FileExt", ref fileext, value); }
        }

        //[Size(32000)]
        [Browsable(false)]
        public string FileRealPath
        {
            get { return filerealpath; }
            set { SetPropertyValue("FileRealPath", ref filerealpath, value); }
        }

        //[Size(32000)]
        [VisibleInListView(false), VisibleInDetailView(false)]
        public string FileUrl
        {
            get { return fileurl; }
            set { SetPropertyValue("FileUrl", ref fileurl, value); }
        }

        public long FileSize
        {
            get { return filesize; }
            set { SetPropertyValue("FileSize", ref filesize, value); }
        }

        [Browsable(false)]
        public DateTime DateUploaded
        {
            get { return dateuploaded; }
            set { SetPropertyValue("DateUploaded", ref dateuploaded, value); }
        }
        
        [Association("Files_FileAttachment", typeof(FileUploads))]
        [VisibleInListView(false), VisibleInDetailView(false)]
        public FleAttachments Owner
        {
            get
            {
                return owner;
            }
            set
            {
                SetPropertyValue<FleAttachments>("Owner", ref owner, value);
            }
        }
    }

}
