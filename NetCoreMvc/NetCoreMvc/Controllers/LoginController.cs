using Microsoft.AspNetCore.Mvc;
using Models;
using ProjectContracts;

namespace NetCoreMvc.Controllers
{
    public class LoginController : Controller
    {
        private ILogin _loginDao;

        public LoginController(ILogin loginDao)
        {
            this._loginDao = loginDao;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }

        public int CheckLogin()
        {
            string  name =  Request.Form["login"];
            string password = Request.Form["password"];
            UserInfo userInfo = _loginDao.Login(name, password);
            if (userInfo != null)
            {
                return 1;
            }
            return 0;
        }
    }
}