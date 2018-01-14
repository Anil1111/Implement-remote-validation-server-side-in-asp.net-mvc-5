using Implement_remote_validation_in_asp.net_mvc_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Implement_remote_validation_in_asp.net_mvc_5.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(User user)
        {
            //Write the logic to save user to database here
            return View();
        }

        //Checks username already exists
        public JsonResult IsUserNameAlreadyExist(string userName)
        {
            bool isUserExist = GetUserList().Where(u => u.UserName.ToLowerInvariant().Equals(userName.ToLower())).FirstOrDefault() != null;
            return Json(!isUserExist, JsonRequestBehavior.AllowGet);
        }

        public JsonResult IsEmailAllReadyExistInDepartment(string emailId, string department)
        {
            bool isUserExist = GetUserList().Where(u => (u.EmailId.ToLowerInvariant().Equals(emailId.ToLower()) && u.Department.ToLowerInvariant().Equals(department.ToLower()))).FirstOrDefault() != null;
            return Json(!isUserExist, JsonRequestBehavior.AllowGet);
        }

        // Returns list of available users
        private IEnumerable<User> GetUserList()
        {
            // Here you can replace the userlist from the database.
            return new List<User>()
            {
                new User(){ EmailId="user1@email.com",UserName="user1",FirstName="user1 fname",LastName="user1 lname", Department = "TestDepartment"},
                new User(){ EmailId="user2@email.com",UserName="user2",FirstName="user2 fname",LastName="user2 lname", Department = "TestDepartment"},
                new User(){ EmailId="user3@email.com",UserName="user3",FirstName="user3 fname",LastName="user3 lname", Department = "TestDepartment"},
                new User(){ EmailId="user4@email.com",UserName="user4",FirstName="user4 fname",LastName="user4 lname", Department = "TestDepartment"}
            };
        }
    }
}