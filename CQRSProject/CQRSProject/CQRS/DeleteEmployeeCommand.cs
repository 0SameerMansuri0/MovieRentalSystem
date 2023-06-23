using MediatR;

namespace CQRSProject.CQRS
{
    public class DeleteEmployeeCommand:IRequest<int>
    {
        public int Id { get; set;}
    }
}
