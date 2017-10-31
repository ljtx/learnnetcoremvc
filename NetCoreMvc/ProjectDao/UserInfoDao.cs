using System.Collections.Generic;
using System.Linq;
using Models;
using ProjectContracts;

namespace ProjectDao
{
    public class UserInfoDao:IUserInfoDao
    {
        private DataContext _dataContext;

        public UserInfoDao(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public  IList<UserInfo> GetAll()
        {
            return this._dataContext.UserInfos.ToList();
        }
    }
}