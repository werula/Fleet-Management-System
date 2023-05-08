using Domena;
using Domena.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


namespace Core.Repozytoria
{
    public class DriverRepository : BaseRepo<Driver>
    {
        public override Driver Create(Driver row)
        {
            using (FleetDb db = new FleetDb())
            {
                if (!db.Drivers.Any(x => x.Id == row.Id))
                {
                    var result = db.Drivers.Add(row);
                    db.SaveChanges();

                    return result.Entity;
                }
            }

            return null;
        }

        public override bool Delete(int id)
        {
            bool toReturn = false;
            using (FleetDb db = new FleetDb())
            {
                var result = db.Drivers.Find(id);
                if(result != null)
                {
                    db.Drivers.Remove(result);
                    db.SaveChanges();
                    toReturn = true;
                }
            }
            return toReturn;
        }

        public override Driver[] GetArray()
        {
            using (FleetDb db = new FleetDb())
            {
                if (db.Drivers.Any())
                {
                    return db.Drivers.Include(x => x.License).ToArray();
                }

                return new Driver[] { };
            }
        }

        public override Driver GetSingle(int id)
        {
            Driver driver = null;
            using (FleetDb db = new FleetDb())
            {
                if (db.Drivers.Any(x => x.Id == id))
                {
                    var result = db.Drivers
                                    .Where(x => x.Id == id)
                                    .Include(x => x.License)
                                    .First();
                    driver = result;
                }
            }
            return driver;
        }

        public override Driver Update(Driver row)
        {
            if(row.Id == null)
            {
                throw new Exception("row has no Id");
            }

            Driver toReturn = null;

            using (FleetDb db = new FleetDb())
            {
                if (db.Drivers.Any(x => x.Id == row.Id))
                {
                    try
                    {
                        var result = db.Drivers.Update(row);
                        db.SaveChanges();
                        toReturn = result.Entity;
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine($"Error: {e.Message}");
                    }
                }
            }

            return toReturn;

        }


    }



    /*
    // dodawanie, usuwanie, edytowanie aut
    public interface IVehicleManagementable : CRUD<Vehicle>
    {
        public void Add();
        public void Remove();
        public void Edit();
    }

    // sprawdzanie pozycji auta, najbliższej stacji, korków na drodze
    public interface IGPSable
    {
        public void Tracking();
        public void Position();
        public void GasStation();
        public void TrafficJam();

    }

    // tworzenie, usuwanie, aktualizowanie, sprawdzanie informacji o rezerwacji auta
    public interface IBookingable
    {
        public void Create();
        public void Update();
        public void Delete();
        public void ShowBooking();

    }


    // koszta podatku, koszcie częściowym i całościowym
    public interface IFeesable
    {
        public void Tax();
        public void SubTotal();
        public void Total();
        public void Fuel();
    }
    */
}
