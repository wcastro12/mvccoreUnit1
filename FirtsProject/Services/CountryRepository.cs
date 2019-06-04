using FirtsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirtsProject.Services
{
    public class CountryRepository: IrepositoryCountries
    {
        public List<Country> GetCounties()
        {
            List<Country> ListCountries= new List<Country>() ;
            ListCountries.Add(new Country() { Name = "Colombia" });
            ListCountries.Add(new Country() { Name = "Mexico" });
            ListCountries.Add(new Country() { Name = "Panama" });

            return ListCountries;
        }
    }
}
