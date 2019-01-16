using ServicePacket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicePacket.Data.Interface
{
    public interface IServiceRepository: IRepository<Service>
    {
        IEnumerable<Service> GetAllWithCategory();
        IEnumerable<Service> FindWithCategory(Func<Service, bool> predicate);
    }
}
