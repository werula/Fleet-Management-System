using Domena.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Uslugi.Interfejsy
{
    public interface IDriverService: IBaseService<Driver>
    {
        Driver AssignToVehicle(int vehicleId);

        Driver[] Search(string value);
    }

    public interface IVehicleService : IBaseService<Vehicle>
    {
    
    }

    public interface IBaseService<T>
    {
        T[] GetArray();
        T GetSingle(int id);
        bool Delete(int id);
        T Create(T row);
        T Update(T row);
    }


    public interface IM2MBaseService<T> where T : class
    {
        void AddReference(T row);

        T[] GetByFirstEntity(int id);

        T[] GetBySecondEntity(int id);

        void Delete(T row);

        void Update(T row);
    }
}
