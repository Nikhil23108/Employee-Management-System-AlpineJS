using Microsoft.AspNetCore.Mvc;
using DemoApp.Model;
using DemoApp.Employee;

namespace DemoApp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeApiController : ControllerBase
{
    private readonly EmpModel model = new();

    // 1. GET ALL EMPLOYEES
    [HttpGet]
    public IActionResult GetEmployees()
    {
        return Ok(model.FetchEmployees());
    }

    // 2. CREATE EMPLOYEE
    [HttpPost]
    public IActionResult AddEmployee([FromBody] Emp emp)
    {
        model.AcceptEmployee(emp);
        return Ok(new { Message = "Employee Added Successfully" });
    }

    // 3. UPDATE EMPLOYEE
    [HttpPut("{id}")]
    public IActionResult UpdateEmployee(int id, [FromBody] Emp emp)
    {
        bool updated = model.ModifyEmployee(id, emp);

        if (!updated)
        {
            return NotFound(new { Message = $"Employee with ID {id} not found." });
        }

        return Ok(new { Message = "Employee Updated Successfully" });
    }

    // 4. DELETE EMPLOYEE
    [HttpDelete("{id}")]
    public IActionResult RemoveEmployee(int id)
    {
        bool deleted = model.DeleteEmployee(id);
        if (!deleted)
        {
            return NotFound(new { Message = $"Employee with ID {id} not found." });
        }

        return Ok(new { Message = "Employee Deleted Successfully" });
    }
}