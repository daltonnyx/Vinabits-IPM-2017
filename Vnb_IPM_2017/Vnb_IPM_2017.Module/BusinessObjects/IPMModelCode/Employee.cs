using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Security;
using DevExpress.Persistent.Base.Security;
using DevExpress.Persistent.Validation;
using System.Security.Cryptography;
using System.Text;
using DevExpress.ExpressApp.Utils;

namespace Vnb_IPM_2017.Module.BusinessObjects
{

    public partial class NhanVien : ISecurityUser, IAuthenticationStandardUser, ISecurityUserWithRoles, IOperationPermissionProvider
    {
        public NhanVien(Session session) : base(session) { }
        #region IAuthenticationStandardUser Members
        private bool changePasswordOnFirstLogon;
        public bool ChangePasswordOnFirstLogon
        {
            get { return changePasswordOnFirstLogon; }
            set
            {
                SetPropertyValue("ChangePasswordOnFirstLogon", ref changePasswordOnFirstLogon, value);
            }
        }

        public string EncodePassword(string originalPassword)
        {
            if (originalPassword == null)
                return String.Empty;
            //Declarations
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;

            //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
            encodedBytes = md5.ComputeHash(originalBytes);

            //Convert encoded bytes back to a 'readable' string
            string retStr = BitConverter.ToString(encodedBytes);
            retStr = retStr.Replace("-", "");
            return retStr.ToLower();
        }

        private string storedPassword;
        [Browsable(false), Size(SizeAttribute.Unlimited), Persistent, SecurityBrowsable]
        protected string StoredPassword
        {
            get { return storedPassword; }
            set { storedPassword = value; }
        }
        public bool ComparePassword(string password)
        {
            bool retCompare = false;
            if (String.IsNullOrEmpty(password))
                retCompare = String.IsNullOrEmpty(storedPassword);
            else
                retCompare = EncodePassword(password).CompareTo(storedPassword) == 0;
            return retCompare;
            //return SecurityUserBase.ComparePassword(this.storedPassword, password);
        }
        public void SetPassword(string password)
        {
            //this.storedPassword = new PasswordCryptographer().GenerateSaltedPassword(password);
            this.storedPassword = EncodePassword(password);
            OnChanged("StoredPassword");
        }
        #endregion
        #region ISecurityUser Members
        private bool isActive = true;
        public bool IsActive
        {
            get { return isActive; }
            set { SetPropertyValue("IsActive", ref isActive, value); }
        }
        private string userName = String.Empty;
        [RuleRequiredField("EmployeeUserNameRequired", DefaultContexts.Save)]
        [RuleUniqueValue("EmployeeUserNameIsUnique", DefaultContexts.Save,
            "The login with the entered user name was already registered within the system.")]
        public string UserName
        {
            get { return userName; }
            set { SetPropertyValue("UserName", ref userName, value); }
        }
        #endregion

        #region ISecurityUserWithRoles Members
        IList<ISecurityRole> ISecurityUserWithRoles.Roles
        {
            get
            {
                IList<ISecurityRole> result = new List<ISecurityRole>();
                foreach (QuyenNhanVien role in QuyenNhanViens)
                {
                    result.Add(role);
                }
                return result;
            }
        }
        #endregion

        [Association("NhanViens-QuyenNhanViens")]
        public XPCollection<QuyenNhanVien> QuyenNhanViens
        {
            get
            {
                return GetCollection<QuyenNhanVien>("QuyenNhanViens");
            }
        }

        public override void AfterConstruction() { base.AfterConstruction(); }

        #region IOperationPermissionProvider Members
        IEnumerable<IOperationPermission> IOperationPermissionProvider.GetPermissions()
        {
            return new IOperationPermission[0];
        }
        IEnumerable<IOperationPermissionProvider> IOperationPermissionProvider.GetChildren()
        {
            return new EnumerableConverter<IOperationPermissionProvider, QuyenNhanVien>(QuyenNhanViens);
        }
        #endregion

    }

}
