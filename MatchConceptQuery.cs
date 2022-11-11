using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using MySqlConnector;

namespace T46_AngularTest
{
    public class MatchConceptQuery
    {
       public MySqlDb Db { get; }

       public MatchConceptQuery(MySqlDb db)
        {
            Db = db;
        }

        //List all matching concepts from input variable 'concept'
        public async Task<List<MatchConcept>> FindMatch(string search)
        {
            using var cmd = Db.Connection.CreateCommand();

            string queryCmd = @"SELECT  name_plcs, name_mimosa, sim_name, sim_description FROM similarity WHERE name_plcs LIKE @concept OR name_mimosa LIKE @concept ORDER BY sim_name DESC";
            // id_sim,
            cmd.CommandText = queryCmd;

            string msearch = "%" + search + "%";

            cmd.Parameters.Add(new MySqlParameter
            {
               ParameterName = "@concept",
               DbType = DbType.AnsiString,
               Value = msearch,
            });

            return await ReadAsync(await cmd.ExecuteReaderAsync());
        
           
        }


        //List all Concepts in matches table
        public async Task<List<MatchConcept>> ListAll()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT name_plcs, name_mimosa, sim_name, sim_description FROM similarity ORDER BY sim_name DESC";
            return await ReadAsync(await cmd.ExecuteReaderAsync());
        }

        // id_sim, 

        private async Task<List<MatchConcept>> ReadAsync(DbDataReader reader)
        {
            var allMatchConcepts = new List<MatchConcept>();
            using (reader)
            {
                while (await reader.ReadAsync())
                {
                    var allMatchConcept = new MatchConcept(Db)
                    {
                        //Match_Id = reader.GetInt32(0),
                        Match_Plcs_Name = reader.GetString(0),
                        Match_Mimosa_Name = reader.GetString(1),
                        Match_Name_Sim = reader.GetInt32(2),
                        Match_Desc_Sim = reader.GetInt32(3),
                    };
                    allMatchConcepts.Add(allMatchConcept);
                }
            }
            return allMatchConcepts;
        }

    }
}
