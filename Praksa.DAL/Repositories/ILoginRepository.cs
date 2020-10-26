using System;
using System.Collections.Generic;
using System.Text;

namespace Praksa.Repositories.Repositories
{
    interface ILoginRepository
    {
        bool Login(string username, string password);
    }
}
