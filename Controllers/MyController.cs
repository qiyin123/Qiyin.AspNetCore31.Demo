using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Qiyin.AspNetCore31.Demo.Dto;
using Qiyin.AspNetCore31.Demo.Models;
using Qiyin.AspNetCore31.Demo.User.Service;
using Qiyin.AspNetCore31.Demo.Utility;

namespace Qiyin.AspNetCore31.Demo.Controllers
{
    public class MyController : Controller
    {
        public IUserService userService;
        public MyController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowUserInfo(string nickName)
        {
            if (!this.userService.UserExists(nickName))
            {
                return RedirectToAction("Register");
            }
            var userResult= this.userService.GetByNick(nickName);
            ViewBag.Model = userResult;
            return View(userResult);
        }
        public IActionResult Login(UserLoginArgs userLoginArgs)
        {
            string nickName = base.HttpContext.Session.GetString("NickName");
            if (!string.IsNullOrEmpty(nickName))
            {
                return RedirectToAction("ShowUserInfo", new { nickName = nickName });
            }
            else if (!string.IsNullOrWhiteSpace(userLoginArgs.NickName))
            {
                //检查该用户是否存在
                if (!this.userService.UserExists(userLoginArgs.NickName))
                {
                    return RedirectToAction("Register");
                }
                else
                {
                   var userResult = this.userService.GetByNick(userLoginArgs.NickName);
                    if (!string.Equals(userLoginArgs.PassWord,userResult.PassWord.Trim()))
                    {
                        //可以通过ajax返回提示"用户名或密码错误"
                        return View();
                    }
                    else
                    {
                        base.HttpContext.Session.SetString("NickName", userResult.NickName);
                        return RedirectToAction("ShowUserInfo", new { nickName = userLoginArgs.NickName });
                    }
                }
                
            }
            else
            {
                return View();
            }
            
        }
        public IActionResult Register(UserInfoArgs userInfoArgs)
        {
            if (!string.IsNullOrWhiteSpace(userInfoArgs.NickName))
            {
                var userDto = MapperProvider.Instance.Map<UserDto>(userInfoArgs);
                this.userService.Create(userDto);

                return RedirectToAction("ShowUserInfo", new { nickName = userInfoArgs.NickName });
            }
            else
            {
                return View();
            }
           
        }
    }
}
