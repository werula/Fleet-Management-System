using Domena;
using Domena.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


namespace Core.Repozytoria
{
    public class TiresRepository : BaseRepo<Tire>
    {
        public override Tire Create(Tire row)
        {
            using (FleetDb db = new FleetDb())
            {
                if (!db.Tires.Any(x => x.Id == row.Id))
                {
                    var result = db.Tires.Add(row);
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
                var result = db.Tires.Find(id);
                if (result != null)
                {
                    db.Tires.Remove(result);
                    db.SaveChanges();
                    toReturn = true;
                }
            }
            return toReturn;
        }

        public override Tire[] GetArray()
        {
            using (FleetDb db = new FleetDb())
            {
                if (db.Tires.Any())
                {
                    return db.Tires.ToArray();
                }

                return new Tire[] { };
            }
        }

        public override Tire GetSingle(int id)
        {
            Tire tires = null;
            using (FleetDb db = new FleetDb())
            {
                if (db.Tires.Any(x => x.Id == id))
                {
                    var result = db.Tires
                                    .Where(x => x.Id == id)
                                    //.Include(x => x.UserType)
                                    //.Include(x => x.License)
                                    .First();
                    tires = result;
                }
            }
            return tires;
        }

        public override Tire Update(Tire row)
        {
            if (row.Id == null)
            {
                throw new Exception("row has no Id");
            }

            Tire toReturn = null;

            using (FleetDb db = new FleetDb())
            {
                if (db.Tires.Any(x => x.Id == row.Id))
                {
                    try
                    {
                        var result = db.Tires.Update(row);
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

