using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Qiyin.AspNetCore31.Demo.Models
{
    public class UserLoginArgs
    {
        [Required]
        public string NickName { get; set; }
        [Required]
        public string PassWord { get; set; }
    }
}
