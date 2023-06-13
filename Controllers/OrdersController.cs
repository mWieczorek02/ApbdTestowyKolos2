using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestowyKolos2.Services;

namespace TestowyKolos2.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IClientsServices _clientsServices;

        public OrdersController(IClientsServices clientsServices)
        {
            _clientsServices = clientsServices;
        }



        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string clientLastName)
        {
            var client = await _clientsServices.GetByLastNameAsync(clientLastName);
            if (client is null) return NotFound();
            
            return Ok(client.Orders.Select(o => new OrderDto
            {
                ID = o.Id,
                AcceptedAt = o.AcceptedAt.ToString("dd/MM/yyyy"),
                FulfilledAt = o.FulfilledAt?.ToString("dd/MM/yyyy"),
                comments = o.Comments,
                Pastries = o.OrdersPastries.Select(p => new PastryDto
                {
                    Name = p.Pastry.Name,
                    price = p.Pastry.Price,
                    amount = p.Amount
                }).ToList()
                
            }));
        }
    }
}

public class OrderDto {
    public int ID { get; set; }
    public string AcceptedAt { get; set; }
    public string? FulfilledAt { get; set; }
    public string? comments { get; set; }
    public List<PastryDto> Pastries { get; set; }
}

public class PastryDto
{
    public string Name { get; set; }
    public decimal price { get; set; }
    public int amount { get; set; }
}