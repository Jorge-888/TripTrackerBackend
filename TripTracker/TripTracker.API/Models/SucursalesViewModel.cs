namespace TripTracker.API.Models
{
    public class SucursalesViewModel
    {
        public int Sucu_Id { get; set; }

        public string Sucu_Descripcion { get; set; }

        public string Muni_Codigo { get; set; }

        public bool? Sucu_Estado { get; set; }

        public int Usua_Creacion { get; set; }

        public DateTime Sucu_FechaCreacion { get; set; }

        public int? Usua_Modificacion { get; set; }

        public DateTime? Sucu_FechaModificacion { get; set; }
    }
}
