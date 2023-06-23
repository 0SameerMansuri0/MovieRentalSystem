using CQRSProject.CQRS;
using CQRSProject.Model;
using CQRSProject.Repository;
using MediatR;

namespace CQRSProject.Handlers
{
    public class EmployeeListHandler : IRequestHandler<GetEmployeeListQuery, List<Employee>>
    {
        readonly IEmployeeRepository _employeeRepository;

        public EmployeeListHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            var list =await _employeeRepository.GetEmployeesAsync();
            return list;
        }
    }
}
