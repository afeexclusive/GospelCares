using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GospelCares.Models;
using GospelCares.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace GospelCares.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICare _care;
        //private readonly RoleManager<IdentityRole> roleManager;
        //private readonly UserManager<IdentityUser> userManager;

        Request newrequest;
        Supply newsupply;

        public HomeController(ILogger<HomeController> logger, ICare care) //RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager
        {
            _logger = logger;
            _care = care;
            //this.roleManager = roleManager;
            //this.userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //----------------------------- ---------------------------------------
        //[Authorize(Roles = "Admin")]
        //[HttpGet]
        //public IActionResult CreateRole()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        IdentityRole identityRole = new IdentityRole
        //        {
        //            Name = model.RoleName
        //        };

        //        IdentityResult result = await roleManager.CreateAsync(identityRole);

        //        if (result.Succeeded)
        //        {
        //            return RedirectToAction("listroles", "home");
        //        }

        //        foreach (IdentityError error in result.Errors)
        //        {
        //            ModelState.AddModelError("", error.Description);
        //        }
        //    }
        //    return View(model);
        //}

        //[Authorize(Roles = "Admin")]
        //[HttpGet]
        //public IActionResult ListRoles()
        //{
        //    var roles = roleManager.Roles;
        //    return View(roles);
        //}

        //[Authorize(Roles = "Admin")]
        //[Route("Edit/{id}")]
        //[HttpGet]
        //public async Task<IActionResult> EditRole(string id)
        //{
        //    var role = await roleManager.FindByIdAsync(id);
        //    if (role == null)
        //    {
        //        ViewBag.ErrorMessage = $"Role with Id: {id} cannot be found";
        //        return View("PastorNotFound");
        //    }

        //    var model = new EditRoleViewModel
        //    {
        //        Id = role.Id,
        //        RoleName = role.Name

        //    };

        //    foreach (var user in userManager.Users.ToList())
        //    {
        //        if (await userManager.IsInRoleAsync(user, role.Name))
        //        {
        //            model.Users.Add(user.UserName);
        //        }
        //    }
        //    return View(model);
        //}

        //[Authorize(Roles = "Admin")]
        //[HttpPost]
        //public async Task<IActionResult> EditRole(EditRoleViewModel model)
        //{
        //    var role = await roleManager.FindByIdAsync(model.Id);
        //    if (role == null)
        //    {
        //        ViewBag.ErrorMessage = $"Role with Id: {model.Id} cannot be found";
        //        return View("PastorNotFound");
        //    }
        //    else
        //    {
        //        role.Name = model.RoleName;
        //        var result = await roleManager.UpdateAsync(role);
        //        if (result.Succeeded)
        //        {
        //            return RedirectToAction("ListRoles");
        //        }

        //        foreach (var error in result.Errors)
        //        {
        //            ModelState.AddModelError("", error.Description);
        //        }
        //        return View(model);
        //    }

        //}

        //[Authorize(Roles = "Admin")]
        //[HttpGet]
        //[Route("{id}")]
        //public async Task<IActionResult> EditUsersInRole(EditRoleViewModel param)
        //{

        //    ViewBag.roleId = param.Id;
        //    var role = await roleManager.FindByIdAsync(param.Id);
        //    if (role == null)
        //    {
        //        ViewBag.ErrorMessage = $"Role with Id: {param.Id} could not be found";
        //        return View("NotFound");
        //    }

        //    var model = new List<UserRoleViewModel>();

        //    foreach (var user in userManager.Users.ToList())
        //    {
        //        var userRoleViewModel = new UserRoleViewModel
        //        {
        //            UserId = user.Id,
        //            UserName = user.UserName
        //        };

        //        if (await userManager.IsInRoleAsync(user, role.Name))
        //        {
        //            userRoleViewModel.IsSelected = true;
        //        }
        //        else
        //        {
        //            userRoleViewModel.IsSelected = false;
        //        }
        //        model.Add(userRoleViewModel);
        //    }
        //    return View(model);
        //}

        //[HttpPost]
        //[Route("{id}")]
        //public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, EditRoleViewModel roleId)
        //{
        //    var role = await roleManager.FindByIdAsync(roleId.Id);

        //    if (role == null)
        //    {
        //        ViewBag.ErrorMessage = $"Role with id = {roleId.Id} cannot be found";
        //        return View("NotFound");
        //    }

        //    for (int i = 0; i < model.Count; i++)
        //    {
        //        var user = await userManager.FindByIdAsync(model[i].UserId);
        //        IdentityResult result = null;
        //        if (model[i].IsSelected && !(await userManager.IsInRoleAsync(user, role.Name)))
        //        {
        //            result = await userManager.AddToRoleAsync(user, role.Name);
        //        }
        //        else if (!model[i].IsSelected && await userManager.IsInRoleAsync(user, role.Name))
        //        {
        //            result = await userManager.RemoveFromRoleAsync(user, role.Name);
        //        }
        //        else
        //        {
        //            continue;
        //        }

        //        if (result.Succeeded)
        //        {
        //            if (i < (model.Count - 1))
        //            {
        //                continue;
        //            }
        //            return RedirectToAction("EditRole", new { Id = roleId.Id });
        //        }
        //    }

        //    return RedirectToAction("EditRole", new { Id = roleId.Id });
        //}


        //-----------------------------------------------------------------------------------------------------------------------------




        [HttpGet]
        public IActionResult CreateRequest()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateRequest(CreateRequest model)
        {
            newrequest = new Request
            {
                FullName = model.FullName,
                Branch = model.Branch,
                PastorName = model.PastorName,
                Need = model.Need,
                Phone = model.Phone,
                Address = model.Address,
                Status = NeedStatus.Unconfirmed,
            };
            _care.AddRequest(newrequest);
            return RedirectToAction("Index"); 
        }

        [HttpGet]
        public IActionResult CreateSupply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSupply(CreateSupplyViewModel model)
        {
            newsupply = new Supply
            {
                FullName = model.FullName,
                Email = model.Email,
                Need = model.Need,
                NeedDetails = model.NeedDetails,
                Phone = model.Phone,
                Address = model.Address,
                SStatus = SupplyStatus.pending
            };
            _care.AddSupply(newsupply);
            return RedirectToAction("Index");
        }

        [Authorize]
        [HttpGet]
        public IActionResult AdminView()
        {
            var confReq = _care.GetConfirmedRequest(NeedStatus.Confirmed);
            var unconfReq = _care.GetUnconfirmedRequests(NeedStatus.Unconfirmed);
            var treatedReq = _care.GetTreatedRequest(NeedStatus.Treated);

            var pendsupply = _care.GetPendingSupplies(SupplyStatus.pending);
            var treatedsupply = _care.GetTreatedSupplies(SupplyStatus.Supplied);
            AdminViewModel adminViewModel = new AdminViewModel()
            {
                ConfirmedRequest = confReq.ToList(),
                UnConfirmedRequest = unconfReq.ToList(),
                TreatedRequest = treatedReq.ToList(),
                PendingSupply = pendsupply.ToList(),
                TreatedSupply = treatedsupply.ToList()
            };

            return View(adminViewModel);
        }

        [Authorize]
        [HttpGet]
        public IActionResult PastorsView()
        {
            
            var unconfReq = _care.GetUnconfirmedRequests(NeedStatus.Unconfirmed);
            
            PastorViewModel adminViewModel = new PastorViewModel()
            {
                UnConfirmedRequest = unconfReq.ToList(),
            };

            return View(adminViewModel);
        }

        [Authorize]
        [Route("pastorsingleUncon/{id?}")]
        //[HttpPost]
        public IActionResult PastorProcessSingleUnconfirmed(int id)
        {
            var upRequest = _care.GetRequest(id);
            upRequest.Status = NeedStatus.Confirmed;
            _care.UpdateRequest(upRequest);
            return RedirectToAction("PastorsView");
        }

        [Authorize]
        [Route("adminsingleUncon/{id?}")]
        //[HttpPost]
        public IActionResult AdProcessSingleUnconfirmed(int id)
        {
            var upRequest = _care.GetRequest(id);
            upRequest.Status = NeedStatus.Confirmed;
            _care.UpdateRequest(upRequest);
            return RedirectToAction("AdminView");
        }

        [Authorize]
        [Route("ProcessSingleConfirmed/{id?}")]
        [Authorize]
        //[HttpPost]
        public IActionResult ProcessSingleConfirmed(int id)
        {
            var upRequest = _care.GetRequest(id);
            upRequest.Status = NeedStatus.Treated;
            _care.UpdateRequest(upRequest);
            return RedirectToAction("AdminView");
        }

        public IActionResult ProcessAllUnconfirmed()
        {
            var alluncof = _care.GetUnconfirmedRequests(NeedStatus.Unconfirmed);

            foreach (var req in alluncof)
            {
                req.Status = NeedStatus.Confirmed;

                _care.UpdateRequest(req);
            }
            return RedirectToAction("AdminView");
        }

        [Authorize]
        [Route("supplyproc/{id?}")]
        [Authorize]
        //[HttpPost]
        public IActionResult ProcessSingleSupply(int id)
        {
            var upSupply = _care.GetSupply (id);
            upSupply.SStatus = SupplyStatus.Supplied;
            _care.UpdateSupply(upSupply);
            return RedirectToAction("AdminView");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
