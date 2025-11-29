using AutoMapper;
using TripTracker.API.Models;

//using TripTracker.API.Models;
using TripTracker.Entities;
using TripTracker.Entities.Entities;

namespace TripTracker.API.Extensions
{
    public class MappingProfileExtensions: Profile
    {
        public MappingProfileExtensions() 
        {
            //CreateMap<tbDepartamentos, DepartamentosViewModel>().ReverseMap();
            //CreateMap<tbMunicipios, MunicipioViewModel>().ReverseMap();
            //CreateMap<tbCargos, CargosViewModel>().ReverseMap();
            //CreateMap<tbAreas, AreaViewModel>().ReverseMap();
            CreateMap<tbUsuarios, UsuariosViewModel>().ReverseMap();
            //CreateMap<tbEstadosCiviles, EstadoCivilViewModel>().ReverseMap();
            //CreateMap<tbRoles, RolViewModel>().ReverseMap();
            //CreateMap<tbDeducciones, DeduccionViewModel>().ReverseMap();
            //CreateMap<tbFrecuenciasPago, FrecuenciaPagoViewModel>().ReverseMap();
            //CreateMap<tbEmpleados, EmpleadoViewModel>().ReverseMap();
            //CreateMap<tbPlanillas, PlanillaViewModel>().ReverseMap();



        }
    }
}
