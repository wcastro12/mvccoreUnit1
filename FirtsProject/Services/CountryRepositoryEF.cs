using FirtsProject.Data;
using FirtsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirtsProject.Services
{
    public class CountryRepositoryEF : IrepositoryCountries
    {
        ApplicationDbContext Context;
        public CountryRepositoryEF(ApplicationDbContext Context)
        {
            this.Context = Context;
        }
        public List<Country> GetCounties()
        {
           return this.Context.Countries.ToList();
        }
    }
}
