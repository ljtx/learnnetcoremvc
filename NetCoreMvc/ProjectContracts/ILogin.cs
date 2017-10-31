using Models;

namespace ProjectContracts
{
    public interface ILogin
    {
        UserInfo Login(string userName,string password);
    }
}