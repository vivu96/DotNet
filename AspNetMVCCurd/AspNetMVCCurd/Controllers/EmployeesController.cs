using AspNetMVCCurd.Data;
using AspNetMVCCurd.Models;
using AspNetMVCCurd.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace AspNetMVCCurd.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly MVCDemoDbContext mvcDemoDbContext;

        public EmployeesController(MVCDemoDbContext mvcDemoDbContext)
        {
          this.mvcDemoDbContext = mvcDemoDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
         var emp =  await mvcDemoDbContext.Employees.ToListAsync();
            return View(emp);
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel AddEmployeeRequest)
        {
            var x = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = AddEmployeeRequest.Name,
                Email = AddEmployeeRequest.Email,
                Phone = AddEmployeeRequest.Phone,
                Salary = AddEmployeeRequest.Salary,
                dateofBirth = AddEmployeeRequest.dateofBirth,
                Department = AddEmployeeRequest.Department

        };
             await  mvcDemoDbContext.Employees.AddAsync(x);
            await   mvcDemoDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
            
                }

        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
         {
          var employee = await mvcDemoDbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);

            if (employee != null)
            {

                var viewModel = new UpdateEmployeeViewModel()
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Email = employee.Email, 
                    Phone = employee.Phone,
                    Salary = employee.Salary,
                    dateofBirth = employee.dateofBirth,
                    Department = employee.Department
              };
              return View(viewModel);
          }
          return RedirectToAction("Index");

        }
       
    }
}
