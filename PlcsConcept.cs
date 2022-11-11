using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T46_AngularTest
{
    public class PlcsConcept
    {
        public long Plcs_Id { get; set; }
        public string Plcs_Name { get; set; }

        public string Plcs_Desc { get; set;  }
        public string Plcs_Rel { get; set; }



        internal MySqlDb Db { get; set; }

        public PlcsConcept()
        {
        }

        internal PlcsConcept(MySqlDb db)
        {
            Db = db;
        }
    }
}
