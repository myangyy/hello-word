using OderingSystem.Context;
using OderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OderingSystem.Service
{
    public interface ILoginService
    {
        LoginMessage Lgoin(AccountEntry account, ShuNiuContext context);
    }
}
