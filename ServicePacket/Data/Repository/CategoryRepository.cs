using Microsoft.EntityFrameworkCore;
using ServicePacket.Data.Interface;
using ServicePacket.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServicePacket.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }
        public IEnumerable<Category> FindWithParent(Func<Category, bool> predicate)
        {
            return _context.Categories.Include(c => c.Parent).Where(predicate);
        }

        public IEnumerable<Category> GetAllWithServices()
        {
            return _context.Categories.Include(s =>s.Services);
        }

        public Category GetWithServices(int id)
        {
            return _context.Categories
                .Where(c => c.CategoryID == id)
                .Include(c => c.Services)
                .FirstOrDefault();
        }
    }
}
