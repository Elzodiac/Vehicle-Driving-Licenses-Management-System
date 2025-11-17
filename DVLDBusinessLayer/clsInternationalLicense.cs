using System;
using System.Data;
using System.Runtime.CompilerServices;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsInternationalLicense
    {
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsInternationalLicense()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = false;
            this.CreatedByUserID = -1;
        }
        private clsInternationalLicense(int IntLicenseID, int AppID, int DriverID, int LocalLicID, DateTime IssueDate, DateTime ExpDate, bool IsActive, int CreByUser)
        {
            this.InternationalLicenseID = IntLicenseID;
            this.ApplicationID = AppID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = LocalLicID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreByUser; 
        }

        public static DataTable GetAllInterDriverLicenses(int DriverID)
        {
            return clsInternationalLicensesData.GetAllInterDriverLicenses(DriverID);
        }

        public static DataTable GetAllInterDriverLicenses()
        {
            return clsInternationalLicensesData.GetAllInterDriverLicenses();
        }

        public static bool IsInterLicenseExists(int LDLID)
        {
            return clsInternationalLicensesData.IsInterLicenseExists(LDLID);
        }

        private bool AddNewInterLicense()
        {
            this.InternationalLicenseID = clsInternationalLicensesData.
                AddNewInterNationalLicense(this.ApplicationID, this.DriverID,
                this.IssuedUsingLocalLicenseID, this.IssueDate,
                this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return (this.InternationalLicenseID != -1);
        }

        public bool Save()
        {
            return AddNewInterLicense();
        }

        public static clsInternationalLicense Find(int IntLicenseID)
        {
            int AppID = -1, DriverID = -1, LocalLicID = -1, CreByUser = -1;
            DateTime IssueDate = DateTime.Now, ExpDate = DateTime.Now;
            bool IsActive = false;

            if (clsInternationalLicensesData.GetIntLicenseInfoByID(IntLicenseID,
                ref AppID, ref DriverID, ref LocalLicID, ref IssueDate,
                ref ExpDate, ref IsActive, ref CreByUser))
                return new clsInternationalLicense(IntLicenseID, AppID, DriverID,
                    LocalLicID, IssueDate, ExpDate, IsActive, CreByUser);
            else
                return null;
        }
    }
}
