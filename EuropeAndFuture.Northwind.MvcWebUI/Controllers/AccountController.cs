using EuropeAndFuture.Core.CrossCuttingConcerns.Security.Web;
using System;
using System.Linq;
using System.Web.Mvc;
using EuropeAndFuture.Northwind.Business.Abstract;

namespace EuropeAndFuture.Northwind.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: Account
        public string Login()
        {
            var user = _userService.GetByUserNameAndPassword("burak", "9224");
            if (user != null)
            {
                AuthenticationHelper.CreateAuthCookie(new Guid(), 
                    user.UserName, 
                    user.Email, 
                    DateTime.Now.AddDays(15), 
                    _userService.GetUserRoles(user).Select(u=>u.RoleName).ToArray(), 
                    false, 
                    user.FirstName, 
                    user.LastName);
                return "User is authenticated!";
            }

            return "User is not authenticated!";
        }
    }
}