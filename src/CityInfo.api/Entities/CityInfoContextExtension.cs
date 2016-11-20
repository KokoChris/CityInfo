using System.Collections.Generic;
using System.Linq;

namespace CityInfo.api.Entities
{
    public static class CityInfoContextExtension
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {

            if (context.Cities.Any())
            {
                return;
            }

            var cities = new List<City>()
             {
                 new City()
                    {
                      
                        Name = "New York City",
                        Description = "The one with that big park",
                        PointsOfInterest = new List<PointOfInterest>()
                        {
                            new PointOfInterest()
                            {
                              
                                Name = "Central Park",
                                Description = "The most visited urban park in the United States"

                            },
                            new PointOfInterest()
                            {
                               
                                Name = "Empire State Building",
                                Description = "A 102 story scyscraper"

                            }

                        }
                    }
          };
            context.Cities.AddRange(cities);
            context.SaveChanges();
        }
    }
}
