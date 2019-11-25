using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyTutorial.Models;

namespace VidlyTutorial.ViewModels
{
    public class RandomMovieViewModel
    {

        public Movie movie { get; set; }

        public List<Customer> customer { get; set; }
    }
}