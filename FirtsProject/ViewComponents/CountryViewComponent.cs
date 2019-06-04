using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirtsProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirtsProject.ViewComponents
{
    public class CountryViewComponent:ViewComponent
    {
        public IrepositoryCountries RepositoryCountry { get;  }

        public CountryViewComponent(IrepositoryCountries contries) {
            this.RepositoryCountry = contries;
        }



        public IViewComponentResult Invoke()
        {
            var countries = this.RepositoryCountry.GetCounties();
            return View(countries);
        }

    }
}
