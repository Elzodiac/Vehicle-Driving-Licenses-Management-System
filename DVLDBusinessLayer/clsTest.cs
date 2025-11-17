using System;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsTest
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }


        public clsTest()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = -1;
        }

        private bool _AddNewTest()
        {
            this.TestID = clsTestsData.AddNewTest(this.TestAppointmentID,
                this.TestResult, this.Notes, this.CreatedByUserID);

            return (this.TestID != -1);
        }

        public bool Save()
        {
            return _AddNewTest();
        }

    }
}
