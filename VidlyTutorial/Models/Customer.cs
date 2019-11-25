using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyTutorial.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string name { get; set; }
    }

    public class RandomMovieViewModel
    {

        public Movie movie { get; set; }

        public List<Customer> customer { get; set; }
    }
}