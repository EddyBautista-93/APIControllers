using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIControllers.Models;
using Microsoft.Extensions.Primitives;

namespace APIControllers.Controllers
{
    // used to serve http API responses 
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private IRepository respository;
        public ReservationController(IRepository repo) => respository = repo;
        
    }
}
