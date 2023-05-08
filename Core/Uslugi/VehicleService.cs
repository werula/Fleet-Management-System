using Core.Repozytoria;
using Core.Uslugi.Interfejsy;
using Domena.Models;

namespace Core.Uslugi
{
    public class VehicleService : BaseService<Vehicle>, IVehicleService
    {
        public VehicleService() : base(new VehicleRepository())
        {
        }

        public Vehicle Create(Vehicle row)
        {
            return base.Repository.Create(row);
        }
        public bool Delete(int id)
        {
            return base.Repository.Delete(id);
        }

        public Vehicle[] GetArray()
        {
            return base.Repository.GetArray();
        }

        public Vehicle GetSingle(int id)
        {
            return base.Repository.GetSingle(id);
        }

        public Vehicle Update(Vehicle row)
        {
            return base.Repository.Update(row);
        }
    }


    public class DriversVehiclesReferenceServices : BaseServiceM2M<DriverVehicleAssingment>, IM2MBaseService<DriverVehicleAssingment>
    {
        public DriversVehiclesReferenceServices():base(new DriversVehiclesReferenceRepository())
        {
            
        }

        public void AddReference(DriverVehicleAssingment row)
        {
            row.AssignTime = DateTime.Now.ToUniversalTime();

            base.Repository.Create(row);
        }

        public void Delete(DriverVehicleAssingment row)
        {
            // base.Repository.Delete(r);
        }

        public DriverVehicleAssingment[] GetByFirstEntity(int id)
        {
            var result =  base.Repository.GetArray();

            if(result.Any(x => x.DriverId == id))
            {
                var byFirst = result.Where(x => x.DriverId == id).ToArray();

                return byFirst;
            }
            return new DriverVehicleAssingment[] { };
        }

        public DriverVehicleAssingment[] GetBySecondEntity(int id)
        {
            var result = base.Repository.GetArray();

            if (result.Any(x => x.VehicleId == id))
            {
                var bySecond = result.Where(x => x.VehicleId == id).ToArray();

                return bySecond;
            }
            return new DriverVehicleAssingment[] { };
        }

        public void Update(DriverVehicleAssingment row)
        {
            base.Repository.Update(row);
        }
    }
}
