using Domena;
using Domena.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repozytoria
{
    public class VehicleRepository : BaseRepo<Vehicle>
    {
        public override Vehicle Create(Vehicle row)
        {
            using (FleetDb db = new FleetDb())
            {
                if (!db.Vehicles.Any(x => x.Id == row.Id))
                {
                    var result = db.Vehicles.Add(row);
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
                var result = db.Vehicles.Find(id);
                if (result != null)
                {
                    db.Vehicles.Remove(result);
                    db.SaveChanges();
                    toReturn = true;
                }
            }
            return toReturn;
        }

        public override Vehicle[] GetArray()
        {
            using (FleetDb db = new FleetDb())
            {
                if (db.Vehicles.Any())
                {
                    return db.Vehicles.ToArray();
                }

                return new Vehicle[] { };
            }
        }

        public override Vehicle GetSingle(int id)
        {
            Vehicle vehicle = null;
            using (FleetDb db = new FleetDb())
            {
                if (db.Vehicles.Any(x => x.Id == id))
                {
                    var result = db.Vehicles
                                    .Where(x => x.Id == id)
                                    .First();
                    vehicle = result;
                }
            }
            return vehicle;
        }

        public override Vehicle Update(Vehicle row)
        {
            if (row.Id == null)
            {
                throw new Exception("row has no Id");
            }

            Vehicle toReturn = null;

            using (FleetDb db = new FleetDb())
            {
                if (db.Vehicles.Any(x => x.Id == row.Id))
                {
                    try
                    {
                        var result = db.Vehicles.Update(row);
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


    public class DriversVehiclesReferenceRepository : BaseRepoM2M<DriverVehicleAssingment>
    {
        public override DriverVehicleAssingment Create(DriverVehicleAssingment row)
        {
            using (FleetDb db = new FleetDb())
            {
                if (!db.DriverVehicleAssingments.Any(x => x.Equals(row)))
                {
                    var result = db.DriverVehicleAssingments.Add(row);
                    db.SaveChanges();

                    return result.Entity;
                }
            }

            return null;
        }

        public override bool Delete(DriverVehicleAssingment row)
        {
            using (FleetDb db = new FleetDb())
            {
                if (db.DriverVehicleAssingments.Any(x => x.Equals(row)))
                {
                    var foundRecords = db.DriverVehicleAssingments.Where(x => x.Equals(row));
                    db.DriverVehicleAssingments.RemoveRange(foundRecords);
                    db.SaveChanges();

                    return true;
                }
            }
            return false;
        }

        public override DriverVehicleAssingment[] GetArray()
        {
            using (FleetDb db = new FleetDb())
            {
                if (!db.DriverVehicleAssingments.Any())
                {
                    return new DriverVehicleAssingment[] { };
                }

                return db.DriverVehicleAssingments.ToArray();
            }
        }

        public override DriverVehicleAssingment Update(DriverVehicleAssingment row)
        {
            return null;
        }
    }
}
