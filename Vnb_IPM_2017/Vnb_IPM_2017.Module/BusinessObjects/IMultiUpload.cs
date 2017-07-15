using DevExpress.Xpo;

namespace Vnb_IPM_2017.Module.BusinessObjects
{
    public interface IMultiUpload
    {
        XPCollection FileAttachments
        {
            get;
        }

        string MultiUpload
        {
            get; set;
        }
    }
}