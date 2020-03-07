using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Videe.Dtos;
using Videe.Models;

namespace Videe.Controllers.API
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            // if (!ModelState.IsValid)
            //     return BadRequest();

            // return Created(new Uri(Request.RequestUri + "/" + newRental.Id), newRental);
            throw new NotImplementedException();
        }
    }
}
