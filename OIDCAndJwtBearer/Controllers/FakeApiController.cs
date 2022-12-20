using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OIDCAndJwtBearer.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class FakeApiController : Controller
    {
        public IActionResult Index()
        {
            return Json(this.HttpContext.User.Claims.Select(c => new Tuple<string,string>(c.Type, c.Value)));
        }
    }
}
