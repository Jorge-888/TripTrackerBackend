namespace TripTracker.API.Models
{
    public class UsuariosViewModel
    {
        public int Usua_Id { get; set; }

        public string Usua_Nombre { get; set; }

        public string Usua_Contrasena { get; set; }

        public DateTime Usua_FechaCreacion { get; set; }

        public DateTime Usua_FechaModificacion { get; set; }

        public bool? Usua_Estado { get; set; }

        public int? Role_Id { get; set; }

        public int Colb_Id { get; set; }

        public bool? Usua_Admin { get; set; }

        public int? Usua_Creacion { get; set; }

        public int? Usua_Modificacion { get; set; }
    }
}
