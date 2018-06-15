using System.Collections.Generic;
using System.Threading.Tasks;
using RPAPI.Models;

namespace RPAPI.Data
{
    public interface IRPRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
    }
}