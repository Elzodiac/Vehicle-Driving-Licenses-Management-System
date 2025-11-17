using System;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsApplications
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int AppID { get; set; }
        public int AppPersonID { get; set; }
        public DateTime AppDate { get; set; }
        public int AppTypeID { get; set; }
        public byte AppStatusID { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreaByUserID { get; set; }


        public clsApplications()
        {
            this.AppID = -1;
            this.AppPersonID = -1;
            this.AppDate = new DateTime();
            this.AppTypeID = -1;
            this.AppStatusID = 0;
            this.LastStatusDate = new DateTime();
            this.PaidFees = 0;
            this.CreaByUserID = -1;

            Mode = enMode.AddNew;
        }

        private clsApplications(int AppID, int AppPersonID, DateTime AppDate,
            int AppTypeID, byte AppStatusID, DateTime LastStatusDate, 
            decimal PaidFees, int CreaByUserID)
        {
            this.AppID = AppID;
            this.AppPersonID = AppPersonID;
            this.AppDate = AppDate;
            this.AppTypeID = AppTypeID;
            this.AppStatusID = AppStatusID;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreaByUserID = CreaByUserID;

            Mode = enMode.Update;
        }

        private bool _AddNewApp()
        {
            this.AppID = clsApplicationsData.AddNewApp(this.AppPersonID, this.AppDate, this.AppTypeID,
                this.AppStatusID, this.LastStatusDate, this.PaidFees, this.CreaByUserID);

            return (this.AppID != -1);
        }

        private bool _UpdateApp()
        {
            return clsApplicationsData.UpdateApp(this.AppID, this.AppPersonID,
                this.AppDate, this.AppTypeID, this.AppStatusID,
                this.LastStatusDate, this.PaidFees, this.CreaByUserID);
        }

        public static clsApplications Find(int AppID)
        {
            int AppPersonID = -1, AppTypeID = -1, CreaByUserID = -1;
            DateTime AppDate = DateTime.Now, LastStatusDate = DateTime.Now;
            decimal PaidFees = 0;
            byte AppStatusID = 0;

            if (clsApplicationsData.GetAppInfoByID(AppID, ref AppPersonID,
                ref AppDate, ref AppTypeID, ref AppStatusID, ref LastStatusDate,
                ref PaidFees, ref CreaByUserID))
                return new clsApplications(AppID, AppPersonID,
                 AppDate, AppTypeID, AppStatusID, LastStatusDate,
                 PaidFees, CreaByUserID);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApp())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApp();
            }
            return false;
        }

        public static bool isAppExists(int AppPersonID, int LicClassID)
        {
            return clsApplicationsData.IsAppExistsByPersonID(AppPersonID, LicClassID);
        }

        public static bool DeleteApplication(int AppliID)
        {
            return clsApplicationsData.DeleteApplication(AppliID);
        }
    }
}
