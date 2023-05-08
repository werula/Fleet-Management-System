using Domena;
using Domena.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
namespace Core.Repozytoria
{
    public class FuelRepository : BaseRepo<Fuel>
    {

        public override Fuel Create(Fuel row)
        {
            using (FleetDb db = new FleetDb())
            {
                if (!db.Fuel.Any(x => x.Id == row.Id))
                {
                    var result = db.Fuel.Add(row);
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
                var result = db.Fuel.Find(id);
                if (result != null)
                {
                    db.Fuel.Remove(result);
                    db.SaveChanges();
                    toReturn = true;
                }
            }
            return toReturn;
        }

        public override Fuel[] GetArray()
        {
            using (FleetDb db = new FleetDb())
            {
                if (db.Fuel.Any())
                {
                    return db.Fuel.ToArray();
                }

                return new Fuel[] { };
            }
        }

        public override Fuel GetSingle(int id)
        {
            Fuel fuel = null;
            using (FleetDb db = new FleetDb())
            {
                if (db.Fuel.Any(x => x.Id == id))
                {
                    var result = db.Fuel
                                    .Where(x => x.Id == id)
                                    //.Include(x => x.UserType)
                                    //.Include(x => x.License)
                                    .First(); 
                    fuel = result;
                }
            }
            return fuel;
        }

        public override Fuel Update(Fuel row)
        {
            if (row.Id == null)
            {
                throw new Exception("row has no Id");
            }

            Fuel toReturn = null;

            using (FleetDb db = new FleetDb())
            {
                if (db.Fuel.Any(x => x.Id == row.Id))
                {
                    try
                    {
                        var result = db.Fuel.Update(row);
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
}
