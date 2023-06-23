using MediatR;

namespace CQRSProject.CQRS
{
    public class UpdateEmployeeCommand:IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string City { get; set; }

        public UpdateEmployeeCommand(int id, string name, string address, string city)
        {
            Id = id;
            Name = name;
            Address = address;
            City = city;
        }
    }
}
