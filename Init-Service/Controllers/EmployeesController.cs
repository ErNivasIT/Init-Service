using Microsoft.AspNetCore.Mvc;
using Models;

[ApiController]
[Route("[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly ILogger<EmployeesController> logger;
    private readonly IEmployeesBAL bal;

    public EmployeesController(ILogger<EmployeesController> logger,IEmployeesBAL bal)
    {
        this.logger = logger;
        this.bal = bal;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var lst=await bal.GetEmployees();
        return Ok(lst.ToList());
    }
}