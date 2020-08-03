using Qiyin.AspNetCore31.Demo.Dto;
using Qiyin.AspNetCore31.Demo.Result;
using Qiyin.AspNetCore31.Demo.User.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qiyin.AspNetCore31.Demo.User.Service
{
    public class UserServiceImp : IUserService
    {
        public readonly IUserRepository userRepository;
        public UserServiceImp(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public void Create(UserDto userDto)
        {
            this.userRepository.Create(userDto);
        }

        public void Delete(UserDto userDto)
        {
            throw new NotImplementedException();
        }

        public UserResult GetByNick(string nickName)
        {
           return this.userRepository.GetByNick(nickName);
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
            return this.userRepository.UserExists(nickName);
        }
    }
}
