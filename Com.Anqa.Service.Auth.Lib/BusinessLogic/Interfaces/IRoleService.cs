using Com.Anqa.Service.Auth.Lib.Models;
using Com.Anqa.Service.Auth.Lib.Utilities.BaseInterface;
using Com.Anqa.Service.Auth.Lib.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Anqa.Service.Auth.Lib.BusinessLogic.Interfaces
{
    public interface IRoleService : IBaseService<Role>
    {
        bool CheckDuplicate(int id, string code);
    }
}
