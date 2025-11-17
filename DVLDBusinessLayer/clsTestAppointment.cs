using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsTestAppointment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { get; set; }
        public int TestTypeID { get; set; }
        public int LDL_AppID { get; set; }
        public DateTime AppoinDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreaByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int Trial { get; set; }
        public int RetakeTestAppID { get; set; }

        public clsTestAppointment()
        {
            this.ID = -1;
            this.TestTypeID = -1;
            this.LDL_AppID = -1;
            this.AppoinDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreaByUserID = -1;
            this.IsLocked = false;
            this.Trial = 0;
            this.RetakeTestAppID = -1;

            Mode = enMode.AddNew;
        }

        private clsTestAppointment(int ID, int TestTypeID, int LDL_AppID, DateTime AppointmentDate, decimal PaidFees, int CreByUserID, bool IsLocked, int Trial, int RetakeTestAppID)
        {
            this.ID = ID;
            this.TestTypeID = TestTypeID;
            this.LDL_AppID = LDL_AppID;
            this.AppoinDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreaByUserID = CreByUserID;
            this.IsLocked = IsLocked;
            this.Trial = Trial;
            this.RetakeTestAppID = RetakeTestAppID;

            Mode = enMode.Update;
        }

        private bool _AddNewTestAppointment()
        {
            this.ID = clsTestAppointmentsData.AddNewTestAppointment(this.TestTypeID,
                this.LDL_AppID, this.AppoinDate, this.PaidFees, this.CreaByUserID,
                this.IsLocked, this.Trial, this.RetakeTestAppID);

            return (this.ID != -1);
        }

        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentsData.UpdateTestAppointment(this.ID, this.AppoinDate, this.IsLocked);
        }

        public static clsTestAppointment Find(int ID)
        {
            int TestTypeID = -1, LDL_AppID = -1, CreByUserID = -1, Trial = 0, RetakeTestAppID = -1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = 0;
            bool IsLocked = false;

            if (clsTestAppointmentsData.GetTestAppointments(ID, ref TestTypeID,
                ref LDL_AppID, ref AppointmentDate, ref PaidFees, ref CreByUserID,
                ref IsLocked, ref Trial, ref RetakeTestAppID))
                return new clsTestAppointment(ID, TestTypeID,
                 LDL_AppID, AppointmentDate, PaidFees, CreByUserID,
                 IsLocked, Trial, RetakeTestAppID);
            else
                return null;
        }

        public static clsTestAppointment FindByLDL_AppID(int LDL_AppID, int TestTypeID, bool IsLocked)
        {
            int ID = -1, CreByUserID = -1, Trial = 0, RetakeTestAppID = -1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = 0;

            if (clsTestAppointmentsData.GetTestAppointmentsByLDL_App(LDL_AppID,
                TestTypeID, ref ID, ref AppointmentDate, ref PaidFees,
                ref CreByUserID, IsLocked, ref Trial, ref RetakeTestAppID))
                return new clsTestAppointment(ID, TestTypeID,
                 LDL_AppID, AppointmentDate, PaidFees, CreByUserID,
                 IsLocked, Trial, RetakeTestAppID);
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTestAppointment();
            }

            return false;
        }

        public static DataTable GetAllTestsAppointments(int TestType)
        {
            return clsTestAppointmentsData.GetAllTestsAppointments(TestType);
        }

        public static DataTable GetAllPrvTestsAppointments(int LDL_AppID, int TestTypeID)
        {
            return clsTestAppointmentsData.GetAllPrvTestsAppointments(LDL_AppID, TestTypeID);
        }
    }
}
