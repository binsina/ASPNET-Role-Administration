# ASPNET-Role-Administration
Add/Delete Roles to SQL server studio
Role Adminstration:

1.)Create an ASP.NET MCV Applicaton
2.) In the Model File we have a class called IdentityModel.cs, This file contains the ApplicationDbContext class. This class is used to connect to the database where the User and Roles table will be created. The class file AccountViewModels.cs contains classes for Login, Register, etc. In this file locate the RegisterViewModel class and add the following string property:

public string Name { get; set; }

3.) Now it is time to create a view for creating Roles for the application. Create an
empty Controller and Name it RolesController, Add the following Code:

using System;
using System.Linq;
using System.Web.Mvc;
 using  yourNamed.Models;
using Microsoft.AspNet.Identity.EntityFramework;
 
namespace  your_Name.Controllers
{
    public class RoleController : Controller
    {
        ApplicationDbContext context;
 
        public RoleController()
        {
            context = new ApplicationDbContext(); 
        }
      public ActionResult Index()
        {
            var Roles = context.Roles.ToList();
            return View(Roles);
        }
 
     
        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }
 
        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            context.Roles.Add(Role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
4.) Role creation is done using IdentityRole class. This class provides properties e.g. Id, Name, etc for creating roles for the applications. Scaffold the Index and Create view, using Index and Create Action method from the RoleController class. Follow my code file index.cshtml in the Role view.

5.) Open AccountController.cs and create an instance of ApplicationDbContext class in the AccountController Constructor.

ApplicationDbContext context;
 
public AccountController()
{
    context = new ApplicationDbContext();
}

6.) Add the following code in the Register() action method:

[AllowAnonymous]
public ActionResult Register()
{
    ViewBag.Name = new SelectList(context.Roles.ToList(), "Name", "Name");
    return View();
}

7.) Add the following code in the Register() action method:
[AllowAnonymous]
public ActionResult Register()
{
    ViewBag.Name = new SelectList(context.Roles.ToList(), "Name", "Name");
    return View();
}

7.) In the _Layout.cshtml view of the Shared sub folder of the Views folder, add the following piece of code for showing link for Role in a <div> element with the class navbar-collapse collapse.

<li>@Html.ActionLink("Role", "Index", "Role")</li>

8.) Run the application

