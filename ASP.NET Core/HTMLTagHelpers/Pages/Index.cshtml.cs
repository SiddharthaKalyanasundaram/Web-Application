using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace HTMLTagHelpers.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IList<Employee> Employees { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            Employees = new List<Employee>() { new Employee { Id = "1", Name = "Siddy" }, new Employee { Id = "2", Name = "Durga" } };
            _logger = logger;
        }
        
        public void OnGetDetails(int id)
        {
            // return new LocalRedirectResult(Request.Path);
        }

            public void Details(int id)
        {
            // return new LocalRedirectResult(Request.Path);
        }

        public void OnDetails(int id)
        {
            // return new LocalRedirectResult(Request.Path);
        }

        public void OnGet(int id)
        {
            //return View();
        }

        public void OnPost(int id)
        {

        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }
}
