using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public interface IRepository<T>
    {
        public void Add(T entity);
        public void Remove(T entity);
        public void Print();
        public List<T> Fetch();
        public T Fetch(int id);
    }
}
