using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidlyyyy.Models
{
    public class Rental
    {
        public Rental(Customer customer, Movie movie)
        {
            Customer = customer;
            Movie = movie;
            Movie.NumberAvailable--;
            DateRented = DateTime.Now;
        }

        public int Id { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public Movie Movie { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime? DateReturned { get; set; }
    }
}