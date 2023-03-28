using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShop.Core.Repositories
{
    public interface IRepository<T>
    {
        public void Create(T model);
        public void Delete(T  model);
        public T Get(Func<T, bool> expression);
        public List<T> GetAll(Func<T, bool> expression);
        public List<T> GetAll();
        public void Update(T model);

        // public void GetIndex();
        
    }
}
