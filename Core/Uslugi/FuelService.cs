using Core.Repozytoria;
using Core.Uslugi.Interfejsy;
using Domena.Models;


namespace Core.Uslugi
{
    public class FuelService : BaseService<Fuel>, IFuelService
    {
        public FuelService() : base(new FuelRepository())
        {

        }

        public Fuel Create(Fuel row)
        {
            return base.Repository.Create(row);
        }
        public bool Delete(int id)
        {
            return base.Repository.Delete(id);
        }

        public Fuel[] GetArray()
        {
            return base.Repository.GetArray();
        }

        public Fuel GetSingle(int id)
        {
            return base.Repository.GetSingle(id);
        }

        public Fuel Update(Fuel row)
        {
            return base.Repository.Update(row);
        }
    }
}
