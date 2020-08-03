using Qiyin.AspNetCore31.Demo.Dto;
using Qiyin.AspNetCore31.Demo.Result;
using Qiyin.AspNetCore31.Demo.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qiyin.AspNetCore31.Demo.User.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserContext userContext;
        public UserRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }
        public void Create(UserDto userDto)
        {
            this.userContext.User.Add(userDto);
            this.userContext.SaveChanges();
        }

        public void Delete(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public UserResult GetByNick(string nickName)
        {
            
            var userDto=  this.userContext.User.FirstOrDefault(x => x.NickName == nickName);
            return MapperProvider.Instance.Map<UserResult>(userDto);
        }

        public IEnumerable<UserResult> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void Update(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public bool UserExists(string nickName)
        {
           return this.userContext.User.Any(x => x.NickName == nickName);
        }
    }
}
