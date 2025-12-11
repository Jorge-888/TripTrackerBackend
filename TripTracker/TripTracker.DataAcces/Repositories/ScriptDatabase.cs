using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripTracker.DataAccess.Repositories
{
    public class ScriptDatabase
    {


        #region generales

        
        public static string Colaboradores_Listar = "[Acce].[SP_tbColaboradores_Listar]";
        public static string Colaborador_Insertar = "[Gral].[SP_tbColaboradores_Insertar]";
        public static string Colaboradores_InsertarCompleto= "Gral.SP_tbColaboradores_InsertarCompleto";
        public static string Colaborador_Actualizar = "[Gral].[SP_tbColaboradores_Actualizar]";
        public static string Colaborador_Eliminar = "[Gral].[SP_tbColaboradores_Eliminar]";

        public static string Cargos_Listar = "[Gral].[SP_tbCargos_Listar]";
        public static string Areas_Listar = "[Gral].[SP_tbAreas_Listar]";
        public static string EstadosCiviles_Listar = "[Gral].[SP_tbEstadosCiviles_Listar]";
        public static string Municipios_Listar = "[Gral].[SP_tbMunicipios_Listar]";
        public static string Departamentos_Listar = "[Gral].[SP_tbDepartamentos_Listar]";
        public static string Sucursales_Listar = "[Gral].[SP_tbSucursales_Listar]";

        #endregion


        #region acceso

        public static string Usuarios_Listar = "[Acce].[SP_tbUsuarios_Listar]";
        public static string Usuario_Insertar = "[Acce].[SP_tbUsuarios_Insertar]";
        public static string Usuario_Actualizar = "[Acce].[SP_tbUsuarios_Actualizar]";
        public static string Usuario_Eliminar = "[Acce].[SP_tbUsuarios_Eliminar]";
        public static string Usuario_Login = "[Acce].[SP_tbUsuarios_Login]";
        public static string Usuario_CambiarContrasena = "[Acce].[SP_tbUsuarios_CambiarContrasena]";
        public static string Usuario_Reestablecer = "[Acce].[SP_tbUsuarios_Reestablecer]";


        public static string Roles_Listar = "[Acce].[SP_tbRoles_Listar]";

        #endregion


        #region viajes

        public static string Viajes_ListarCompleto = "Viaj.SP_tbViajes_ListarCompleto";
        public static string Viajes_InsertarCompleto = "Viaj.SP_tbViajes_InsertarCompleto";
        public static string Viajes_ActualizarCompleto = "Viaj.SP_tbViajes_ActualizarCompleto";
        public static string Viajes_Eliminar = "Viaj.SP_tbViajes_Eliminar";


        public static string Colaboradores_ListarPorSucursal = "Viaj.SP_tbSucursalesPorColaborador_ListarPorSucursal";
        public static string Transportistas_Listar = "[Viaj].[SP_tbTransportistas_Listar]";

        #endregion


    }
}