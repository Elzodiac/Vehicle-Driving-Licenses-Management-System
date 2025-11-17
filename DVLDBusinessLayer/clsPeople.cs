using System;
using System.Data;
using DVLDDataAccessLayer;


namespace DVLDBusinessLayer
{
    public class clsPeople
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public byte Gendor { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int NationalityCountryID { set; get; }
        public string ImagePath { set; get; }

        public clsPeople()
        {
            this.ID = -1;
            this.NationalNo = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = 0;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";

            Mode = enMode.AddNew;
        }

        private clsPeople(int ID, string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, byte Gendor,
            string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {
            this.ID = ID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            //call DataAccess Layer 

            this.ID = clsPersonData.AddNewPerson(this.NationalNo, this.FirstName,
            this.SecondName, this.ThirdName, this.LastName,
            this.DateOfBirth, this.Gendor, this.Address, this.Phone,
            this.Email, this.NationalityCountryID, this.ImagePath);

            return (this.ID != -1);
        }

        private bool _UpdatePerson()
        {
            //call DataAccess Layer 

            return clsPersonData.UpdatePerson(this.ID, this.NationalNo, this.FirstName,
            this.SecondName, this.ThirdName, this.LastName,
            this.DateOfBirth, this.Gendor, this.Address, this.Phone,
            this.Email, this.NationalityCountryID, this.ImagePath);

        }

        public static clsPeople Find(int ID)
        {

            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1;
            byte Gendor = 0;

            if (clsPersonData.GetPersonInfoByID(ID, ref NationalNo, ref FirstName,
                ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth,
                ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID,
                ref ImagePath))

                return new clsPeople(ID, NationalNo, FirstName, SecondName, ThirdName,
                    LastName, DateOfBirth, Gendor, Address, Phone,
                    Email, NationalityCountryID, ImagePath);
            else
                return null;
        }

        public static clsPeople Find(string NationalNo)
        {

            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1, ID = -1;
            byte Gendor = 0;

            if (clsPersonData.GetPersonInfoByNationalNo(NationalNo, ref ID, ref FirstName,
                ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth,
                ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID,
                ref ImagePath))

                return new clsPeople(ID, NationalNo, FirstName, SecondName, ThirdName,
                    LastName, DateOfBirth, Gendor, Address, Phone,
                    Email, NationalityCountryID, ImagePath);
            else
                return null;
        }
        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();
            }

            return false;
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();

        }

        public static bool DeletePerson(int ID)
        {
            return clsPersonData.DeletePerson(ID);
        }

        public static bool isPersonExists(int ID)
        {
            return clsPersonData.IsPersonExists(ID);
        }


        public static bool isPersonExistsByNationalNo(string NationalNo)
        {
            return clsPersonData.IsPersonExistsByNationalNo(NationalNo);
        }

    }
}

