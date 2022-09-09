using Com.Anqa.Service.Auth.Lib.BusinessLogic.Interfaces;
using Com.Anqa.Service.Auth.Lib.Models;
using Com.Anqa.Service.Auth.Lib.ViewModels;
using Com.Anqa.Service.Auth.Test.Utils;
using Com.Anqa.Service.Auth.WebApi.Controllers.v1;

namespace Com.Anqa.Service.Auth.Test.Controllers
{
    public class AccountsControllerTest : BaseControllerTest<AccountsController, Account, AccountViewModel, IAccountService>
    {
    }
}
