using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webasp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<RandomController> _logger;
        private char letter;

        public RandomController(ILogger<RandomController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int Get()

        {

            Random random = new Random();
            int shift = Convert.ToInt32(Math.Floor(25 * random));
            letter = Convert.ToChar(shift + 65);

            return letter;

        }


        [HttpPost]
        public double Post()

        {

            Random random = new Random();

            double flt = random.NextDouble();

            letter = Convert.ToChar(flt + 65);

            return letter;

        }
        [HttpPut]
        public double Put()

        {
            Response.ContentType = "application/json";
            return "{ 'message' : 'Thank you for the new number!'}";

        }

        [HttpDelete]
        public int Delete()

        {

            Random random = new Random();


            return random;

        }
        [HttpPatch]
        public int Patch()

        {

            DateTime localDate = DateTime.Now;

            return localDate;

        }

    }

}
