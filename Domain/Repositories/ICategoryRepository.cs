using System.Collections.Generic;
using System.Threading.Tasks;
using Sum.API.Domain.Models;


namespace Sum.API.Domain.Repositories
{
    public interface ICategoryRepository 
    {
        Task<IEnumerable<Category>> ListAsync();
        Task AddAsync(Category category);
        Task<Category> FindByIdAsync(int id);
        void Update(Category category);
    }
}