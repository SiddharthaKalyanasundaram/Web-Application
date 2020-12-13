using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Pages
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

        public void OnGet()
        {

        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }
}
