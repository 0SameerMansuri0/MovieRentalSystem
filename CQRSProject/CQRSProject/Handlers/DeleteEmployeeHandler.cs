using CQRSProject.CQRS;
using CQRSProject.Repository;
using MediatR;

namespace CQRSProject.Handlers
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, int>
    {
        readonly IEmployeeRepository _employeeRepository;

        public DeleteEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<int> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.DeleteEmployeeAsync(request.Id);
        }
    }
}
