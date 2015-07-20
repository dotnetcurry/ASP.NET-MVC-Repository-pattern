using System.Collections.Generic;

namespace MVC_Repository.Repositories
{
    //The Generic Interface Repository for Performing Read/Add/Delete operations
    public interface IRepository<TEnt, in TPk> where TEnt :class
    {
        IEnumerable<TEnt> Get();
        TEnt Get(TPk id);
        void Add(TEnt entity);
        void Remove(TEnt entity);
    }
}
