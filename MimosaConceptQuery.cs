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
    public class MimosaConceptQuery
    {
        public MySqlDb Db { get; }

        public MimosaConceptQuery(MySqlDb db)
        {
            Db = db;
        }

        //List all PLCS Concepts
        public async Task<List<MimosaConcept>> ListMimosaAsync()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT idMimosa, name, description, relationships FROM mimosa ORDER BY name ASC";
            return await ReadMimosaAsync(await cmd.ExecuteReaderAsync());
        }

        private async Task<List<MimosaConcept>> ReadMimosaAsync(DbDataReader reader)
        {
            var mimosaConcepts = new List<MimosaConcept>();
            using (reader)
            {
                while (await reader.ReadAsync())
                {
                    var mimosaConcept = new MimosaConcept(Db)
                    {
                        Mimosa_Id = reader.GetInt64(0),
                        Mimosa_Name = reader.GetString(1),
                        Mimosa_Desc = reader.GetString(2),
                        Mimosa_Rel = reader.GetString(3),
                    };
                    mimosaConcepts.Add(mimosaConcept);
                }
            }
            return mimosaConcepts;
        }
    }
}
