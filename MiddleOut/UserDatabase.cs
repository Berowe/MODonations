// Author: Braxton Rowe
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters;

namespace MiddleOut
{
    /// <summary>
    /// The User database containing all User objects.
    /// </summary>
    class UserDatabase
    {
        #region fields
        private Dictionary<String, User> myUsers;
        private String myResourcePath;
        private String myPath;
        private String myFileName;
        private static String FILE_NAME;
        private static Dictionary<String, User> MY_USERS;
        #endregion

        #region constructor

        /// <summary>
        /// Constructor for the User Database.
        /// </summary>
        public UserDatabase()
        {
            myUsers = new Dictionary<String, User>();
            buildPaths();
            pullUsers();
            FILE_NAME = myFileName;
            MY_USERS = myUsers;
        }
        #endregion

        #region private methods

        /// <summary>
        /// Helper method for the constructor to build the file paths needed.
        /// </summary>
        private void buildPaths()
        {
            myPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            myResourcePath = Path.Combine(myPath, "Resources");
            myFileName = Path.Combine(myPath, "userlist.txt");
        }

        /// <summary>
        /// Helper method for the constructor to read in the data from the file containing the User data.
        /// </summary>
        private void pullUsers()
        {
            if (File.Exists(myFileName))
            {
                String deSerial = File.ReadAllText(myFileName);
                object dictionary = JsonConvert.DeserializeObject(deSerial, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All,
                    TypeNameAssemblyFormat = FormatterAssemblyStyle.Simple
                });
                myUsers = (Dictionary<String, User>)dictionary;
            }
        }
        #endregion

        #region public methods

        /// <summary>
        /// Adds a new User to the database and saves the database to the file.
        /// </summary>
        /// <param name="theUser">The User object.</param>
        public void addUser(User theUser)
        {
            myUsers.Add(theUser.getEmail(), theUser);
            string serial = JsonConvert.SerializeObject(myUsers, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                TypeNameAssemblyFormat = FormatterAssemblyStyle.Simple
            });
            File.WriteAllText(myFileName, serial);
        }

        /// <summary>
        /// Verifies whether the User object is in the database, and if it is, verifies the password.
        /// </summary>
        /// <param name="theUsername">The User ID.</param>
        /// <param name="thePassword">The User's Password.</param>
        /// <returns></returns>
        public Boolean verifyUser(String theUsername, String thePassword)
        {
            Boolean verify = false;
            if (myUsers.ContainsKey(theUsername))
            {
                if (myUsers[theUsername].checkPassword(thePassword))
                {
                    verify = true;
                }

            }
            return verify;
        }

        /// <summary>
        /// Checks to see if the User is in the database.
        /// </summary>
        /// <param name="theUsername">The UserID being checked.</param>
        /// <returns></returns>
        public Boolean checkUser(String theUsername)
        {
            Boolean verify = false;
            if (myUsers.ContainsKey(theUsername))
            {
                verify = true;
            }
            return verify;
        }
        #endregion

        #region static methods
        /// <summary>
        /// Called to update the database with new user data.
        /// </summary>
        public static void updateDatabase()
        {
            string serial = JsonConvert.SerializeObject(MY_USERS, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                TypeNameAssemblyFormat = FormatterAssemblyStyle.Simple
            });
            File.WriteAllText(FILE_NAME, serial);
        }
        #endregion

    }
}