using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceSystem.Areas.Admin.Controllers
{
    //[Area("Admin"), Authorize(Policy = "RestrictedArea")]
    [Area("Admin"), Authorize(Policy = "ViewPermission")]
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
