using OderingSystem.Context;
using OderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OderingSystem.Common
{
    public class DataUtil
    {
        public static void InitSuperAdmin(ShuNiuContext context)
        {
            try
            {
                var rl = context.Roles.ToList();
                var rol = rl.Where(a => a.Name.Equals("SuperAdmin")).FirstOrDefault();
                if (rol == null)
                {
                    string roleId = Guid.NewGuid().ToString();
                    AccountEntry account = new AccountEntry()
                    {
                        Id = Guid.NewGuid().ToString(),
                        RoleId = roleId,
                        Name = "EricYang",
                        ChineseName = "杨明",
                        PassWord = "1qaz2wsxE",
                    };
                    context.Accounts.Add(account);
                    RoleEntry role = new RoleEntry()
                    {
                        Id = roleId,
                        Name = "SuperAdmin",
                    };
                    context.Roles.Add(role);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}