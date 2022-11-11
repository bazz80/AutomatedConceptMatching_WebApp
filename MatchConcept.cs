using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T46_AngularTest
{
    public class MatchConcept
    {
        //public int Match_Id { get; set; }
        public string Match_Plcs_Name { get; set; }
        public string Match_Mimosa_Name { get; set; }
        public int Match_Name_Sim { get; set; }
        public int Match_Desc_Sim { get; set; }

        internal MySqlDb Db { get; set; }

        public MatchConcept()
        {
        }

        internal MatchConcept(MySqlDb db) 
        {
            Db = db;
        }
    }
}
