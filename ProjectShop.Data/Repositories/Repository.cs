using ProjectShop.Core.Models;
using ProjectShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShop.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseModel 
    {
        List<T> _list = new List<T>();
        public void Create(T model)
        {
            _list.Add(model);
        }

        public void Delete(T model)
        {
            _list.Remove(model);
        }

        public T Get(Func<T, bool> expression)
        {
            T model = _list.FirstOrDefault(expression);
            return model;
        }

        public List<T> GetAll(Func<T, bool> expression)
        {
            List<T> filteredlist = _list.Where(expression).ToList(); 
            return filteredlist;
        }

        public List<T> GetAll()
        {
            return _list;
        }

        // first strategy of update
        public void Update(T model)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (_list[i].Id == model.Id)
                {
                    _list[i] = model;
                }
            }
        }


        //second strategy of update

        //public void Update(T model)
        //{
        //    int index = GetIndex(model.Id);
        //    _list[index] = model;
        //}        
        //public int GetIndex(int id)
        //{
        //    T model = _list.FirstOrDefault(x=>x.Id == id);
        //    return _list.IndexOf(model);
        //}

    }
}
