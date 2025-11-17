using System;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    
    public class clsLDLApp
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int ID { get; set; }
        public int AppID { get; set; }
        public int LicClassID { get; set; }

        // View Members
        public string DrivingClass { get; set; }
        public string FullName { get; set; }
        public DateTime AppDate { get; set; }
        public int PassedTest { get; set; }
        public string StatusName { get; set; }
        

        public clsLDLApp()
        {
            this.ID = -1;
            this.AppID = -1;
            this.LicClassID = -1;

            Mode = enMode.AddNew;
        }

        public clsLDLApp(int ID, int AppID, int LicClassID)
        {
            this.ID = ID;
            this.AppID = AppID;
            this.LicClassID = LicClassID;

            Mode = enMode.Update;
        }

        public clsLDLApp(string DrivingClass, string FullName, DateTime AppDate, int PassedTest, string StatusName)
        {
            this.DrivingClass = DrivingClass;
            this.FullName = FullName;
            this.AppDate = AppDate;
            this.PassedTest = PassedTest;
            this.StatusName = StatusName;
        }

        private bool _AddNewLDLA()
        {
            this.ID = clsLDLAppData.AddNewLDLApp(this.AppID,
                this.LicClassID);

            return (this.ID != -1);

        }

        private bool _UpdateLDLA()
        {
            return clsLDLAppData.UpdateLDLApp(this.ID, this.AppID, this.LicClassID);
        }

        public static clsLDLApp Find(int ID)
        {
            int AppID = -1, LicClassID = -1;

            if (clsLDLAppData.GetLDLAppInfoByID(ID, ref AppID, ref LicClassID))

                return new clsLDLApp(ID, AppID, LicClassID);
            else
                return null;
        }

        public static clsLDLApp FindByAppID(int AppID)
        {
            int ID = -1, LicClassID = -1;

            if (clsLDLAppData.GetLDLAppInfoByAppID(ref ID, AppID, ref LicClassID))

                return new clsLDLApp(ID, AppID, LicClassID);
            else
                return null;
        }

        public static clsLDLApp Findvw(int ID)
        {

            string DrivingClass = "", FullName = "", StatusName = "";
            DateTime AppDate = DateTime.Now;
            int PassedTest = 1;
            

            if (clsLDLAppData.GetvwLDLAppInfoByID(ID, ref DrivingClass, ref FullName, ref AppDate, ref PassedTest, ref StatusName))
                return new clsLDLApp(DrivingClass, FullName, AppDate, PassedTest, StatusName);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLDLA())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLDLA();
            }

            return false;
        }

        public static DataTable GetAllLDLApp()
        {
            return clsLDLAppData.GetAllLDLApp();
        }

        public static bool DeleteLDLApp(int ID)
        {
            return clsLDLAppData.DeleteLDLApp(ID);
        }

        public static bool isLDLAppExists(int ID)
        {
            return clsLDLAppData.IsLDLAppExists(ID);
        }
    }
}
