using Microsoft.EntityFrameworkCore;
using OwnShop.DataAccess.Data;
using OwnShop.DataAccess.Interfaces.Customers;
using OwnShop.Domain.Entities.Customers;

namespace OwnShop.DataAccess.Repositories.Cotegories;

public class CostumerRepository : ICustomerRepository
{
    private readonly AppDbContext dbContext;

    public CostumerRepository(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<int> CountAsync()
    {
        return await dbContext.Customers.CountAsync();
    }

    public Task<int> CreateAsync(Customer repo)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IList<Customer>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Customer?> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateAsync(long id, Customer repo)
    {
        throw new NotImplementedException();
    }
}
