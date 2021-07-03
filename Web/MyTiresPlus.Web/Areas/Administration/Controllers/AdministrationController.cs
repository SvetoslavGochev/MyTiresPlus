namespace MyTiresPlus.Web.Areas.Administration.Controllers
{
    using MyTiresPlus.Common;
    using MyTiresPlus.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
