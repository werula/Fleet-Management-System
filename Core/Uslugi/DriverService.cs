using Core.Repozytoria;
using Core.Uslugi.Interfejsy;
using Domena.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Uslugi
{

    public class DriverService : BaseService<Driver>, IDriverService
    {
        public DriverService():base(new DriverRepository())
        {
            
        }

        public Driver AssignToVehicle(int vehicleId)
        {
            throw new NotImplementedException();
        }

        public Driver Create(Driver row)
        {
            return base.Repository.Create(row);
        }

        public bool Delete(int id)
        {
            return base.Repository.Delete(id);
        }

        public Driver[] GetArray()
        {
            return base.Repository.GetArray();
        }

        public Driver GetSingle(int id)
        {
            return base.Repository.GetSingle(id);
        }

        public Driver[] Search(string value)
        {
            var all = base.Repository.GetArray();
            string uppered = value.ToUpper();
            if(all.Any(x => x.Name.ToUpper().Contains(uppered)  || x.Surname.ToUpper().Contains(uppered)))
            {
                var found = all.Where(x => x.Name.ToUpper().Contains(uppered) || x.Surname.ToUpper().Contains(uppered));

                return found.ToArray();
            }

            return new Driver[] { };
        }

        public Driver Update(Driver row)
        {
            return base.Repository.Update(row);
        }
    }
}
