using CQRSProject.CQRS;
using CQRSProject.Model;
using CQRSProject.Repository;
using MediatR;

namespace CQRSProject.Handlers
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCammand, Employee>
    {
        readonly IEmployeeRepository _employeeRepository;

        public CreateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> Handle(CreateEmployeeCammand request, CancellationToken cancellationToken)
        {
            Employee emp=new Employee()
            {
                Name = request.Name,
                Address = request.Address,
                City = request.City,
            };
            return await _employeeRepository.AddEmployeeAsync(emp);
        }
    }
}
