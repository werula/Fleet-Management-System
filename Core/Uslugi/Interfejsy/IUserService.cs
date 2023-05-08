using Domena.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Uslugi.Interfejsy
{

    public interface IUserService : IBaseService<User>
    {
        UserType[] GetUserTypes();
        UserType GetuserTypeByName(string name);
    }
}
