using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace WebApliCountries.Models
{
    [DataContract]
    public class Country
    {
        [DataMember]
        [Key]
        public int CountryID { get; set; }


        [DataMember]
        public String Name { get; set; }
    }
}
