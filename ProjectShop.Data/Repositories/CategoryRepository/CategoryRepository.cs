using ProjectShop.Core.Repositories.CategoryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShop.Data.Repositories.CategoryRepository
{
    public class CategoryRepository:Repository<Category>, ICategoryRepository
    {
    }
}
