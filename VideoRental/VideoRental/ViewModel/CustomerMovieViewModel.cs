using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoRental.Models;

namespace VideoRental.ViewModel
{
    public class CustomerMovieViewModel
    {
        public List<Customers> Customers { get; set; }
        public Movie MovieDetails { get; set; }
    }
}