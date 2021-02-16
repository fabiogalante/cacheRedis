using System;
using System.Threading.Tasks;
using DistributedCacheRedis.Data;
using Microsoft.AspNetCore.Mvc;

namespace DistributedCacheRedis.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        // GET
        [HttpGet("")]
        public async Task<IActionResult> GetEmployees()
        {
            try
            {
                var employee = await _employeeRepository.GetEmployees();
                return Ok(employee);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}