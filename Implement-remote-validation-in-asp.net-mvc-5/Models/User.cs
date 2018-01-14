using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Implement_remote_validation_in_asp.net_mvc_5.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        [Remote("IsUserNameAlreadyExist", "User", ErrorMessage = "Username already exist.")]
        public string UserName { get; set; }
        public string EmailId { get; set; }

    }
}