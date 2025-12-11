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
    public class ViajeRepository 
    {

        public virtual IEnumerable<tbViajes> ViajesListCompleto()
        {
            var parameter = new DynamicParameters();

            using var db = new SqlConnection(TripTrackerContext.ConnectionString);
            var result = db.Query<tbViajes>(ScriptDatabase.Viajes_ListarCompleto, parameter, commandType: System.Data.CommandType.StoredProcedure).ToList();

            return result;
        }


        public virtual IEnumerable<tbTransportistas> TransportistasList()
        {
            var parameter = new DynamicParameters();

            using var db = new SqlConnection(TripTrackerContext.ConnectionString);
            var result = db.Query<tbTransportistas>(ScriptDatabase.Transportistas_Listar, parameter, commandType: System.Data.CommandType.StoredProcedure).ToList();

            return result;
        }


        public virtual IEnumerable<tbColaboradores> ColaboradoresListPorSucursal(tbSucursales item)
        {
            var parameter = new DynamicParameters();

            parameter.Add("@Sucu_Id", item.Sucu_Id, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);

            using var db = new SqlConnection(TripTrackerContext.ConnectionString);
            var result = db.Query<tbColaboradores>(ScriptDatabase.Colaboradores_ListarPorSucursal, parameter, commandType: System.Data.CommandType.StoredProcedure).ToList();

            return result;
        }



        public virtual RequestStatus InsertViajeCompleto(tbViajes item)
        {
            if (item == null)
            {
                return new RequestStatus { CodeStatus = 0, MessageStatus = "Los datos llegaron vacíos o datos erróneos." };
            }

            var parameter = new DynamicParameters();
            parameter.Add("@Viaj_Fecha", item.Viaj_Fecha, System.Data.DbType.DateTime, System.Data.ParameterDirection.Input);
            parameter.Add("@Viaj_TarifaKM", item.Viaj_TarifaKM, System.Data.DbType.Double, System.Data.ParameterDirection.Input);
            parameter.Add("@Viaj_TarifaTotal", item.Viaj_TarifaTotal, System.Data.DbType.Double, System.Data.ParameterDirection.Input);
            parameter.Add("@Trpo_Id", item.Trpo_Id, System.Data.DbType.Int64, System.Data.ParameterDirection.Input);
            parameter.Add("@Sucu_Id", item.Sucu_Id, System.Data.DbType.Int64, System.Data.ParameterDirection.Input);
            parameter.Add("@colaboradoresJson", item.colaboradoresJson, System.Data.DbType.String, System.Data.ParameterDirection.Input);


            parameter.Add("@Usua_Creacion", item.Usua_Creacion, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameter.Add("@Viaj_FechaCreacion", item.Viaj_FechaCreacion, System.Data.DbType.DateTime, System.Data.ParameterDirection.Input);

            try
            {
                using var db = new SqlConnection(TripTrackerContext.ConnectionString);
                var result = db.QueryFirstOrDefault<RequestStatus>(ScriptDatabase.Viajes_InsertarCompleto, parameter, commandType: System.Data.CommandType.StoredProcedure);

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


        public virtual RequestStatus UpdateViajeCompleto(tbViajes item)
        {
            if (item == null)
            {
                return new RequestStatus { CodeStatus = 0, MessageStatus = "Los datos llegaron vacíos o datos erróneos." };
            }

            var parameter = new DynamicParameters();
            parameter.Add("@Viaj_Id", item.Viaj_Id, System.Data.DbType.Int64, System.Data.ParameterDirection.Input);
            parameter.Add("@Viaj_Fecha", item.Viaj_Fecha, System.Data.DbType.DateTime, System.Data.ParameterDirection.Input);
            parameter.Add("@Viaj_TarifaKM", item.Viaj_TarifaKM, System.Data.DbType.Double, System.Data.ParameterDirection.Input);
            parameter.Add("@Viaj_TarifaTotal", item.Viaj_TarifaTotal, System.Data.DbType.Double, System.Data.ParameterDirection.Input);
            parameter.Add("@Trpo_Id", item.Trpo_Id, System.Data.DbType.Int64, System.Data.ParameterDirection.Input);
            parameter.Add("@Sucu_Id", item.Sucu_Id, System.Data.DbType.Int64, System.Data.ParameterDirection.Input);
            parameter.Add("@colaboradoresJson", item.colaboradoresJson, System.Data.DbType.String, System.Data.ParameterDirection.Input);


            parameter.Add("@Usua_Modificacion", item.Usua_Modificacion, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameter.Add("@Viaj_FechaModificacion", item.Viaj_FechaModificacion, System.Data.DbType.DateTime, System.Data.ParameterDirection.Input);

            try
            {
                using var db = new SqlConnection(TripTrackerContext.ConnectionString);
                var result = db.QueryFirstOrDefault<RequestStatus>(ScriptDatabase.Viajes_ActualizarCompleto, parameter, commandType: System.Data.CommandType.StoredProcedure);

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


        public virtual RequestStatus DeleteViaje(tbViajes item)
        {
            if (item == null)
            {
                return new RequestStatus { CodeStatus = 0, MessageStatus = "Los datos llegaron vacíos o datos erróneos." };
            }

            var parameter = new DynamicParameters();
            parameter.Add("@Viaj_Id", item.Viaj_Id, System.Data.DbType.Int64, System.Data.ParameterDirection.Input);

            parameter.Add("@Usua_Modificacion", item.Usua_Modificacion, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameter.Add("@Viaj_FechaModificacion", item.Viaj_FechaModificacion, System.Data.DbType.DateTime, System.Data.ParameterDirection.Input);

            try
            {
                using var db = new SqlConnection(TripTrackerContext.ConnectionString);
                var result = db.QueryFirstOrDefault<RequestStatus>(ScriptDatabase.Viajes_Eliminar, parameter, commandType: System.Data.CommandType.StoredProcedure);

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