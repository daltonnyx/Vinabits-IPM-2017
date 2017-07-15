using System;
using System.Globalization;
using System.Web.UI.WebControls;

using DevExpress.Web;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Web;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Web.Editors.ASPx;
using DevExpress.ExpressApp.Model;
using System.IO;
using DevExpress.ExpressApp.Web.Editors;
using System.Web.SessionState;
using System.Web.UI;
using DevExpress.Xpo;
using System.Text.RegularExpressions;
using System.Web;
using DevExpress.Persistent.BaseImpl;
using Vnb_IPM_2017.Module.BusinessObjects;
//using DevExpress.Xpo;

namespace Vnb_IPM_2017.Module.Web.PropertyEditors
{
    [PropertyEditor(typeof(string), "Vinabits_OM_2017 ASPxUploadToFileUploadsEditors", false)]
    public class ASPxUploadToFileUploadsEditors : WebPropertyEditor //ASPxPropertyEditor
    {
        private bool isUploadComplete = false;
        //ASPxComboBox dropDownControl = null;
        public const string UrlEmailMask = @"(((http|https|ftp)\://)?[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*)|([a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6})";
        //ASPxUploadControl uploadPanel = null;
        FileUploads fileuploads;
        

        public ASPxUploadToFileUploadsEditors(Type objectType, IModelMemberViewItem info)
            : base(objectType, info)
        {
        }

        private ASPxPanel editorSetup()
        {
            ASPxPanel editorPanel = new ASPxPanel();
            editorPanel.Width = Unit.Percentage(100);
            ASPxUploadControl upPanel = new ASPxUploadControl();
            upPanel.ID = "upPanel";
            upPanel.FileUploadMode = UploadControlFileUploadMode.OnPageLoad;
            upPanel.ViewStateMode = System.Web.UI.ViewStateMode.Enabled;
            upPanel.UploadMode = UploadControlUploadMode.Auto; //Standard
            //upPanel.AddUploadButtonsHorizontalPosition = AddUploadButtonsHorizontalPosition.InputRightSide;
            upPanel.ShowProgressPanel = true;
            //upPanel.ShowAddRemoveButtons = true;
            upPanel.ProgressBarSettings.DisplayMode = DevExpress.Web.ProgressBarDisplayMode.Percentage;
            upPanel.ValidationSettings.AllowedFileExtensions = new string[] { ".jpg", ".png", ".psd", ".pdf", ".gif", ".docx", ".doc", 
                                                                                  ".xls", ".xlsx", ".txt", ".zip", ".rar", ".fla", ".swf" };
            upPanel.ShowUploadButton = true;
            upPanel.UploadButton.Image.Url = "Images/upload.png";
            upPanel.UploadButton.Image.UrlDisabled = "Images/upload_disable.png";
            upPanel.UploadButton.ImagePosition = DevExpress.Web.ImagePosition.Left;
            fileuploads = CurrentObject as FileUploads;
            upPanel.NullText = fileuploads == null ? "Click để chọn file upload.." : string.Format("{0}", fileuploads.Name);
            //upPanel.NullText = string.Format("File hiện tại: {0}", fileuploads == null ? "N/A" : fileuploads.Name);
            //Cho phep chon & upload nhieu file
            upPanel.AdvancedModeSettings.EnableMultiSelect = false;

            upPanel.FileUploadComplete += new EventHandler<FileUploadCompleteEventArgs>(uploadPanel_FileUploadComplete);
            //upPanel.PreRender
            //upPanel.CustomJSProperties

            ASPxLabel label = new ASPxLabel();
            ASPxLabel lblNote = new ASPxLabel();
            lblNote.Text = "Các bước UPLOAD file: \n1.Bấm 'Browse..' để chọn file.\n2. Bấm 'Upload' để tải file lên.\n3. Bấm 'Lưu' để xác nhận, file sẽ được lưu lên máy chủ.";
            lblNote.ForeColor = System.Drawing.Color.Gray;
            lblNote.BackColor = System.Drawing.Color.FromArgb(0xF2, 0xF2, 0xF2);
            label.ID = "upLabelPanel";

            editorPanel.Controls.Add(label);
            editorPanel.Controls.Add(upPanel);
            editorPanel.Controls.Add(lblNote);
            return editorPanel;
        }

        private void editorRender(ref ASPxPanel editorPanel)
        {
            ASPxUploadControl upPanel = (ASPxUploadControl)(editorPanel.FindControl("upPanel"));
            ASPxLabel label = (ASPxLabel)(editorPanel.FindControl("upLabelPanel"));
            if (upPanel != null)
            {
                upPanel.NullText = fileuploads == null ? "Click để chọn file từ PC.." : string.Format("{0}", fileuploads.FileName);
            }

            if (label != null && CurrentObject != null && isUploadComplete)
            {
                label.Text = string.Format("File '{0}' đã upload thành công!", ((FileUploads)CurrentObject).FileName);
                label.ForeColor = System.Drawing.Color.FromArgb(0x33, 0x66, 0x00);
                label.Visible = true;
                this.Refresh();
            }

        }

        protected string convertByte(int bytes)
        {
            //string strFormat = "{0:g}";
            string tmp = string.Format("{0:g} {1}", bytes, "bytes");
            if (bytes > 1024 * 1024 * 1024)
                tmp = string.Format(" {0:g} {1}", (bytes / (1024 * 1024 * 1024)), "GB");
            else if (bytes > 1024 * 1024)
                tmp = string.Format(" {0:g} {1}", (bytes / (1024 * 1024)), "MB");
            else if (bytes > 1024)
                tmp = string.Format(" {0:g} {1}", (bytes / 1024), "KB");
            return tmp;
        }

        private ASPxPanel viewSetup()
        {
            ASPxPanel viewPanel = new ASPxPanel();
            return viewPanel;
        }

        private void viewRender(ref ASPxPanel viewPanel)
        {
            //ASPxPanel viewPanel = new ASPxPanel();
            ASPxHyperLink link = RenderHelper.CreateASPxHyperLink(); // new ASPxHyperLink();
            ASPxLabel lblSize = new ASPxLabel();
            ASPxLabel lblType = new ASPxLabel();
            //iframe: PDF
            LiteralControl iframeShow = new LiteralControl(); ;

            if (CurrentObject != null) // && View != null
            {
                FileUploads file = CurrentObject as FileUploads;
                //DetailView view = (DetailView)View;
                //System.Web.UI.WebControls.Panel layoutControl = ((System.Web.UI.WebControls.Panel)(view.Control));
                link.Width = Unit.Pixel(200);
                link.BackColor = System.Drawing.Color.AliceBlue;
                link.Text = file.Name;
                link.NavigateUrl = GetResolvedUrl(file.FileUrl);
                link.Target = "_blank";

                lblSize.Text = this.convertByte((int)file.FileSize);
                lblSize.Font.Bold = true;

                lblType.Text = string.Format(" ({0})", file.FileType);
                lblType.ForeColor = System.Drawing.Color.DarkGray;

                iframeShow = new LiteralControl(string.Format("<iframe src=\"{0}\" style=\"width:100%; min-height:1200px;\"></iframe>", link.NavigateUrl));
            }


            viewPanel.Controls.Add(link);
            viewPanel.Controls.Add(lblSize);
            viewPanel.Controls.Add(lblType);
            viewPanel.Controls.Add(new LiteralControl("<p><br /></p>"));
            viewPanel.Controls.Add(iframeShow);

            //return viewPanel;
        }


        private static string GetResolvedUrl(object value)
        {
            string url = Convert.ToString(value);
            if (!string.IsNullOrEmpty(url))
            {
                if (url.Contains("@") && IsValidUrl(url))
                    return string.Format("mailto:{0}", url);
                if (!url.Contains("://"))
                    url = string.Format("http://{0}", url);
                if (IsValidUrl(url))
                    return url;
            }
            return string.Empty;
        }

        private static bool IsValidUrl(string url)
        {
            return Regex.IsMatch(url, UrlEmailMask);
        }

        public override object ControlValue
        {
            get
            {
                return fileuploads;
            }
        }

        protected override object GetControlValueCore()
        {
            return fileuploads; //((ASPxUploadControl)Editor).FileName
        }

        //Return the control's current value 
        //protected override object GetControlValue()
        //{
        //    return fileuploads;
        //}

        protected override void ReadEditModeValueCore()
        {
            if (CurrentObject != null)
                fileuploads = CurrentObject as FileUploads;
            ASPxPanel upPanel = (ASPxPanel)Editor;

            //editorRender(ref upPanel);
        }

        protected override void ReadViewModeValueCore()
        {
            base.ReadViewModeValueCore();
            if (CurrentObject != null)
            {
                ASPxPanel viewPanel = (ASPxPanel)InplaceViewModeEditor;
                if (viewPanel.Controls.Count == 0)
                    viewRender(ref viewPanel);
                //this.CreateControl();
            }
        }

        //CreateEditModeControlCore
        protected override WebControl CreateEditModeControlCore()
        {
            if (Editor == null)
                return editorSetup();
            return Editor;
        }

        protected override WebControl CreateViewModeControlCore()
        {
            return viewSetup();
        }

        protected void uploadPanel_FileUploadComplete(object sender, FileUploadCompleteEventArgs e)
        {
            if (e.IsValid)
            {
                e.CallbackData = SaveFile(e.UploadedFile);
                CurrentObject = fileuploads;
                fileuploads.Session.CommitTransaction();
                isUploadComplete = true;

                ASPxPanel upPanel = (ASPxPanel)Editor;
                editorRender(ref upPanel);

                //this.UpdateEditorState();
                this.Refresh();
            }
        }

        protected string SaveFile(UploadedFile uploadedFile)
        {
            //IObjectSpace os = ((DevExpress.ExpressApp.DetailView)(View)).ObjectSpace;
            Session sess = (View.ObjectSpace as DevExpress.ExpressApp.Xpo.XPObjectSpace).Session;

            fileuploads = new FileUploads(sess);
            string appDir = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;
            string appUrl = "./";

            if (uploadedFile.IsValid)
            {
                //fileName = string.Format("{0}{1}", MapPath("~/"), uploadedFile.FileName);
                fileuploads.Name        = uploadedFile.FileName;
                fileuploads.FileName    = uploadedFile.FileName;
                fileuploads.FileSize    = uploadedFile.ContentLength;
                fileuploads.FileType    = uploadedFile.ContentType; //PostedFile
                fileuploads.FileExt     = System.IO.Path.GetExtension(uploadedFile.FileName);

                string savePath;

                savePath = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath + @"\Uploads";
                savePath += @"\" + CurrentObject.GetType().Name;
                if (!Directory.Exists(savePath))
                    Directory.CreateDirectory(@savePath);

                //Thêm số thứ tự vào tên file để tránh trùng lặp file
                if (File.Exists(string.Format("{0}{1}", savePath, fileuploads.FileName)))
                {
                    int i = 1;
                    string tmpFileName = string.Format("{0}.{1}{2}", fileuploads.FileName.Substring(0, fileuploads.FileName.Length - fileuploads.FileExt.Length), i, fileuploads.FileExt);
                    while (File.Exists(string.Format("{0}{1}", savePath, tmpFileName)))
                    {
                        i++;
                        tmpFileName = string.Format("{0}.{1}{2}", fileuploads.FileName.Substring(0, fileuploads.FileName.Length - fileuploads.FileExt.Length), i, fileuploads.FileExt);
                    }
                    fileuploads.FileName = tmpFileName;
                    //File.Delete(string.Format("{0}{1}", savePath, fileuploads.FileName));
                }

                uploadedFile.SaveAs(string.Format("{0}{1}", savePath, fileuploads.FileName)); //uncomment this line
                //fileuploads.FileRealPath = savePath;
                if(HttpContext.Current != null)
                    appUrl = HttpContext.Current.Request.Url.Authority;
                fileuploads.FileUrl = string.Format("{0}{1}{2}", appUrl, fileuploads.FileRealPath.Replace(appDir,""), fileuploads.FileName);
                fileuploads.Save();
                sess.CommitTransaction();
                //fileuploads.Session.CommitTransaction();
            }
            return fileuploads.Name;
        }

    }

}
