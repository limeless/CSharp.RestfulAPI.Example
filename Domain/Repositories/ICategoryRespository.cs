using System.Collections.Generic;
using System.Threading.Tasks;
using Sum.API.Domain.Models;


namespace Sum.API.Domain.Respositories
{
    public interface ICategoryRepositories
    {
        public interface ICategoryRepository
        {
            Task<IEnumerable<Category>> ListAsync();
        }
    }
}