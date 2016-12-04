using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MiddleOut
{
    class User
    {
        #region fields
        #region public field
        #endregion
        #region private field
        //Check for admin privledges based on Enum.
        //private bool isAdmin; = Enum.userType;
        private Point[] userLocation = {new Point(0, 0)};
        private String userName;
        #endregion
        #endregion

        //Login checks if user exists in database.
        public User(String name, String email)
        {
            userName = name;
            //isAdmin = Enum.userType;
        }

        public String getName()
        {
            return userName;
        }

        public void editProfile()
        {

        }
        #region Service handling (User can only handle their own services)
        public void serviceSignUp()
        {

        }

        public void editService()
        {

        }

        public void deleteService()
        {

        }
        #endregion

        #region location handling
        public void setLocation(Point[] setLocation)
        {
            userLocation = setLocation;
        }

        public Point[] getLocation()
        {
            return userLocation;
        }
        #endregion
        #region Admin
        private void viewUser()
        {

        }

        private void updateUser()
        {
            // Add parameters
        }

        private void deleteUser()
        {
            // USER.GETOWNED();
        }

        private void viewUserService()
        {

        }

        private void updateUserService()
        {
            // Add parameters
        }

        private void deleteUserService()
        {
            // USER.serviceOWNED();
        }
        #endregion
    }
}
