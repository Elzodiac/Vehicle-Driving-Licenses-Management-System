using System;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        public clsLicense()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClass = -1;
            this.IssueDate = DateTime.Now;
            this.ExpDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = false;
            this.IssueReason = 0;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }

        private clsLicense(int ID, int AppliID, int DriverID, int LicenseClassID,
            DateTime IssueDate, DateTime ExpDate, string Notes, decimal PaidFees,
            bool IsActive, byte IssueReason, int CreByUserID)
        {
            this.LicenseID = ID;
            this.ApplicationID = AppliID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClassID;
            this.IssueDate = IssueDate;
            this.ExpDate = ExpDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreByUserID;

            Mode = enMode.Update;
        }

        private bool _AddNewLicense()
        {
            this.LicenseID = clsLicensesData.AddNewLicense(this.ApplicationID,
                this.DriverID, this.LicenseClass, this.IssueDate, this.ExpDate,
                this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);

            return (this.LicenseID != -1);
        }

        private bool _UpdateLicense()
        {
            return clsLicensesData.UpdateLicense(this.LicenseID, this.ApplicationID,
                this.DriverID, this.LicenseClass, this.IssueDate, this.ExpDate,
                this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreatedByUserID);
        }

        public static clsLicense Find(int ID)
        {
            int AppliID = -1, DriverID = -1, LicenseClassID = -1, CreByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;

            if (clsLicensesData.GetLicenseInfoByID(ID, ref AppliID, ref DriverID,
               ref LicenseClassID, ref IssueDate, ref ExpDate, ref Notes, ref PaidFees,
               ref IsActive, ref IssueReason, ref CreByUserID))
                return new clsLicense(ID, AppliID, DriverID, LicenseClassID,
             IssueDate, ExpDate, Notes, PaidFees,
             IsActive, IssueReason, CreByUserID);
            else
                return null;
        }

        public static clsLicense FindByAppID(int ApplicatiopnID)
        {
            int LicenseID = -1, DriverID = -1, LicenseClassID = -1, CreByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;

            if (clsLicensesData.GetLicenseInfoByAppID(ref LicenseID, ApplicatiopnID, ref DriverID,
               ref LicenseClassID, ref IssueDate, ref ExpDate, ref Notes, ref PaidFees,
               ref IsActive, ref IssueReason, ref CreByUserID))
                return new clsLicense(LicenseID, ApplicatiopnID, DriverID, LicenseClassID,
             IssueDate, ExpDate, Notes, PaidFees,
             IsActive, IssueReason, CreByUserID);
            else
                return null;
        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicense())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLicense();
            }

            return false;
        }

        public static bool IsLicenseExistsByAppliID(int AppliID)
        {
            return clsLicensesData.IsLicenseExistsByAppID(AppliID);
        }

        public static bool IsLicenseExists(int License)
        {
            return clsLicensesData.IsLicenseExists(License);
        }

        public static DataTable GetAllLicenses(int DriverID)
        {
            return clsLicensesData.GetAllDriverLicenses(DriverID);
        }


    }
}
