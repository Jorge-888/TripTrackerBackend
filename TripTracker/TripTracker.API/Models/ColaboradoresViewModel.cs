using System.ComponentModel.DataAnnotations.Schema;

namespace TripTracker.API.Models
{
    public class ColaboradoresViewModel
    {
        public int Colb_Id { get; set; }

        public string Colb_DNI { get; set; }

        public string Colb_Nombres { get; set; }

        public string Colb_Apellidos { get; set; }

        public string Colb_Telefono { get; set; }

        public string Colb_Sexo { get; set; }

        public string Colb_Direccion { get; set; }

        public int? EsCi_Id { get; set; }

        public string Muni_Codigo { get; set; }

        public int? Area_Id { get; set; }

        public int? Carg_Id { get; set; }

        public bool? Colb_Estado { get; set; }

        public int Usua_Creacion { get; set; }

        public DateTime Colb_FechaCreacion { get; set; }

        public int? Usua_Modificacion { get; set; }

        public DateTime? Colb_FechaModificacion { get; set; }

        [NotMapped]
        public string? sucursalesJson { get; set; }

        [NotMapped]
        public int? SuCo_Id { get; set; }

        [NotMapped]
        public decimal? SuCo_DistanciaCasa { get; set; }

        [NotMapped]
        public int? Sucu_Id { get; set; }

        [NotMapped]
        public string? Sucu_Descripcion { get; set; }

        [NotMapped]
        public string? EsCi_Descripcion { get; set; }

        [NotMapped]
        public string? Muni_Descripcion { get; set; }

        [NotMapped]
        public string? Depa_Descripcion { get; set; }

        [NotMapped]
        public string? Area_Descripcion { get; set; }

        [NotMapped]
        public string? Carg_Descripcion { get; set; }

        [NotMapped]
        public string? UsuarioCreacion { get; set; }

        [NotMapped]
        public string? UsuarioModificacion { get; set; }


    }
}
