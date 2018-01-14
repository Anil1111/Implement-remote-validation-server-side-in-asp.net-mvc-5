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
        public string Department { get; set; }

        //WE CAN PASS THE METHOD IN CONTROLLLER "USER" AND THE ERROR MESSAGE
        [Remote("IsUserNameAlreadyExist", "User", ErrorMessage = "Username already exist.")]
        public string UserName { get; set; }


        [Remote("IsEmailAllReadyExistInDepartment", "User", AdditionalFields = "Department",ErrorMessage = "Email already exist in this department.")]
        public string EmailId { get; set; }

    }
}