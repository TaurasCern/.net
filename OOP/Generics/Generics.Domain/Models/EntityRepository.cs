using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class EntityRepository<T> where T : IUser, new()
    {
        public EntityRepository()
        {

        }
        public List<T> Entities { get; set; }
        void Add(T entity)
        {
            Entities.Add(entity);
        }
        void Remove(T entity)
        {
            Entities.Remove(entity);
        }
        void Print()
        {
            foreach(var entity in Entities)
            {
                Console.WriteLine($"{entity.Id}, {entity.Name}");
            }
        }
        T Fetch(int index) => Entities[index];
    }
}
