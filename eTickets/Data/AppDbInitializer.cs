using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "cinema1.jpg",
                            Description = "Description 1"
                        },
                         new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "cinema2.jpg",
                            Description = "Description 2"
                        },
                          new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "cinema3.jpg",
                            Description = "Description 3"
                        },
                           new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "cinema4.jpg",
                            Description = "Description 4"
                        },
                            new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "cinema5.jpg",
                            Description = "Description 5"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                    new Actor()
                    {
                        FullName = "Actor 1",
                        Bio = "Bio 1",
                        ProfilePictureURL = "actor1.jpg"
                    },
                    new Actor()
                    {
                        FullName = "Actor 2",
                        Bio = "Bio 2",
                        ProfilePictureURL = "actor2.jpg"
                    },
                    new Actor()
                    {
                        FullName = "Actor 3",
                        Bio = "Bio 3",
                        ProfilePictureURL = "actor3.jpg"
                    },
                    new Actor()
                    {
                        FullName = "Actor 4",
                        Bio = "Bio 4",
                        ProfilePictureURL = "actor44.jpg"
                    },
                    new Actor()
                    {
                        FullName = "Actor 5",
                        Bio = "Bio 5",
                        ProfilePictureURL = "actor5.jpg"
                    }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                    new Producer()
                    {
                        FullName = "Producer 1",
                        Bio = "Bio 1",
                        ProfilePictureURL = "producer1.jpg"
                    },
                    new Producer()
                    {
                        FullName = "Producer 2",
                        Bio = "Bio 2",
                        ProfilePictureURL = "producer2.jpg"
                    },
                    new Producer()
                    {
                        FullName = "Producer 3",
                        Bio = "Bio 3",
                        ProfilePictureURL = "producer3.jpg"
                    },
                     new Producer()
                    {
                        FullName = "Producer 4",
                        Bio = "Bio 4",
                        ProfilePictureURL = "producer4.jpg"
                    },
                      new Producer()
                    {
                        FullName = "Producer 5",
                        Bio = "Bio 5",
                        ProfilePictureURL = "producer5.jpg"
                    } });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Equals",
                            Description = "Description 1",
                            Price = 39.50,
                            ImageURL = "equals.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 16,
                            MovieCategory = MovieCategory.Action
                        },
                         new Movie()
                        {
                            Name = "Five Feet Apart",
                            Description = "Description2",
                            Price = 49.50,
                            ImageURL = "fivefeetapart.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 4,
                            ProducerId = 17,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Fast And Fuious",
                            Description = "Description3",
                            Price = 60.50,
                            ImageURL = "fastandfurious.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 5,
                            ProducerId = 18,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Maria",
                            Description = "Description4",
                            Price = 53.50,
                            ImageURL = "maria.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 19,
                            MovieCategory = MovieCategory.Crim
                        },
                        new Movie()
                        {
                            Name = "Airdrift",
                            Description = "Description5",
                            Price = 46.55,
                            ImageURL = "airdrift.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 2,
                            ProducerId = 20,
                            MovieCategory = MovieCategory.Drama
                        },
                });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 7

                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 8
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 9
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 7
                        },
                         new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 7
                        },
                          new Actor_Movie()
                          {
                            ActorId = 3,
                            MovieId = 10
                          },
                           new Actor_Movie()
                           {
                            ActorId = 4,
                            MovieId = 6
                           }

                    });
                    context.SaveChanges();

                }

            }
        }
    }
}


