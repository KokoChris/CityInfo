﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.api.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.api.Services
{
    public class CityInfoRepository : ICityInfoRepository
    {
        private readonly CityInfoContext _context;

        public CityInfoRepository(CityInfoContext context)
        {
            _context = context;
        }
        public IEnumerable<City> GetCities()
        {
            return _context.Cities.OrderBy(c => c.Name).ToList();
        }

        public City GetCity(int cityId, bool includePointsOfInterest)
        {
            if (includePointsOfInterest)
            {
                return _context.Cities.Include(c=> c.PointsOfInterest).FirstOrDefault(c => c.CityId == cityId);
            }
            return _context.Cities.FirstOrDefault(c => c.CityId == cityId);
        }

        public IEnumerable<PointOfInterest> GetPointsOfInterestForCity(int cityId)
        {
            throw new NotImplementedException();
        }

        public PointOfInterest GetPointOfInterestForCity(int cityId)
        {
            throw new NotImplementedException();
        }
    }
}
