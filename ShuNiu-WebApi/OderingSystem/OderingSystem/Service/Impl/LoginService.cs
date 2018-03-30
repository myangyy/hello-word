using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OderingSystem.Context;
using OderingSystem.Models;
using OderingSystem.Common;

namespace OderingSystem.Service.Impl
{
    public class LoginService : ILoginService
    {
        public LoginMessage Lgoin(AccountEntry account, ShuNiuContext context)
        {
            LoginMessage message = new LoginMessage(); 
            try
            {
                AccountEntry byName = context.Accounts.Where(a => a.Name == account.Name).FirstOrDefault();
                AccountEntry byPass = context.Accounts.Where(a => a.PassWord == account.PassWord).SingleOrDefault();
                if (byName != null && byPass != null)
                {
                    RoleEntry role = context.Roles.Find(byName.RoleId);
                    if (!string.IsNullOrEmpty(role.Id))
                    {
                        if (role.Name.Equals("SuperAdmin"))
                        {
                            message.Message = "SuperAdmin登陆成功";
                            message.LoginResult = LoginResult.SuperAdminLogin;
                        }
                        else if (role.Name.Equals("Admin"))
                        {
                            message.Message = "Admin登陆成功";
                            message.LoginResult = LoginResult.AdminLogin;
                        }
                        else if (role.Name.Equals("User"))
                        {
                            message.Message = "User登陆成功";
                            message.LoginResult = LoginResult.UserLogin;
                        }
                    }
                    else
                    {
                        message.Message = "用户名或密码错误";
                        message.LoginResult = LoginResult.LoginFailed;
                    }
                }
                else
                {
                    message.Message = "用户名或密码错误";
                    message.LoginResult = LoginResult.LoginFailed;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
            return message;
        }
    }
}