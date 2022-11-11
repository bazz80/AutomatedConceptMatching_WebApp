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
    public class PlcsConceptQuery
    {
        public MySqlDb Db { get; }

        public PlcsConceptQuery(MySqlDb db)
        {
            Db = db;
        }

        //List all PLCS Concepts
        public async Task<List<PlcsConcept>> ListPlcsAsync()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT idPLCS, name_plcs, description, relationships FROM plcs ORDER BY name_plcs ASC";
            return await ReadPlcsAsync(await cmd.ExecuteReaderAsync());
        }

        private async Task<List<PlcsConcept>> ReadPlcsAsync(DbDataReader reader)
        {
            var plcsConcepts = new List<PlcsConcept>();
            using (reader)
            {
                while (await reader.ReadAsync())
                {
                    var plcsConcept = new PlcsConcept(Db)
                    {
                        Plcs_Id = reader.GetInt64(0),
                        Plcs_Name = reader.GetString(1),
                        Plcs_Desc = reader.GetString(2),
                        Plcs_Rel = reader.GetString(3),
                    };
                    plcsConcepts.Add(plcsConcept);
                }
            }
            return plcsConcepts;
        }
    }
}
