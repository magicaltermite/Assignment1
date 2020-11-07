using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Assignment1.Data
{
    public interface IAdultService
    {
        Task<IList<Adult>> GetAdultAsync();
        Task AddAdultAsync(Adult adult);
        Task RemoveAdultAsync(int adultId);
        Task UpdateAdultAsync(Adult adult);
    }
}