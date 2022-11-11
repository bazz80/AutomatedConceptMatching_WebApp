using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T46_AngularTest.Controllers
{
    public class MimosaController : Controller
    {
        internal MySqlDb Db { get; }

        public MimosaController(MySqlDb db)
        {
            Db = db;
        }

        // List Mimosa concepts
        [HttpGet]
        public async Task<IActionResult> GetMimosa()
        {
            await Db.Connection.OpenAsync();
            var query = new MimosaConceptQuery(Db);
            var result = await query.ListMimosaAsync();
            return new OkObjectResult(result);
        }
    }
}
