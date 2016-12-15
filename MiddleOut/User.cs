// Author: Braxton Rowe
using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MiddleOut
{
    /// <summary>
    /// The User object class.
    /// Author: Braxton Rowe
    /// </summary>
    public class User
    {
        #region fields
        [JsonProperty("myName")]
        private String myName;
        [JsonProperty("myPassword")]
        private String myPassword;
        [JsonProperty("myEmail")]
        private String myEmail;
        [JsonProperty("myStreet")]
        private String myStreet;
        [JsonProperty("myApartment")]
        private String myApartment;
        [JsonProperty("myCity")]
        private String myCity;
        [JsonProperty("myState")]
        private String myState;
        [JsonProperty("myZipCode")]
        private String myZipCode;
        [JsonProperty("myVehichleType")]
        private String myVehichleType;
        [JsonProperty("myCapacity")]
        private String myCapacity;
        [JsonProperty("myTimeStart")]
        private String myTimeStart;
        [JsonProperty("myTimeStop")]
        private String myTimeStop;
        [JsonProperty("myLicenseFilePath")]
        private String myLicenseFilePath;
        [JsonProperty("myAdmin")]
        private Boolean myAdmin = false;
        [JsonProperty("myServices")]
        private List<Service> myServices;
        #endregion

        #region constructor
        /// <summary>
        /// The Constructor for the User object.
        /// </summary>
        /// <param name="name">The User's real name.</param>
        /// <param name="password">The User's password.</param>
        /// <param name="email">The User's email address.</param>
        /// <param name="street">The User's street address.</param>
        /// <param name="apartment">The User's apartment number.</param>
        /// <param name="city">The User's city.</param>
        /// <param name="state">The User's state.</param>
        /// <param name="zipcode">The User's zipcode.</param>
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
        #endregion

        #region getters
        /// <summary>
        /// Gets the User's real name.
        /// </summary>
        /// <returns>Returns the User's real name.</returns>
        public String getName()
        {
            return myName;
        }

        /// <summary>
        /// Gets the User's email address.
        /// </summary>
        /// <returns>The User's email address.</returns>
        public String getEmail()
        {
            return myEmail;
        }

        /// <summary>
        /// Gets the User's vehicle type.
        /// </summary>
        /// <returns>The User's vehicle type.</returns>
        public String getVehicleType()
        {
            return myVehichleType;
        }

        /// <summary>
        /// Gets the User's vehicle capacity.
        /// </summary>
        /// <returns>The User's vehicle capacity.</returns>
        public String getCapacity()
        {
            return myCapacity;
        }

        /// <summary>
        /// Gets the User's start time.
        /// </summary>
        /// <returns>The User's start time.</returns>
        public String getTimeStart()
        {
            return myTimeStart;
        }

        /// <summary>
        /// Gets the User's stop time.
        /// </summary>
        /// <returns>The User's stop time.</returns>
        public String getTimeStop()
        {
            return myTimeStop;
        }

        /// <summary>
        /// Gets the User's license picture filepath.
        /// </summary>
        /// <returns>The User's license picture filepath.</returns>
        public String getLicenseFilePath()
        {
            return myLicenseFilePath;
        }

        /// <summary>
        /// Gets the User's address.
        /// </summary>
        /// <returns>The User's address.</returns>
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

        /// <summary>
        /// Get's the User's list of Services.
        /// </summary>
        /// <returns>Returns the list of Service objects.</returns>
        public List<Service> getServices()
        {
            return myServices;
        }
        #endregion

        #region setters

        /// <summary>
        /// Sets the User's real name.
        /// </summary>
        /// <param name="name">The User's real name</param>
        public void setName(String name)
        {
            myName = name;
            UserDatabase.updateDatabase();
        }

        /// <summary>
        /// Sets the User's password.
        /// </summary>
        /// <param name="password">The new password.</param>
        public void setPassword(String password)
        {
            myPassword = password;
            UserDatabase.updateDatabase();
        }

        /// <summary>
        /// Sets the User's email address.
        /// </summary>
        /// <param name="email">The User's email address.</param>
        public void setEmail(String email)
        {
            myEmail = email;
            UserDatabase.updateDatabase();
        }

        /// <summary>
        /// Sets the User's address.
        /// </summary>
        /// <param name="street">The User's street.</param>
        /// <param name="apartment">The User's apartment number.</param>
        /// <param name="city">The User's city.</param>
        /// <param name="state">The User's state.</param>
        /// <param name="zipcode">The User's zipcode.</param>
        public void setAddress(String street, String apartment, String city, String state, String zipcode)
        {
            myStreet = street;
            myApartment = apartment;
            myCity = city;
            myState = state;
            myZipCode = zipcode;
            UserDatabase.updateDatabase();
        }

        /// <summary>
        /// Sets if user is admin.
        /// </summary>
        /// <param name="admin">Boolean value if user is admin or not.</param>
        public void setAdmin(Boolean admin)
        {
            myAdmin = admin;
            UserDatabase.updateDatabase();
        }

        /// <summary>
        /// Sets the User's vehicle type.
        /// </summary>
        /// <param name="type">The User's vehichle type.</param>
        public void setVehicleType(String type)
        {
            myVehichleType = type;
            UserDatabase.updateDatabase();
        }

        /// <summary>
        /// Sets the User's vehicle capacity.
        /// </summary>
        /// <param name="capacity">The user's vehicle capacity.</param>
        public void setCapacity(String capacity)
        {
            myCapacity = capacity;
            UserDatabase.updateDatabase();
        }

        /// <summary>
        /// Sets the User's start time.
        /// </summary>
        /// <param name="start">The User's start time.</param>
        public void setTimeStart(String start)
        {
            myTimeStart = start;
            UserDatabase.updateDatabase();
        }

        /// <summary>
        /// Sets the User's stop time.
        /// </summary>
        /// <param name="stop">The User's stop time.</param>
        public void setTimeStop(String stop)
        {
            myTimeStop = stop;
            UserDatabase.updateDatabase();
        }

        /// <summary>
        /// Sets the file path for the User's licence photo.
        /// </summary>
        /// <param name="licence">The file path.</param>
        public void setLicenseFilePath(String licence)
        {
            myLicenseFilePath = licence;
            UserDatabase.updateDatabase();
        }
        #endregion

        #region public methods

        /// <summary>
        /// Checks if User is admin.
        /// </summary>
        /// <returns>Returns true if User is admin, false if not.</returns>
        public Boolean isAdmin()
        {
            return myAdmin;
        }

        /// <summary>
        /// Checks if password submitted is the User's password.
        /// </summary>
        /// <param name="thePassword">The password input.</param>
        /// <returns>Returns true if the password is correct, false if not.</returns>
        public Boolean checkPassword(String thePassword)
        {
            Boolean verify = false;
            if (thePassword.Equals(myPassword))
            {
                verify = true;
            }
            return verify;
        }

        /// <summary>
        /// Adds the User's Drive information.
        /// </summary>
        /// <param name="type">The User's vehichle type.</param>
        /// <param name="capacity">The User's vehicle capacity.</param>
        /// <param name="start">The User's start time.</param>
        /// <param name="stop">The User's stop time.</param>
        /// <param name="filePath">The file path for the User's license photo.</param>
        public void addDrive(String type, String capacity, String start, String stop, String filePath)
        {
            myVehichleType = type;
            myCapacity = capacity;
            myTimeStart = start;
            myTimeStop = stop;
            myLicenseFilePath = filePath;
            UserDatabase.updateDatabase();
        }

        /// <summary>
        /// Adds the Service object to the list of the User's services.
        /// </summary>
        /// <param name="service">The Service object.</param>
        public void addService(Service service)
        {
            myServices.Add(service);
            UserDatabase.updateDatabase();
        }
        #endregion
    }

}