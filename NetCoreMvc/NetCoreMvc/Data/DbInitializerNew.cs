using System.Data.Common;
using System.Linq;
using Models;

namespace NetCoreMvc.Data
{
    public class DbInitializerNew
    {
        public static void Initialize(DataContext context)
        {
            context.Database.EnsureCreated();
            if (context.UserInfos.Any())
            {
                return;
            }

            var userInfos = new UserInfo[]
            {
                new UserInfo {UserName = "lijiang", Password = "123456"},
                new UserInfo { UserName = "administrator", Password = "123456"}
            };

            foreach (var userInfo in userInfos)
            {
                context.UserInfos.Add(userInfo);
            }
            context.SaveChanges();
        }
    }
}