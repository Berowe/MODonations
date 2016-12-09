using System;
using System.Collections;
using System.Windows;
using System.Text;
using System.Collections.Generic;

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
        private String myName;
        private String myPassword;
        private String myEmail;
        private String myStreet;
        private String myApartment;
        private String myCity;
        private String myState;
        private String myZipCode;
        private String myUserID;
        private String myVehichleType;
        private String myCapacity;
        private String myTimeStart;
        private String myTimeStop;
        private String myLicenseFilePath;
        private Boolean myAdmin = false;
        private int mySerialNumber;
        private List<Service> myServices;

        //The user object
        public User(String name, String password, String email, String street, String apartment, String city, 
            String state, String zipcode)
        {
            myName = name;
            myPassword = password;
            myEmail = email;
            myStreet = street;
            myApartment = apartment;
            myCity = city;
            myState = state;
            myZipCode = zipcode;
            myServices = new List<Service>();            
        }

        public String getName()
        {
            return myName;
        }

        public Boolean getPassword(String thePassword)
        {
            Boolean verify = false;
            if (thePassword.Equals(myPassword))
            {
                verify = true;
            }
            return verify;
        }

        public String getEmail()
        {
            return myEmail;
        }

        public String getVehicleType()
        {
            return myVehichleType;
        }

        public String getCapacity()
        {
            return myCapacity;
        }

        public String getTimeStart()
        {
            return myTimeStart;
        }

        public String getTimeStop()
        {
            return myTimeStop;
        }

        public String getLicenseFilePath()
        {
            return myLicenseFilePath;
        }

        public String getAddress()
        {
            StringBuilder address = new StringBuilder();
            address.Append(myStreet + ", ");
            if (myApartment != null)
            {
                address.Append(myApartment + ", ");
            }
            address.Append(myCity + ", ");
            address.Append(myState + ", ");
            address.Append(myZipCode);
            return address.ToString();
        }

        public Boolean isAdmin()
        {
            return myAdmin;
        }

        public List<Service> getServices()
        {
            return myServices;
        }

        public void setName(String name)
        {
            myName = name;
        }

        public void setPassword(String password)
        {
            myPassword = password;
        }

        public void setEmail(String email)
        {
            myEmail = email;
        }

        public void setAddress(String street, String apartment, String city, String state, String zipcode)
        {
            myStreet = street;
            myApartment = apartment;
            myCity = city;
            myState = state;
            myZipCode = zipcode;
        }

        public void setAdmin(Boolean admin)
        {
            myAdmin = admin;
        }

        public void setVehicleType(String type)
        {
            myVehichleType = type;
        }

        public void setCapacity(String capacity)
        {
            myCapacity = capacity;
        }

        public void setTimeStart(String start)
        {
            myTimeStart = start;
        }

        public void setTimeStop(String stop)
        {
            myTimeStop = stop;
        }

        public void setLicenseFilePath(String licence)
        {
            myLicenseFilePath = licence;
        }

        public void addDriver(String type, String capacity, String start, String stop, String filePath)
        {
            myVehichleType = type;
            myCapacity = capacity;
            myTimeStart = start;
            myTimeStop = stop;
            myLicenseFilePath = filePath;
        }

        public void addService(Service service)
        {
            myServices.Add(service);
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
