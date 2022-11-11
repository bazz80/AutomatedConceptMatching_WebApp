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

            string queryCmd = @"SELECT similarity.name_plcs AS name_plcs, similarity.name_mimosa AS name_mimosa, similarity.weighted_similarity AS sim_weight, similarity.sim_name AS sim_name, similarity.sim_relationships AS sim_rel, similarity.sim_description AS sim_desc, plcs.description AS plcs_desc, mimosa.description AS mimosa_desc, plcs.relationships AS plcs_rel, mimosa.relationships AS mim_rel ";
            queryCmd = queryCmd + "FROM similarity CROSS JOIN plcs ON similarity.name_plcs = plcs.name_plcs CROSS JOIN mimosa ON name_mimosa = mimosa.name WHERE similarity.name_mimosa LIKE @concept or similarity.name_plcs LIKE @concept ORDER BY sim_weight DESC;";
            //string queryCmd = @"SELECT  name_plcs, name_mimosa, sim_name, sim_description FROM similarity WHERE name_plcs LIKE @concept OR name_mimosa LIKE @concept ORDER BY sim_name DESC";
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
                        Match_Weight_Sim = Math.Round(reader.GetDouble(2), 0, MidpointRounding.AwayFromZero),
                        Match_Name_Sim = reader.GetInt32(3),
                        Match_Rel_Sim = reader.GetInt32(4),
                        Match_Desc_Sim = reader.GetInt32(5),
                        Match_Plcs_Desc = reader.GetString(6),
                        Match_Mimosa_Desc = reader.GetString(7),
                        Match_Plcs_Rel = reader.GetString(8),
                        Match_Mimosa_Rel = reader.GetString(9),
                    };
                    allMatchConcepts.Add(allMatchConcept);
                }
            }
            return allMatchConcepts;
        }

    }
}
