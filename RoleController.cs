using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using RolesAdmin.Models;

namespace RolesAdmin.Controllers
{
    public class RoleController : Controller
    {
        ApplicationDbContext context;

        public RoleController()
        {
            context = new ApplicationDbContext();
        }


        [Authorize(Roles = "Admin")]
     

         
            
        public ActionResult Index()
        {
            var Roles = context.Roles.ToList();
            return View(Roles);
        }

     
        /// Create  a New role
        
        
        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }

     
        /// Create a New Role
       
        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            context.Roles.Add(Role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Delete()
        {
            var Role = new IdentityRole();
            return View(Role);
        }

       
        /// delete a New Role
      
        [HttpPost]
        public ActionResult Delete(IdentityRole Role)
        {
            context.Roles.Remove(Role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }




    }
}