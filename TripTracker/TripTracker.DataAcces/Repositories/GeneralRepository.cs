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

        public virtual IEnumerable<tbColaboradores> ColaboradoresList()
        {
            var parameter = new DynamicParameters();

            using var db = new SqlConnection(TripTrackerContext.ConnectionString);
            var result = db.Query<tbColaboradores>(ScriptDatabase.Colaboradores_Listar, parameter, commandType: System.Data.CommandType.StoredProcedure).ToList();

            return result;
        }


        public virtual IEnumerable<tbCargos> CargosList()
        {
            var parameter = new DynamicParameters();

            using var db = new SqlConnection(TripTrackerContext.ConnectionString);
            var result = db.Query<tbCargos>(ScriptDatabase.Cargos_Listar, parameter, commandType: System.Data.CommandType.StoredProcedure).ToList();

            return result;
        }

        public virtual IEnumerable<tbAreas> AreasList()
        {
            var parameter = new DynamicParameters();

            using var db = new SqlConnection(TripTrackerContext.ConnectionString);
            var result = db.Query<tbAreas>(ScriptDatabase.Areas_Listar, parameter, commandType: System.Data.CommandType.StoredProcedure).ToList();

            return result;
        }

        public virtual IEnumerable<tbEstadosCiviles> EstadosCivilesList()
        {
            var parameter = new DynamicParameters();

            using var db = new SqlConnection(TripTrackerContext.ConnectionString);
            var result = db.Query<tbEstadosCiviles>(ScriptDatabase.EstadosCiviles_Listar, parameter, commandType: System.Data.CommandType.StoredProcedure).ToList();

            return result;
        }

        public virtual IEnumerable<tbMunicipios> MunicipiosList()
        {
            var parameter = new DynamicParameters();

            using var db = new SqlConnection(TripTrackerContext.ConnectionString);
            var result = db.Query<tbMunicipios>(ScriptDatabase.Municipios_Listar, parameter, commandType: System.Data.CommandType.StoredProcedure).ToList();

            return result;
        }

        public virtual IEnumerable<tbDepartamentos> DepartamentosList()
        {
            var parameter = new DynamicParameters();

            using var db = new SqlConnection(TripTrackerContext.ConnectionString);
            var result = db.Query<tbDepartamentos>(ScriptDatabase.Departamentos_Listar, parameter, commandType: System.Data.CommandType.StoredProcedure).ToList();

            return result;
        }


        public virtual IEnumerable<tbSucursales> SucursalesList()
        {
            var parameter = new DynamicParameters();

            using var db = new SqlConnection(TripTrackerContext.ConnectionString);
            var result = db.Query<tbSucursales>(ScriptDatabase.Sucursales_Listar, parameter, commandType: System.Data.CommandType.StoredProcedure).ToList();

            return result;
        }



        public virtual RequestStatus InsertColaborador(tbColaboradores item)
        {
            if (item == null)
            {
                return new RequestStatus { CodeStatus = 0, MessageStatus = "Los datos llegaron vacíos o datos erróneos." };
            }
            var parameter = new DynamicParameters();
            parameter.Add("@Colb_Nombres", item.Colb_Nombres, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameter.Add("@Colb_Apellidos", item.Colb_Apellidos, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameter.Add("@Colb_DNI", item.Colb_DNI, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameter.Add("@Colb_Telefono", item.Colb_Telefono, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameter.Add("@Colb_Sexo", item.Colb_Sexo, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameter.Add("@Colb_Direccion", item.Colb_Direccion, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameter.Add("@EsCi_Id", item.EsCi_Id, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameter.Add("@Muni_Codigo", item.Muni_Codigo, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameter.Add("@Area_Id", item.Area_Id, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameter.Add("@Carg_Id", item.Carg_Id, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameter.Add("@sucursalesJson", item.sucursalesJson, System.Data.DbType.String, System.Data.ParameterDirection.Input);

            parameter.Add("@Usua_Creacion", item.Usua_Creacion, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameter.Add("@Colb_FechaCreacion", item.Colb_FechaCreacion, System.Data.DbType.DateTime, System.Data.ParameterDirection.Input);

            try
            {
                using var db = new SqlConnection(TripTrackerContext.ConnectionString);
                var result = db.QueryFirstOrDefault<RequestStatus>(ScriptDatabase.Colaboradores_InsertarCompleto, parameter, commandType: System.Data.CommandType.StoredProcedure);

                if (result == null)
                {
                    return new RequestStatus { CodeStatus = 0, MessageStatus = "Error desconocido." };
                }
                return result;
            }
            catch (Exception ex)
            {
                return new RequestStatus { CodeStatus = 0, MessageStatus = $"Error inesperado: {ex.Message}" };
            }
        }



    }
}