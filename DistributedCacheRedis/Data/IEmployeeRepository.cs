using System.Collections.Generic;
using System.Threading.Tasks;

namespace DistributedCacheRedis.Data
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}