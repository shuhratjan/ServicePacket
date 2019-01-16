using ServicePacket.Models;
using System;
using System.Collections.Generic;
namespace ServicePacket.Data.Interface
{
    public interface ICategoryRepository: IRepository<Category>
    {
        IEnumerable<Category> FindWithParent(Func<Category, bool> predicate);
        IEnumerable<Category> GetAllWithServices();
        
        Category GetWithServices(int id);
    }
}
