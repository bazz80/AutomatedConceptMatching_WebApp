using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T46_AngularTest
{
    public class MimosaConcept
    {
        public long Mimosa_Id { get; set; }
        public string Mimosa_Name { get; set; }

        public string Mimosa_Desc{ get; set; }
        public string Mimosa_Rel { get; set; }

        internal MySqlDb Db { get; set; }

        public MimosaConcept()
        {
        }

        internal MimosaConcept(MySqlDb db)
        {
            Db = db;
        }
    }
}
