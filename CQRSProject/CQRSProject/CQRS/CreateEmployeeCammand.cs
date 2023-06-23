using CQRSProject.Model;
using MediatR;

namespace CQRSProject.CQRS
{
    public class CreateEmployeeCammand:IRequest<Employee>
    {

        public string Name { get; set; }
        public string Address { get; set; }

        public string City { get; set; }

        public CreateEmployeeCammand(string name, string address, string city)
        {
            Name = name;
            Address = address;
            City = city;
        }
    }
}
