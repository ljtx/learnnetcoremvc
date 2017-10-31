using System;
using System.Collections.Generic;
using Models;

namespace ProjectContracts
{
    public interface IUserInfoDao
    {
        IList<UserInfo> GetAll();  
    }
}