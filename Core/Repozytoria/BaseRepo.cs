using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Repozytoria
{
    public abstract class BaseRepo<TEntity> : CRUD<TEntity>
        where TEntity : class
    {
        public abstract TEntity Create(TEntity row);

        public abstract bool Delete(int id);

        public abstract TEntity[] GetArray();

        public abstract TEntity GetSingle(int id);

        public abstract TEntity Update(TEntity row);
    }


    public abstract class BaseRepoM2M<TEntity> where TEntity : class
    {
        public abstract TEntity Create(TEntity row);

        public abstract bool Delete(TEntity row);

        public abstract TEntity[] GetArray();

        public abstract TEntity Update(TEntity row);
    }



    // UI --> Core(Usługi -> Repozytorium) --> DB 

    // C - Create
    // R - Read
    // U - Update
    // D - Delete
    public interface CRUD<T> where T : class
    {
        T[] GetArray();
        T GetSingle(int id);
        bool Delete(int id);
        T Create(T row);
        T Update(T row);
    }
}
