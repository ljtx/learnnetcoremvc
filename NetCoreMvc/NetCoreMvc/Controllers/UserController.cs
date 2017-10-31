using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;
using Models;
using Newtonsoft.Json;
using ProjectContracts;


namespace NetCoreMvc.Controllers
{
    public class UserController : Controller
    {
        private IUserInfoDao _userInfoDao;

        public UserController(IUserInfoDao userInfoDao)
        {
            this._userInfoDao = userInfoDao;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllUser()
        {
            IList<UserInfo> list = this._userInfoDao.GetAll();
            
            
            var total = list.Count;  
            var data = new  
            {  
                total,  
                rows = list
            };  
            
            return Json(data);
        }
    }
}