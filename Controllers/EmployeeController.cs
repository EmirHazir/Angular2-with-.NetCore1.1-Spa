using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaAngularDemo.Models;
using Microsoft.EntityFrameworkCore;
using SpaAngularDemo.ViewModel;

namespace SpaAngularDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private EmployeeDbContext _context;
        public EmployeeController(EmployeeDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> EmployeeList()
        {
            List<Employee_Project> iList = new List<Employee_Project>();
            var listData = await (from emp in _context.Employee
                                  join proj in _context.Project on emp.ProjectId equals
                                  proj.ProjectId
                                  select new
                                  {
                                      emp.EmployeeId,
                                      emp.EmployeeName,
                                      emp.Destination,
                                      proj.ProjectName
                                  }).ToListAsync();
            listData.ForEach(x =>
            {
                Employee_Project obj = new Employee_Project();
                obj.EmployeeId = x.EmployeeId;
                obj.Destination = x.Destination;
                obj.EmployeeName = x.EmployeeName;
                obj.Project = x.ProjectName;
                iList.Add(obj);
            });
            return Json(iList);
        }
    }
}
