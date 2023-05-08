using Core.Repozytoria;
using Core.Uslugi.Interfejsy;
using Domena.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domena;

namespace Core.Uslugi
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(): base(new UserRepository())
        {
        }

        public User Create(User row)
        {
            return base.Repository.Create(row);
        }
        public bool Delete(int id)
        {
            return base.Repository.Delete(id);
        }

        public User[] GetArray()
        {
            return base.Repository.GetArray();
        }

        public User GetSingle(int id)
        {
            return base.Repository.GetSingle(id);
        }

        public UserType GetuserTypeByName(string name)
        {
            using (FleetDb db = new FleetDb())
            {
                if (!db.UserTypes.Any(x => x.Name.ToUpper() == name.ToUpper())) // UŻYTKOWNIK == UŻYTKOWNIK
                {
                    return null;
                }

                var userType = db.UserTypes.Where(x => x.Name.ToUpper() == name.ToUpper()).First();
                return userType;
            }
        }

        public UserType[] GetUserTypes()
        {
            using (FleetDb db = new FleetDb())
            {
                if (!db.UserTypes.Any())
                {
                    return new UserType[] { } ;
                }

                var usersTypes = db.UserTypes.ToArray();
                return usersTypes;
            }
        }

        public User Update(User row)
        {
            return base.Repository.Update(row);
        }
    }
}
