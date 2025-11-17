using System;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsApplicationType
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Fees { get; set; }

        private clsApplicationType(int ID, string Title, decimal Fees)
        {
            this.ID = ID;
            this.Title = Title;
            this.Fees = Fees;
        }

        public static DataTable GetAllAppTypes()
        {
            return clsApplicationTypesData.GetAllAppTypes();
        }

        public static clsApplicationType Find(int ID)
        {
            string Title = "";
            decimal Fees = 0;

            if (clsApplicationTypesData.FindAppTypeByID(ID, ref Title, ref Fees))

                return new clsApplicationType(ID, Title, Fees);
            else
                return null;
        }

        private bool _Update()
        {
            return clsApplicationTypesData.Update(this.ID, this.Title, this.Fees);
        }
        public bool Save()
        {
            return _Update();
        }
    }
}
