using Microsoft.EntityFrameworkCore;
using TestowyKolos2.Models;

namespace TestowyKolos2.Services
{
    public interface IClientsServices
    {
        public Task<Client?> GetByLastNameAsync(string lastName);
    }


    public class ClientsServices : IClientsServices
    {
        private readonly MyDbContext _dbContext;

        public ClientsServices(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Client?> GetByLastNameAsync(string lastName)
        {
            var client = _dbContext.Clients.Include(c => c.Orders).ThenInclude(c => c.OrdersPastries)
                .ThenInclude(c => c.Pastry).SingleOrDefault(c => c.LastName == lastName);


            return client;
        }
    }
}