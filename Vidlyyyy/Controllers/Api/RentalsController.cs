using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidlyyyy.DTOs;
using Vidlyyyy.Models;

namespace Vidlyyyy.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        //// GET /Rentals
        //public IHttpActionResult GetRentals()
        //{
        //    return Ok();
        //}

        //// GET /Rentals/1
        //public IHttpActionResult GetRental(int customerId)
        //{
        //    return Ok();
        //}

        // POST /Rentals/New
        [HttpPost]
        public IHttpActionResult CreateRental(RentalDto rentalDto)
        {
            bool allMoviesAvailable = true;

            var customer = _context.Customers.Single(c => c.Id == rentalDto.CustomerId);

            var movies = _context.Movies.Where(m => rentalDto.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable != 0)
                {
                    var rental = new Rental(customer, movie);

                    _context.Rentals.Add(rental);
                }
                else
                    allMoviesAvailable = false;
                
            }
            _context.SaveChanges();

            if(allMoviesAvailable)
                return Ok();    

            return BadRequest("One or more movies were not available");
        }
    }
}
