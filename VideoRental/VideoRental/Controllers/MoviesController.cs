using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRental.Models;
using VideoRental.ViewModel;

namespace VideoRental.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            Movie movie = new Movie { Name = "ZODIAC" };
            List<Customers> customers = new List<Customers>
            {
                new Customers{ Name="Nikhil" },
                new Customers{ Name="Libin" }
            };
            var viewModel = new CustomerMovieViewModel();
            viewModel.Customers = customers;
            viewModel.MovieDetails = movie;
            return View(viewModel);
        }
        //public ActionResult RandomMovie()
        //{
        //    Movie movie = new Movie();
        //    movie.Name = "Zodiac";
        //    return View(movie);
        //}
        //public ActionResult Edit(int? id)
        //{
        ////    if(!id.HasValue)
        ////    {
        ////        id = 1;
        ////    }
        //    return Content("ID=" + (id ?? 10).ToString());
        //    //return Content("ID=" + id);
        //}
        //public ActionResult ReleaseDate(int month,int year)
        //{
        //    return Content($"Month={month} <br/> Year={year}");
        //}
    }
}