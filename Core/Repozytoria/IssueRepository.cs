using Domena;
using Domena.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Core.Repozytoria
{
    public class IssueRepository : BaseRepo<Issue>
    {
        public override Issue Create(Issue row)
        {
            using (FleetDb db = new FleetDb())
            {
                if (!db.Issues.Any(x => x.Id == row.Id))
                {
                    var result = db.Issues.Add(row);
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
                var result = db.Issues.Find(id);
                if (result != null)
                {
                    db.Issues.Remove(result);
                    db.SaveChanges();
                    toReturn = true;
                }
            }
            return toReturn;
        }

        public override Issue[] GetArray()
        {
            using (FleetDb db = new FleetDb())
            {
                if (db.Issues.Any())
                {
                    return db.Issues.ToArray();
                }

                return new Issue[] { };
            }
        }

        public override Issue GetSingle(int id)
        {
            Issue issues = null;
            using (FleetDb db = new FleetDb())
            {
                if (db.Issues.Any(x => x.Id == id))
                {
                    var result = db.Issues
                                    .Where(x => x.Id == id)
                                    //.Include(x => x.UserType)
                                    //.Include(x => x.License)
                                    .First();
                    issues = result;
                }
            }
            return issues;
        }

        public override Issue Update(Issue row)
        {
            if (row.Id == null)
            {
                throw new Exception("row has no Id");
            }

            Issue toReturn = null;

            using (FleetDb db = new FleetDb())
            {
                if (db.Issues.Any(x => x.Id == row.Id))
                {
                    try
                    {
                        var result = db.Issues.Update(row);
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
