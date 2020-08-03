using Qiyin.AspNetCore31.Demo.Dto;
using Qiyin.AspNetCore31.Demo.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qiyin.AspNetCore31.Demo.User.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<UserResult> GetUsers();
        UserResult GetByNick(string nickName);

        void Create(UserDto userDto);
        void Update(UserDto userDto);
        void Delete(UserDto userDto);
        bool UserExists(string nickName);
    }
}
