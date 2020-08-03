using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qiyin.AspNetCore31.Demo.Dto
{
    public class UserDto
    {
        public  int Id { set; get; }
        public string NickName { get; set; }
        public string PhoneNumber { get; set; }
        public string PassWord { get; set; }
        public int Age { get; set; }
    }
}
