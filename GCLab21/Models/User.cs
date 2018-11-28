using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GCLab21.Models
{
    public class User
    {
        public string FirstName;
        public string LastName;
        public string UserClass;
        public string Gender;
        public string UserEmail;
        public string Password;

        public User(string firstname, string lastname, string userclass, string gender, string password, string useremail)
        {
            FirstName = firstname;
            LastName = lastname;
            UserClass = userclass;
            Gender = gender;
            Password = password;
            UserEmail = useremail;
        }

        public User()
        {

        }




    }
}