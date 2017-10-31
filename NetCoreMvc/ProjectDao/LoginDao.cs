using System.Collections.Generic;
using System.Linq;
using Models;
using ProjectContracts;
namespace ProjectDao
{
    public class LoginDao:ILogin
    {
        private DataContext _dataContext;

        public LoginDao(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public UserInfo Login(string userName,string password)
        {

            return _dataContext.UserInfos.Where(o=>o.UserName==userName&&o.Password==password).FirstOrDefault();
        }
    }
}