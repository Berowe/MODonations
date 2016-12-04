using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleOut
{
    //For if user is a new user.
    class newUser
    {
        // Field variables
        #region fields
        #region public field
        #endregion
        #region private field
        private Random RNG = new Random();
        private int userID;
        private String userName;
        private String userAddress;
        private String userEmail;
        private String userPass;
        #endregion
        #endregion

        // Check for confirm password onClick for login submit button.
        public newUser(String name, String address, String email, String pass) {

            this.userName = name;
            this.userAddress = address;
            this.userEmail = email;
            this.userPass = pass;
            // Check for number already exisiting in database.
            this.userID = RNG.Next(15000) + 1000;
            // Add user and login with information that was input
            //User newUser = User(String name, String email);
        }

        // Input information into User Database. New users are always general users, and can be given Admin.
        public void addUser(String name, String address, String email, String pass, int userID)
        {
            // TO DO find database Endpoint.
        }
    }
}
