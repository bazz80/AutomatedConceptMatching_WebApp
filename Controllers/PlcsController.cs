using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T46_AngularTest.Controllers
{
    public class PlcsController : Controller
    {
        internal MySqlDb Db { get; }

        public PlcsController(MySqlDb db)
        {
            Db = db;
        }

        // List Plcs concepts
        [HttpGet]
        public async Task<IActionResult> GetPlcs()
        {
            await Db.Connection.OpenAsync();
            var query = new PlcsConceptQuery(Db);
            var result = await query.ListPlcsAsync();
            return new OkObjectResult(result);
        }

    }
}
