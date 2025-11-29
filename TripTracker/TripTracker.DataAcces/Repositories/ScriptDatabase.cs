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

        public static string Usuarios_Listar = "[Acce].[SP_tbUsuarios_Listar]";
        public static string Usuario_Insertar= "[Acce].[SP_tbUsuarios_Insertar]";
        public static string Usuario_Actualizar= "[Acce].[SP_tbUsuarios_Actualizar]";
        public static string Usuario_Eliminar= "[Acce].[SP_tbUsuarios_Eliminar]";
        public static string Usuario_Login = "[Acce].[SP_tbUsuarios_Login]";
        public static string Usuario_CambiarContrasena= "[Acce].[SP_tbUsuarios_CambiarContrasena]";

        
        
        

        #endregion pantallassegunrol


        #region acceso



        #endregion pantallassegunrol





    }
}