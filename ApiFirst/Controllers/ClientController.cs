using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFirst.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientCotroller : ControllerBase
    {
       
        private static readonly string[] Name_client = new[]
        {
            "Nuno", "Marta", "Filipa", "Catarina", "Helena", "Patricia", "Raquel"

        };

        private static readonly int[] Age = new[]
        {
            31,18,22,33,30,27,15
        };  

        [HttpGet]
        public IEnumerable<ClientModel> Get()
        {
            var rng = new Random();
            return Enumerable.Range(0, 6).Select(index => new ClientModel
            {
                Date = DateTime.Now.AddDays(index),
                Summary = Name_client[rng.Next(Name_client.Length)],
                Age = Age[rng.Next(Age.Length)]
            })
            .ToArray();
        }
    }
}
