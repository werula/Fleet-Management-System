using Core.Repozytoria;
using Core.Uslugi.Interfejsy;
using Domena.Models;

namespace Core.Uslugi
{
    public class TiresService : BaseService<Tire>, ITiresService
    {
        public TiresService() : base(new TiresRepository())
        {

        }

        public Tire Create(Tire row)
        {
            return base.Repository.Create(row);
        }
        public bool Delete(int id)
        {
            return base.Repository.Delete(id);
        }

        public Tire[] GetArray()
        {
            return base.Repository.GetArray();
        }

        public Tire GetSingle(int id)
        {
            return base.Repository.GetSingle(id);
        }

        public Tire Update(Tire row)
        {
            return base.Repository.Update(row);
        }
    }
}
