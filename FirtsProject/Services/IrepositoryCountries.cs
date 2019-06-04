using FirtsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirtsProject.Services
{
     public interface IrepositoryCountries
    {
         List<Country> GetCounties();
    }
}
