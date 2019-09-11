﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                    .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A Boat for one person",
                        Category = "WaterSports",
                        Price = 275
                    },
                     new Product
                     {
                         Name = "Lifejacket",
                         Description = "Protective and fashionable",
                         Category = "WaterSports",
                         Price = 48.95m
                     },
                      new Product
                      {
                          Name = "Soccer Ball",
                          Description = "FIFA Approved size and weight",
                          Category = "Soccer",
                          Price = 19.50m
                      },
                       new Product
                       {
                           Name = "Corder Flags",
                           Description = "Give your playing field a professional touch",
                           Category = "Soccer",
                           Price = 34.95m
                       },
                        new Product
                        {
                            Name = "Stadium",
                            Description = "Flat-Packed 35,000-seat staduim",
                            Category = "Soccer",
                            Price = 79500
                        },
                         new Product
                         {
                             Name = "Thinking Cap",
                             Description = "Improve Brain efficiency by 75%",
                             Category = "Chess",
                             Price = 16
                         },
                          new Product
                          {
                              Name = "Unsteady Chair",
                              Description = "Secretly Give your opponant a dissadvantage",
                              Category = "Chess",
                              Price = 275
                          },
                           new Product
                           {
                               Name = "Human Chess Board",
                               Description = "A fun game for the family",
                               Category = "Chess",
                               Price = 75
                           },
                            new Product
                            {
                                Name = "Bling-Bling King",
                                Description = "Gold-Plated, Diamond-Studded King",
                                Category = "Chess",
                                Price = 1200
                            });
                context.SaveChanges();


                    

                
            }
        }
    }
}
