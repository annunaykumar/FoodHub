using eFoodHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eFoodHub.WebUI.Interfaces
{
    public interface IUserAccessor
    {
        User GetUser();
    }
}
