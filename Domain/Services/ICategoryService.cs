using System.Collections.Generic;
using System.Threading.Tasks;
using Sum.API.Domain.Models;
using Sum.API.Domain.Repositories;
using Sum.API.Domain.Services;

namespace Sum.API.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
