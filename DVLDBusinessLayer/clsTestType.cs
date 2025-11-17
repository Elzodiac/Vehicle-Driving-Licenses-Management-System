using System;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsTestType
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Fees { get; set; }
        public decimal RetakeTestFees { get; set; }

        private clsTestType(int ID, string Title, string Desc, decimal Fees, decimal RetakeTestFees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Description = Desc;
            this.Fees = Fees;
            this.RetakeTestFees = RetakeTestFees;
        }

        public static DataTable GetAllTestTypes()
        {
            return clsTestTypesData.GetAllTestTypes();
        }

        public static clsTestType Find(int ID)
        {
            string Title = "", Desc = "";
            decimal Fees = 0, RetakeTestFees = 0;

            if (clsTestTypesData.FindTestTypeByID(ID, ref Title, ref Desc, ref Fees, ref RetakeTestFees))

                return new clsTestType(ID, Title, Desc, Fees, RetakeTestFees);
            else
                return null;
        }

        private bool _Update()
        {
            return clsTestTypesData.Update(this.ID, this.Title, this.Description, this.Fees);
        }
        public bool Save()
        {
            return _Update();
        }
    }
}
