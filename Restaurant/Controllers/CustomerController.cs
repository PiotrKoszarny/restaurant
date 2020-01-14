using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Controllers.Model;
using Restaurant.DataAccess.Command;
using Restaurant.Model;
using Swashbuckle.Swagger.Annotations;

namespace Restaurant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("add-customer")]
        public async Task<ActionResult<CustomerDto>> AddCustomer([FromBody]AddCustomerRequest request)
        {
            var result = await _mediator.Send(new AddCustomerCommand(request.Name));

            return Ok(result);
        }

        [HttpGet]
        [Route("customers")]
        public async Task<ActionResult<List<string>>> GetCustomers()
        {
            return Ok(new List<string>());
        }


        [HttpGet]
        [Route("customer/{id}")]
        public async Task<ActionResult<CustomerDto>> GetCustomer(int id)
        {
            return Ok(new CustomerDto
            {
                CustomerId=1,
                Name = "xDDD"
            });
        }

    }
}