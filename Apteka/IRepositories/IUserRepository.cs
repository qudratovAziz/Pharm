using Apteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apteka.IRepositories
{
    public interface IUserRepository
    {
        User Create(User user);
        User Login(string username, string password);

    }
}
