using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using MySqlConnector;

namespace T46_AngularTest.Controllers
{
    //[Route("[controller]")]
    public class MatchController : Controller
    {
        internal MySqlDb Db { get; }

        public MatchController(MySqlDb db)
        {
            Db = db;
        }

        // Get Matching concepts
        [HttpGet]
        [Route("Match/GetMatches/{concept?}")]
        public async Task<IActionResult> GetMatches(string concept)
        {
            await Db.Connection.OpenAsync();
            var query = new MatchConceptQuery(Db);
            var result = await query.FindMatch(concept);
            if (result is null)
                return new NotFoundResult();
            return new OkObjectResult(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            await Db.Connection.OpenAsync();
            var query = new MatchConceptQuery(Db);
            var result = await query.ListAll();
            return new OkObjectResult(result);
        }
    }
    
}
