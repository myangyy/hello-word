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
                List<AccountEntry> accounts = context.Accounts.ToList();
                AccountEntry source = accounts.Where(a => a.Name.Equals(account.Name) && a.PassWord.Equals(account.PassWord)).FirstOrDefault();
                if (source!=null)
                {
                    message.Message = "查询到account";
                    message.LoginResult = LoginResult.LoginSuccess;
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