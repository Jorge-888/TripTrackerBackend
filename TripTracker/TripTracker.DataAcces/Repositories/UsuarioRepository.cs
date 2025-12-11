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
    public class UsuarioRepository : IRepository<tbUsuarios>
    {
        
        public RequestStatus Delete(tbUsuarios item)
        {
            if (item == null)
            {
                return new RequestStatus { CodeStatus = 0, MessageStatus = "Los datos llegaron vacíos o datos erróneos." };
            }
            var parameters = new DynamicParameters();
            parameters.Add("@Usua_Id", item.Usua_Id, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameters.Add("@Usua_Modificacion", item.Usua_Modificacion, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameters.Add("@Usua_FechaModificacion", item.Usua_FechaModificacion, System.Data.DbType.DateTime, System.Data.ParameterDirection.Input);

            try
            {
                using var db = new SqlConnection(TripTrackerContext.ConnectionString);
                var result = db.QueryFirstOrDefault<RequestStatus>(ScriptDatabase.Usuario_Eliminar, parameters, commandType: System.Data.CommandType.StoredProcedure);

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




        public tbUsuarios Find(int? id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<tbUsuarios> List()
        {
            var parameter = new DynamicParameters();

            using var db = new SqlConnection(TripTrackerContext.ConnectionString);
            var result = db.Query<tbUsuarios>(ScriptDatabase.Usuarios_Listar, parameter, commandType: System.Data.CommandType.StoredProcedure).ToList();

            return result;
        }

        public virtual IEnumerable<tbRoles> RolesList()
        {
            var parameter = new DynamicParameters();

            using var db = new SqlConnection(TripTrackerContext.ConnectionString);
            var result = db.Query<tbRoles>(ScriptDatabase.Roles_Listar, parameter, commandType: System.Data.CommandType.StoredProcedure).ToList();

            return result;
        }


        public virtual tbUsuarios Login(tbUsuarios item)
        {

            var parameter = new DynamicParameters();
            parameter.Add("@Usua_Nombre", item.Usua_Nombre, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameter.Add("@Usua_Contrasena", item.Usua_Contrasena, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            
            using var db = new SqlConnection(TripTrackerContext.ConnectionString);
            var result = db.QueryFirstOrDefault<tbUsuarios>(ScriptDatabase.Usuario_Login, parameter, commandType: System.Data.CommandType.StoredProcedure);
            return result;
            
            
        }



        public virtual RequestStatus Insert(tbUsuarios item)
        {
            if (item == null)
            {
                return new RequestStatus { CodeStatus = 0, MessageStatus = "Los datos llegaron vacíos o datos erróneos." };
            }
            var parameter = new DynamicParameters();
            parameter.Add("@Usua_Nombre", item.Usua_Nombre, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameter.Add("@Usua_Contrasena", item.Usua_Contrasena, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameter.Add("@Role_Id", item.Role_Id, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameter.Add("@Colb_Id", item.Colb_Id, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameter.Add("@Usua_Admin", item.Usua_Admin, System.Data.DbType.Boolean, System.Data.ParameterDirection.Input);
            
            parameter.Add("@Usua_Creacion", item.Usua_Creacion, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameter.Add("@Usua_FechaCreacion", item.Usua_FechaCreacion, System.Data.DbType.DateTime, System.Data.ParameterDirection.Input);

            try
            {
                using var db = new SqlConnection(TripTrackerContext.ConnectionString);
                var result = db.QueryFirstOrDefault<RequestStatus>(ScriptDatabase.Usuario_Insertar, parameter, commandType: System.Data.CommandType.StoredProcedure);

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

        


        public IEnumerable<tbUsuarios> Find(tbUsuarios item)
        {
            throw new NotImplementedException();
        }

        

        public RequestStatus Update(tbUsuarios item)
        {
            if (item == null)
            {
                return new RequestStatus { CodeStatus = 0, MessageStatus = "Los datos llegaron vacíos o datos erróneos." };
            }
            var parameter = new DynamicParameters();
            parameter.Add("@Usua_Id", item.Usua_Id, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameter.Add("@Usua_Nombre", item.Usua_Nombre, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            //parameter.Add("@Usua_Contrasena", item.Usua_Contrasena, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameter.Add("@Role_Id", item.Role_Id, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameter.Add("@Colb_Id", item.Colb_Id, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameter.Add("@Usua_Admin", item.Usua_Admin, System.Data.DbType.Boolean, System.Data.ParameterDirection.Input);

            parameter.Add("@Usua_Modificacion", item.Usua_Modificacion, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameter.Add("@Usua_FechaModificacion", item.Usua_FechaModificacion, System.Data.DbType.DateTime, System.Data.ParameterDirection.Input);

            try
            {
                using var db = new SqlConnection(TripTrackerContext.ConnectionString);
                var result = db.QueryFirstOrDefault<RequestStatus>(ScriptDatabase.Usuario_Actualizar, parameter, commandType: System.Data.CommandType.StoredProcedure);

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


        public RequestStatus Reset(tbUsuarios item)
        {
            if (item == null)
            {
                return new RequestStatus { CodeStatus = 0, MessageStatus = "Los datos llegaron vacíos o datos erróneos." };
            }
            var parameters = new DynamicParameters();
            parameters.Add("@Usua_Id", item.Usua_Id, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameters.Add("@Usua_Contrasena", item.Usua_Contrasena, System.Data.DbType.String, System.Data.ParameterDirection.Input);
            parameters.Add("@Usua_Modificacion", item.Usua_Modificacion, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);
            parameters.Add("@Usua_FechaModificacion", item.Usua_FechaModificacion, System.Data.DbType.DateTime, System.Data.ParameterDirection.Input);

            try
            {
                using var db = new SqlConnection(TripTrackerContext.ConnectionString);
                var result = db.QueryFirstOrDefault<RequestStatus>(ScriptDatabase.Usuario_Reestablecer, parameters, commandType: System.Data.CommandType.StoredProcedure);

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