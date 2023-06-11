using InterviewTest.Interfaces;
using InterviewTest.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InterviewTest.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [EnableCors("_myAllowSpecificOrigins")]
        [HttpGet(Name = "GetEmployees")]
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _employeeRepository.GetAll();
        }

        [EnableCors("_myAllowSpecificOrigins")]
        [HttpGet(Name = "GetEldestAndYoungestEmployees")]
        public async Task<IEnumerable<Employee>> GetEldestAndYoungestEmployees()
        {
            return await _employeeRepository.GetEldestAndYoungestEmployees();
        }

    }
}
