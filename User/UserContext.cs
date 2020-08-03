using Microsoft.EntityFrameworkCore;
using Qiyin.AspNetCore31.Demo.Dto;
using Qiyin.AspNetCore31.Demo.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qiyin.AspNetCore31.Demo.User
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        public DbSet<UserDto> User { get; set; }
        public DbSet<Qiyin.AspNetCore31.Demo.Result.UserResult> UserResult { get; set; }

    }
}
