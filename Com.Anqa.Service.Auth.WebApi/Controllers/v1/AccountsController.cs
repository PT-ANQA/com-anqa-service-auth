using AutoMapper;
using Com.Anqa.Service.Auth.Lib.BusinessLogic.Interfaces;
using Com.Anqa.Service.Auth.Lib.Models;
using Com.Anqa.Service.Auth.Lib.Services.IdentityService;
using Com.Anqa.Service.Auth.Lib.Services.ValidateService;
using Com.Anqa.Service.Auth.Lib.ViewModels;
using Com.Anqa.Service.Auth.WebApi.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
 
namespace Com.Anqa.Service.Auth.WebApi.Controllers.v1
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/accounts")]
    [Authorize]
    public class AccountsController : BaseController<Account, AccountViewModel, IAccountService>
    {

        public AccountsController(IIdentityService identityService, IValidateService validateService, IAccountService service, IMapper mapper) : base(identityService, validateService, service, mapper, "1.0.0")
        {

        }
    }
}
