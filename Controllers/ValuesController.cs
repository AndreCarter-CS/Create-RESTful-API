using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> Get()
        {
            var movies = new List<Movie> {
                new Movie {
                    Id = 1,
                    Title = "Aladdin",
                    Genre = "Action",
                    Year = 1992
                },
                new Movie {
                    Id = 2,
                    Title = "Avengers",
                    Genre = "Superhero",
                    Year = 2012
                },
                new Movie {
                    Id = 3,
                    Title = "Spiderman",
                    Genre = "Superhero",
                    Year = 2002
                }
            };

            return movies;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Movie> Get(int id)
        {
            var movies = new List<Movie> {
                new Movie {
                    Id = 1,
                    Title = "Aladdin",
                    Genre = "Action",
                    Year = 1992
                },
                new Movie {
                    Id = 2,
                    Title = "Avengers",
                    Genre = "Superhero",
                    Year = 2012
                },
                new Movie {
                    Id = 3,
                    Title = "Spiderman",
                    Genre = "Superhero",
                    Year = 2002
                }
            };

            return movies.Find(m => m.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Movie movie)
        {
            var movies = new List<Movie> {
                new Movie {
                    Id = 1,
                    Title = "Aladdin",
                    Genre = "Action",
                    Year = 1992
                },
                new Movie {
                    Id = 2,
                    Title = "Avengers",
                    Genre = "Superhero",
                    Year = 2012
                },
                new Movie {
                    Id = 3,
                    Title = "Spiderman",
                    Genre = "Superhero",
                    Year = 2002
                }
            };

            movies.Add(movie);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Movie newMovie)
        {
            var movies = new List<Movie> {
                new Movie {
                    Id = 1,
                    Title = "Aladdin",
                    Genre = "Action",
                    Year = 1992
                },
                new Movie {
                    Id = 2,
                    Title = "Avengers",
                    Genre = "Superhero",
                    Year = 2012
                },
                new Movie {
                    Id = 3,
                    Title = "Spiderman",
                    Genre = "Superhero",
                    Year = 2002
                }
            };

            var movie = movies.Find(m => m.Id == id);

            if (movie != null)
            {
                movie.Title = newMovie.Title;
                movie.Genre = newMovie.Genre;
                movie.Year = newMovie.Year;
            }

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var movies = new List<Movie> {
                new Movie {
                    Id = 1,
                    Title = "Aladdin",
                    Genre = "Action",
                    Year = 1992
                },
                new Movie {
                    Id = 2,
                    Title = "Avengers",
                    Genre = "Superhero",
                    Year = 2012
                },
                new Movie {
                    Id = 3,
                    Title = "Spiderman",
                    Genre = "Superhero",
                    Year = 2002
                }
            };

            var movie = movies.Find(m => m.Id == id);

            if (movie != null)
            {
                movies.Remove(movie);
            }
        }
    }
}
