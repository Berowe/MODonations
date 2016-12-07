using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

namespace MiddleOut
{
    class UserDatabase
    {

        private Dictionary<String, User> myUsers;
        private String myResourcePath;
        private String myPath;
        private String myFileName;
        private String mySerialNumber;

        public UserDatabase()
        {
            myUsers = new Dictionary<string, User>();
            buildPaths();
            pullUsers();
        }

        private void buildPaths()
        {
            myPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            myResourcePath = Path.Combine(myPath, "Resources");
            myFileName = Path.Combine(myPath, "userlist.txt");
        }

        private void pullUsers()
        {
            if (File.Exists(myFileName))
            {
                myUsers = new JavaScriptSerializer()
                    .Deserialize<Dictionary<String, User>>(File.ReadAllText(myFileName));
            }
        }

        public void addUser(User theUser)
        {
            myUsers.Add(theUser.getEmail(), theUser);
            File.Delete(myFileName);
            File.WriteAllText(myFileName, new JavaScriptSerializer().Serialize(myUsers));
        }

        public Boolean verifyUser(String theUsername, String thePassword)
        {
            Boolean verify = false;
            if (myUsers.ContainsKey(theUsername))
            {
                if (myUsers[theUsername].getPassword(thePassword))
                {
                    verify = true;
                }

            }
            return verify;
        }

        public Boolean checkUser(String theUsername)
        {
            Boolean verify = false;
            if (myUsers.ContainsKey(theUsername))
            {
                verify = true;
            }
            return verify;
        }
    }
}
