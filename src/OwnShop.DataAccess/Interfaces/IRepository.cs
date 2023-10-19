using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnShop.DataAccess.Interfaces
{
    public interface IRepository<TRepo , TViewModel>
    {
        public Task<int> CreateAsync(TRepo repo); 

        public Task<int> UpdateAsync(long id, TRepo repo);

        public Task<int> DeleteAsync(long id);

        public Task<TViewModel?> GetByIdAsync(long id);

        public Task<IList<TRepo>> GetAllAsync();

        public Task<int> CountAsync();
      
    }
}
