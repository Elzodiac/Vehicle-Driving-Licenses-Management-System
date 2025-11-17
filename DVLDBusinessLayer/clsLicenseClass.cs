using System;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsLicenseClass
    {
        public int LicClassID { get; set; }
        public string LicClassName { get; set; }
        public string ClassDesc { get; set; }
        public byte MinAllowedAge { get; set; }
        public byte DefValLength { get; set; }
        public decimal ClassFees { get; set; }

        public clsLicenseClass()
        {
            this.LicClassID = -1;
            this.LicClassName = "";
            this.ClassDesc = "";
            this.MinAllowedAge = 0;
            this.DefValLength = 0;
            this.ClassFees = 0;
        }

        private clsLicenseClass(int LicClassID, string LicClassName, string ClassDesc, byte MinAllowedAge, byte DefValLength, decimal ClassFees)
        {
            this.LicClassID = LicClassID;
            this.LicClassName = LicClassName;
            this.ClassDesc = ClassDesc;
            this.MinAllowedAge = MinAllowedAge;
            this.DefValLength = DefValLength;
            this.ClassFees = ClassFees;
        }

        public static clsLicenseClass Find(int LicClassID)
        {
            string LicClassName = "", ClassDesc = "";
            byte MinAllowedAge = 0, DefValLength = 0;
            decimal ClassFees = 0;

            if (clsLicenseClassesData.GetLicenseClassInfoByID(LicClassID, ref LicClassName, ref ClassDesc, ref MinAllowedAge, ref DefValLength, ref ClassFees))
                return new clsLicenseClass(LicClassID, LicClassName, ClassDesc, MinAllowedAge, DefValLength, ClassFees);
            else
                return null;
            
        }

        public static clsLicenseClass Find(string LicClassName)
        {
            int LicClassID = -1;
            string ClassDesc = "";
            byte MinAllowedAge = 0, DefValLength = 0;
            decimal ClassFees = 0;

            if (clsLicenseClassesData.GetLicenseClassInfoByName(LicClassName, ref LicClassID , ref ClassDesc, ref MinAllowedAge, ref DefValLength, ref ClassFees))
                return new clsLicenseClass(LicClassID, LicClassName, ClassDesc, MinAllowedAge, DefValLength, ClassFees);
            else
                return null;

        }

    }
}
