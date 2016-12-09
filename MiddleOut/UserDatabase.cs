using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters;

namespace MiddleOut
{
    class UserDatabase
    {

        private Dictionary<String, User> myUsers;
        private String myResourcePath;
        private String myPath;
        private String myFileName;

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
                String deSerial = File.ReadAllText(myFileName);
                object dictionary = JsonConvert.DeserializeObject(deSerial, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All,
                    TypeNameAssemblyFormat = FormatterAssemblyStyle.Simple
                });
                myUsers = (Dictionary<String, User>)dictionary;
            }
        }

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