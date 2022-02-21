using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication6.Controllers 
{
    
    public class CustomerController : Controller
    {
        private ApplicationDbContext dbContext;
        public CustomerController(ApplicationDbContext 

            dbContext)
             {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Location>locations = dbContext.Location.ToList();
            return View(locations);
        }
        public IActionResult CustomerList(int id)
        {
            List<Customer>
             customers = dbContext.Customer.Where(e => e.Location.Id == id).ToList();
            return View(customers);
        }
    }
}
