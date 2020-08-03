using Qiyin.AspNetCore31.Demo.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Qiyin.AspNetCore31.Demo.Models
{
    public class UserInfoArgs
    {
        /// <summary>
        /// 昵称
        /// </summary>
        [Required]
        public string NickName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        public string PassWord { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [Required]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        //public Sex sex { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        [Required]
        public int Age { get; set; }

        
    }
}
