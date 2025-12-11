using System.ComponentModel.DataAnnotations.Schema;

namespace TripTracker.API.Models
{
    public class ViajesViewModel
    {
        public int Viaj_Id { get; set; }

        public DateTime Viaj_Fecha { get; set; }

        public decimal? Viaj_TarifaTotal { get; set; }

        public decimal Viaj_TarifaKM { get; set; }

        public int Trpo_Id { get; set; }

        public int Sucu_Id { get; set; }

        public bool? Viaj_Estado { get; set; }

        public int Usua_Creacion { get; set; }

        public DateTime Viaj_FechaCreacion { get; set; }

        public int? Usua_Modificacion { get; set; }

        public DateTime? Viaj_FechaModificacion { get; set; }

        [NotMapped]
        public string? colaboradoresJson { get; set; }

        [NotMapped]
        public string? Trpo_Nombres { get; set; }

        [NotMapped]
        public string? Trpo_Apellidos { get; set; }

        [NotMapped]
        public string? Trpo_DNI { get; set; }

        [NotMapped]
        public string? Trpo_Sexo { get; set; }

        [NotMapped]
        public string? Trpo_Placa { get; set; }

        [NotMapped]
        public string? Trpo_Vehiculo { get; set; }

        [NotMapped]
        public string? Sucu_Descripcion { get; set; }

        [NotMapped]
        public string? UsuarioCreacion { get; set; }

        [NotMapped]
        public string? UsuarioModificacion { get; set; }

    }
}
