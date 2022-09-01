using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class EntityRepository<T> : IRepository<T> where T : IUser
    {
        public EntityRepository()
        {

        }
        private List<T> _entities = new List<T>();
        public void Add(T entity)
        {
            _entities.Add(entity);
        }
        public void Remove(T entity)
        {
            _entities.Remove(entity);
        }
        public void Print()
        {
            foreach(var entity in _entities)
            {
                Console.WriteLine($"{entity.Id}, {entity.Name}");
            }
        }
        public List<T> Fetch() => _entities;
        public T Fetch(int id) => _entities.Where(e => e.Id == id).FirstOrDefault();
    }
}
