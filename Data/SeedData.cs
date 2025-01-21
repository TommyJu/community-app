using System;
using System.Collections.Generic;
using CommunityApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp.Data;

public static class SeedData {
    // This is an extension method to the ModelBuilder class (ApplicationDbContext)
    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
        );
        modelBuilder.Entity<City>().HasData(
            GetCities()
        );
    }

    public static List<Province> GetProvinces() {
        List<Province> provinces = new List<Province>() {
            new Province() {    // 1
                ProvinceCode = "BC",
                ProvinceName = "British Columbia",
            },
            new Province() {    // 2
                ProvinceCode = "ON",
                ProvinceName = "Ontario",
            },
            new Province() {    // 3
                ProvinceCode = "AB",
                ProvinceName = "Alberta",
            }
        };

        return provinces;
    }

    public static List<City> GetCities() {
        List<City> cities = new List<City>() {
            new City { 
                CityId = 1, 
                CityName = "Vancouver", 
                Population = 3000000, 
                ProvinceCode = "BC" 
            },
            new City { 
                CityId = 2, 
                CityName = "Victoria", 
                Population = 850000, 
                ProvinceCode = "BC" 
            },
            new City { 
                CityId = 3, 
                CityName = "Surrey", 
                Population = 500000, 
                ProvinceCode = "BC" 
            },
            new City { 
                CityId = 4, 
                CityName = "Toronto", 
                Population = 2800000, 
                ProvinceCode = "ON" 
            },
            new City { 
                CityId = 5, 
                CityName = "Ottawa", 
                Population = 1000000, 
                ProvinceCode = "ON" 
            },
            new City { 
                CityId = 6, 
                CityName = "Mississauga", 
                Population = 700000, 
                ProvinceCode = "ON" 
            },
            new City { 
                CityId = 7, 
                CityName = "Calgary", 
                Population = 1200000, 
                ProvinceCode = "AB" 
            },
            new City { 
                CityId = 8, 
                CityName = "Edmonton", 
                Population = 1300000, 
                ProvinceCode = "AB" 
            },
            new City { 
                CityId = 9, 
                CityName = "Banff", 
                Population = 10000, 
                ProvinceCode = "AB" 
            }
        };

        return cities;
    }
}
