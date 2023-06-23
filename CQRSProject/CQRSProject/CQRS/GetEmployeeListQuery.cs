using CQRSProject.Model;
using MediatR;

namespace CQRSProject.CQRS
{
    public class GetEmployeeListQuery:IRequest<List<Employee>>
    {

    }
}
