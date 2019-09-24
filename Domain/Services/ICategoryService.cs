using System.Collections.Generic;
using System.Threading.Tasks;
using Sum.API.Domain.Models;
using Sum.API.Domain.Services.Communication;

namespace Sum.API.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<SaveCategoryResponse> SaveAsync(Category category);
        Task<SaveCategoryResponse> UpdateAsync(int id, Category category);
    }
}
