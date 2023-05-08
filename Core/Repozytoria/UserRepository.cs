using Domena;
using Domena.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


namespace Core.Repozytoria
{
    public class UserRepository : BaseRepo<User>
    {
        public override User Create(User row)
        {
            using (FleetDb db = new FleetDb())
            {
                if (!db.Users.Any(x => x.Id == row.Id))
                {
                    var result = db.Users.Add(row);
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
                var result = db.Users.Find(id);
                if (result != null)
                {
                    db.Users.Remove(result);
                    db.SaveChanges();
                    toReturn = true;
                }
            }
            return toReturn;
        }

        public override User[] GetArray()
        {
            using (FleetDb db = new FleetDb())
            {
                if (db.Users.Any())
                {
                    return db.Users.ToArray();
                }

                return new User[] { };
            }
        }

        public override User GetSingle(int id)
        {
            User manager = null;
            using (FleetDb db = new FleetDb())
            {
                if (db.Users.Any(x => x.Id == id))
                {
                    var result = db.Users
                                    .Where(x => x.Id == id)
                                    .Include(x => x.UserType)
                                    //.Include(x => x.License)
                                    .First();
                    manager = result;
                }
            }
            return manager;
        }

        public override User Update(User row)
        {
            if (row.Id == null)
            {
                throw new Exception("row has no Id");
            }

            User toReturn = null;

            using (FleetDb db = new FleetDb())
            {
                if (db.Users.Any(x => x.Id == row.Id))
                {
                    try
                    {
                        var result = db.Users.Update(row);
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
