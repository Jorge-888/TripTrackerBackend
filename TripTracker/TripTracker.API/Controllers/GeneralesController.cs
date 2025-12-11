using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TripTracker.API.Helpers;
using TripTracker.API.Models;
using TripTracker.BusinessLogic.Services;
using TripTracker.Entities;
using TripTracker.Entities.Entities;

namespace TripTracker.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [ApiKey]
    public class GeneralesController : Controller
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public GeneralesController(GeneralServices generalServices, IMapper mapper)
        {
            _generalServices = generalServices;
            _mapper = mapper;
        }


        [HttpGet("ListarColaboradores")]
        public IActionResult ListarColaboradores()
        {
            var result = _generalServices.ListColaboradores();
            
            return Ok(result);
        }


        [HttpPost("InsertarColaboradorCompleto")]
        public IActionResult Insertar([FromBody] ColaboradoresViewModel item)
        {

            var mapped = _mapper.Map<tbColaboradores>(item);
            var result = _generalServices.InsertColaborador(mapped);
            return Ok(result);
        }



        [HttpGet("ListarAreas")]
        public IActionResult ListarAreas()
        {
            var result = _generalServices.ListAreas();

            return Ok(result);
        }

        [HttpGet("ListarCargos")]
        public IActionResult ListarCargos()
        {
            var result = _generalServices.ListCargos();

            return Ok(result);
        }

        [HttpGet("ListarEstadosCiviles")]
        public IActionResult ListarEstadosCiviles()
        {
            var result = _generalServices.ListEstadosCiviles();

            return Ok(result);
        }

        [HttpGet("ListarMunicipios")]
        public IActionResult ListarMunicipios()
        {
            var result = _generalServices.ListMunicipios();

            return Ok(result);
        }

        [HttpGet("ListarDepartamentos")]
        public IActionResult ListarDepartamentos()
        {
            var result = _generalServices.ListDepartamentos();

            return Ok(result);
        }

        [HttpGet("ListarSucursales")]
        public IActionResult ListarSucursales()
        {
            var result = _generalServices.ListSucursales();

            return Ok(result);
        }


        //[HttpPost("Insertar")]
        //public IActionResult Insertar([FromBody] UsuariosViewModel item)
        //{

        //    var mapped = _mapper.Map<tbUsuarios>(item);
        //    var result = _accesoServices.InsertUsuario(mapped);
        //    return Ok(result);
        //}


    }
}
