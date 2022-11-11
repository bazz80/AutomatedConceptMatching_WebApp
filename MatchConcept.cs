using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T46_AngularTest
{
    public class MatchConcept
    {
        public string Match_Plcs_Name { get; set; }
        public string Match_Mimosa_Name { get; set; }
        public double Match_Weight_Sim { get; set; }
        public int Match_Name_Sim { get; set; }
        public int Match_Rel_Sim { get; set; }
        public int Match_Desc_Sim { get; set; }
        public string Match_Plcs_Desc { get; set; }
        public string Match_Mimosa_Desc { get; set; }
        public string Match_Plcs_Rel { get; set; }
        public string Match_Mimosa_Rel { get; set; }

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
