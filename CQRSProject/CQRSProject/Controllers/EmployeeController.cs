using CQRSProject.CQRS;
using CQRSProject.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CQRSProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<IEnumerable<Employee>> GetEmployeeList()
        {
            return await _mediator.Send(new GetEmployeeListQuery());
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<Employee> GetEmployeById(int id)
        {
            return await _mediator.Send<Employee>(new GetEmployeeByIdQuery() { Id = id });
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<Employee> AddEmployee([FromBody] Employee employee)
        {
            return await _mediator.Send(new CreateEmployeeCammand(employee.Name,employee.Address,employee.City) );
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public async Task<int> UpdateEmployee(int id, [FromBody] Employee employee)
        {
            return await _mediator.Send(new UpdateEmployeeCommand(
                employee.Id,employee.Name,employee.Address,employee.City) );
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task<int> DeleteEmployee(int id)
        {
            return await _mediator.Send(new DeleteEmployeeCommand() { Id=id});
        }
    }
}
