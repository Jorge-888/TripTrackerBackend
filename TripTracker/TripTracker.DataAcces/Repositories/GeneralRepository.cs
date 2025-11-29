using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;
using TripTracker.Entities.Entities;
using TripTracker.DataAccess;


namespace TripTracker.DataAccess.Repositories
{
    public class GeneralRepository 
    {

        public virtual IEnumerable<tbUsuarios> ColaboradoresList()
        {
            var parameter = new DynamicParameters();

            using var db = new SqlConnection(TripTrackerContext.ConnectionString);
            var result = db.Query<tbUsuarios>(ScriptDatabase.Usuarios_Listar, parameter, commandType: System.Data.CommandType.StoredProcedure).ToList();

            return result;
        }
    }
}