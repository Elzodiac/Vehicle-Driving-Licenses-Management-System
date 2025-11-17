using System;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsDetainedLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }

        public clsDetainedLicense()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.Now;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;

            Mode = enMode.AddNew;
        }

        private clsDetainedLicense(int ID, int LicenseID, DateTime DetainDate, decimal FineFees, int CrebyUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = ID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CrebyUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;

            Mode = enMode.Update;
        }

        public static clsDetainedLicense Find(int ID)
        {

            int LicenseID = -1, CrebyUserID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1;
            DateTime DetainDate = DateTime.Now, ReleaseDate = DateTime.Now;
            decimal FineFees = 0;
            bool IsReleased = false;

            if (clsDetainedLicensesData.GetDetainLicenseInfoByID(ID, ref LicenseID, ref DetainDate,
            ref FineFees, ref CrebyUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))

                return new clsDetainedLicense(ID, LicenseID,  DetainDate,
             FineFees,  CrebyUserID,  IsReleased,  ReleaseDate,  ReleasedByUserID,  ReleaseApplicationID);
            else
                return null;
        }

        public static clsDetainedLicense FindByLicenseID(int LicenseID)
        {

            int ID = -1, CrebyUserID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1;
            DateTime DetainDate = DateTime.Now, ReleaseDate = DateTime.Now;
            decimal FineFees = 0;
            bool IsReleased = false;

            if (clsDetainedLicensesData.GetDetainLicenseInfoByLicID(ref ID, LicenseID, ref DetainDate,
            ref FineFees, ref CrebyUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))

                return new clsDetainedLicense(ID, LicenseID, DetainDate,
             FineFees, CrebyUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;
        }

        private bool _AddNewDetainLicense()
        {
            //call DataAccess Layer 

            this.DetainID = clsDetainedLicensesData.AddNewDetainLicense(
                this.LicenseID, this.DetainDate, this.FineFees,
                this.CreatedByUserID, this.IsReleased);

            return (this.DetainID != -1);
        }

        private bool _UpdateDetainLicense()
        {
            //call DataAccess Layer 

            return clsDetainedLicensesData.UpdateDetainLicense(this.DetainID,
                this.LicenseID, this.DetainDate, this.FineFees,
                this.CreatedByUserID, this.IsReleased, this.ReleaseDate,
                this.ReleasedByUserID, ReleaseApplicationID);

        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetainLicense())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateDetainLicense();
            }

            return false;
        }

        public static DataTable GetAllDetainLicenses()
        {
            return clsDetainedLicensesData.GetAllDetainLicenses();
        }

        public static bool isDetainLicenseExists(int ID)
        {
            return clsDetainedLicensesData.IsDetainLicenseExists(ID);
        }

        public static bool isDetainLicenseByLicIDExists(int LicenseID)
        {
            return clsDetainedLicensesData.IsDetainLicenseByLicIDExists(LicenseID);
        }

        public static bool DeleteDetainedLicense(int ID)
        {
            return clsDetainedLicensesData.DeleteDetainLicense(ID);
        }

    }
}
