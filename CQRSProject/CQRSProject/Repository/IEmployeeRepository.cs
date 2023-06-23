using CQRSProject.Model;

namespace CQRSProject.Repository
{
    public interface IEmployeeRepository
    {
        public Task<List<Employee>> GetEmployeesAsync();
        public Task<Employee> GetEmployeeByIdAsync(int id);

        public Task<Employee> AddEmployeeAsync(Employee employee);

        public Task<int> DeleteEmployeeAsync(int id);

        public Task<int> UpdateEmployeeAsync(Employee employee);
    }
}
