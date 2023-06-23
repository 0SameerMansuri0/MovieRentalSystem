using CQRSProject.CQRS;
using CQRSProject.Model;
using CQRSProject.Repository;
using MediatR;

namespace CQRSProject.Handlers
{
    public class EmployeeHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        readonly IEmployeeRepository _employeeRepository;

        public EmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetEmployeeByIdAsync(request.Id);
        }
    }
}
