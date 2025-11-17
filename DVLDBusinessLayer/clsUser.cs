using System;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public int PersonID { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }


        public clsUser()
        {
            this.ID = -1;
            this.PersonID = -1;
            this.Username = "";
            this.Password = "";
            this.IsActive = false;

            Mode = enMode.AddNew;
        }

        private clsUser(int ID, int PersonID, string Username, string Password,
            bool IsActive)
        {
            this.ID = ID;
            this.PersonID = PersonID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            //call DataAccess Layer 

            this.ID = clsUserData.AddNewUser(this.PersonID, this.Username,
            this.Password, this.IsActive);

            return (this.ID != -1);
        }

        private bool _UpdateUser()
        {
            //call DataAccess Layer 

            return clsUserData.UpdateUser(this.ID, this.PersonID, this.Username,
            this.Password, this.IsActive);

        }

        public static clsUser Find(int ID)
        {

            string Username = "", Password = "";
            int PersonID = -1;
            bool IsActive = false;

            if (clsUserData.GetUserInfoByID(ID, ref PersonID, ref Username,
                ref Password, ref IsActive))

                return new clsUser(ID, PersonID, Username, Password, IsActive);
            else
                return null;
        }

        public static clsUser Find(string Username)
        {
            
            string Password = "";
            bool IsActive = false;
            int ID = -1, PersonID = -1;

            if (clsUserData.GetUserInfoByUsername(Username, ref ID, ref PersonID, ref Password, ref IsActive))

                return new clsUser(ID, PersonID, Username, Password, IsActive);
            else
                return null;
        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();
            }

            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();

        }

        public static bool DeleteUser(int ID)
        {
            return clsUserData.DeleteUser(ID);
        }

        public static bool isUserExists(int ID)
        {
            return clsUserData.IsUserExists(ID);
        }
        
        public static bool isUserExistsByPersonID(int PersonID)
        {
            return clsUserData.IsUserExistsByPersonID(PersonID);
        }

        public static bool isUserExistsByUsername(string Username)
        {
            return clsUserData.IsUserExistsByUsername(Username);
        }

        public static string EncodePassword(string Password)
        {
            return clsSecurityHelper.EncodePassword(Password);
        }
    }
}
