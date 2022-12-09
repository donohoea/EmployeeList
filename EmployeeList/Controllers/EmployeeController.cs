using Microsoft.AspNetCore.Mvc;

namespace EmployeeList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {

        private readonly EmployeeContext _employeeContext;
        public EmployeeController(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Employee> employees = _employeeContext.Employees.ToList();
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Employee employee)
        {
            _employeeContext.Employees.Add(employee);
            _employeeContext.SaveChanges();
            return Ok(employee);
        }

        [HttpPatch("{id:int}")]
        public IActionResult Update(int id, [FromBody] Employee employee)
        {
            Employee entity = _employeeContext.Employees.FirstOrDefault(emp => emp.EmployeeId == id); 
            if (entity == null)
            {
                return NotFound();
            }
            _employeeContext.Employees.Update(entity);
            _employeeContext.SaveChanges();
            return Ok(entity);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id) {
            Employee entity = _employeeContext.Employees.FirstOrDefault(emp => emp.EmployeeId == id);
            if (entity == null)
            {
                return NotFound();
            }
            _employeeContext.Employees.Remove(entity);
            _employeeContext.SaveChanges();
            return Ok(id);
        }
    }
}