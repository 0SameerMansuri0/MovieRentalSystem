using CQRSProject.Model;
using MediatR;

namespace CQRSProject.CQRS
{
    public class GetEmployeeByIdQuery:IRequest<Employee>
    {
        public int Id { get; set; }
    }
}
