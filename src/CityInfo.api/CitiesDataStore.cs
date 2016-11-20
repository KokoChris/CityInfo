using CityInfo.api.controllers;
using CityInfo.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityInfo.api
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
              new CityDto()
            {
                Id = 1,
                Name = "New York City",
                Description = "The one with that big park",
                PointsOfInterest = new List<PointOfInterest>()
                {
                    new Models.PointOfInterest
                    {
                        Id = 1,
                        Name = "Central Park",
                        Description = "The most visited urban park in the United States"
            
                    },
                    new Models.PointOfInterest
                    {
                        Id = 2,
                        Name = "Empire State Building",
                        Description = "A 102 story scyscraper"

                    },

                }
            },
             new CityDto()
             {
                 Id = 2,
                 Name = "Athens",
                 Description = "The one with acropoles"
             },
            new CityDto()
            {
                Id = 3,
                Name = "Paris",
                Description = "The one with the tower"
            }

        };

        }
    }
    
}
