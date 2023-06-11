using InterviewTest.Models;

namespace InterviewTest.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAll();

        Task<IEnumerable<Employee>> GetEldestAndYoungestEmployees();
    }
}
