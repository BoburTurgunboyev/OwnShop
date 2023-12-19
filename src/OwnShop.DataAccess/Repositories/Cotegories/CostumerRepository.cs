using Microsoft.EntityFrameworkCore;
using OwnShop.DataAccess.Data;
using OwnShop.DataAccess.Interfaces.Customers;
using OwnShop.Domain.Entities.Customers;
using System.Runtime.InteropServices;

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

    public async Task<int> CreateAsync(Customer repo)
    {
         await dbContext.Customers.AddAsync(repo);
         return await dbContext.SaveChangesAsync();
    }
    

    public async Task<bool> DeleteAsync(long id)
    {
        var costumer = await dbContext.Customers.FirstOrDefaultAsync(x => x.Id == id);
        if (costumer is null)
            return false;

        dbContext.Customers.Remove(costumer);
        var res = await dbContext.SaveChangesAsync();
        return res > 0;
        
    }

    public async Task<IList<Customer>> GetAllAsync()
    {
        return  dbContext.Customers.ToList();
    }

    public async Task<Customer?> GetByIdAsync(long id)
    {
       return await dbContext.Customers.FirstOrDefaultAsync(x=> x.Id==id);
        
    }

    public  async Task<int> UpdateAsync(long id, Customer repo)
    {
        dbContext.Customers.Update(repo);
        return await dbContext.SaveChangesAsync();
    }
}
