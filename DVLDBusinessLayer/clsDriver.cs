using System;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsDriver
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public  clsDriver()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;
        }

        private clsDriver(int DriverID, int PersonID, int CreByUserID, DateTime CreDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreByUserID;
            this.CreatedDate = CreDate;
        }

        public static clsDriver FindByPersonID(int PersonID)
        {
            int DriverID = -1, CreByUserID = -1;
            DateTime CreDate = DateTime.Now;

            if (clsDriversData.GetDriverInfoByPersonID(ref DriverID, PersonID, ref CreByUserID, ref CreDate))
                return new clsDriver(DriverID, PersonID, CreByUserID, CreDate);
            else
                return null;
        }
        private int _AddNewDriver()
        {
            this.DriverID = clsDriversData.AddNewDriver(this.PersonID,
                this.CreatedByUserID, this.CreatedDate);

            return this.DriverID;
        }

        public static bool IsDriverExists(int PersonID)
        {
            return clsDriversData.IsDriverExistsByPersonID(PersonID);
        }

        public int Save()
        {
            return _AddNewDriver();
        }

        public static DataTable GetAllDriversList()
        {
            return clsDriversData.GetAllDrivers();
        }
    }
}
