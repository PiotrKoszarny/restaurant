using MediatR;
using Restaurant.DataAccess.Entity;
using Restaurant.Model;
using System.Threading;
using System.Threading.Tasks;

namespace Restaurant.DataAccess.Command
{
    public class AddCustomerCommand : IRequest<CustomerDto>
    {
        public AddCustomerCommand(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }

    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, CustomerDto>
    {
        private readonly FoodDbContext _foodDbContext;

        public AddCustomerCommandHandler(FoodDbContext foodDbContext)
        {
            _foodDbContext = foodDbContext;
        }

        public async Task<CustomerDto> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer
            {
                Name = request.Name
            };

            await _foodDbContext.AddAsync(customer);

            return new CustomerDto
            {
                Name = customer.Name,
                CustomerId = customer.Id
            };
        }
    }

}
