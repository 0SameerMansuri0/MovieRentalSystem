using CQRSProject.CQRS;
using CQRSProject.Repository;
using MediatR;

namespace CQRSProject.Handlers
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, int>
    {
        readonly IEmployeeRepository _employeeRepository;

        public UpdateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<int> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var emp = await _employeeRepository.GetEmployeeByIdAsync(request.Id);
            if (emp != null)
            {
                emp.Address = request.Address;
                emp.Name = request.Name;
                emp.City = request.City;

               return await _employeeRepository.UpdateEmployeeAsync(emp);

            }
            else
                return default;
        }
    }
}
