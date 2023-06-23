using CQRSProject.Context;
using CQRSProject.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace CQRSProject.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            var result= _context.Add(employee);
            _context.SaveChanges();
            return result.Entity;
        }

        public async Task<int> DeleteEmployeeAsync(int id)
        {
           var employee= await _context.Employees.Where(u=>u.Id==id).FirstOrDefaultAsync();
            _context.Remove(employee);
           return _context.SaveChanges();

        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
         var employee=await _context.Employees.FirstAsync(u=>u.Id==id);
          return employee;
          
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            var employees = await _context.Employees.ToListAsync();
            return employees;
        }

        public async  Task<int> UpdateEmployeeAsync(Employee employee)
        {
            _context.Update(employee);
          return  _context.SaveChanges();
        }
    }
}
