using InterviewTest.Data;
using InterviewTest.Interfaces;
using InterviewTest.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace InterviewTest.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context) {
            _context = context;
        }
        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _context.Employees.Include(e => e.Department).ToListAsync();
        }

        public async Task<IEnumerable<Employee>> GetEldestAndYoungestEmployees()
        {
            return await _context.Employees.OrderBy(e => e.Age).Take(1).Include(c => c.Department)
                  .Concat(_context.Employees.OrderByDescending(e => e.Age).Take(1).Include(c => c.Department))
                  .ToListAsync();
        }
    }
}
