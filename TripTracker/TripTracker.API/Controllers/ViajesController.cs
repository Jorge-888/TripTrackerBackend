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
    public class ViajesController : Controller
    {
        private readonly ViajeServices _viajeServices;
        private readonly IMapper _mapper;

        public ViajesController(ViajeServices viajeServices, IMapper mapper)
        {
            _viajeServices = viajeServices;
            _mapper = mapper;
        }


        [HttpGet("ListarViajes")]
        public IActionResult ListarViajes()
        {
            var result = _viajeServices.ListViajesCompleto();
            
            return Ok(result);
        }


        [HttpPost("InsertarViajesCompleto")]
        public IActionResult InsertarViajesCompleto([FromBody] ViajesViewModel item)
        {

            var mapped = _mapper.Map<tbViajes>(item);
            var result = _viajeServices.InsertViajeCompleto(mapped);
            return Ok(result);
        }


        [HttpPut("ActualizarViajesCompleto")]
        public IActionResult ActualizarViajesCompleto([FromBody] ViajesViewModel item)
        {
            var mapped = _mapper.Map<tbViajes>(item);
            var result = _viajeServices.UpdateViajeCompleto(mapped);
            return Ok(result);
        }

        [HttpPost("EliminarViaje")]
        public IActionResult EliminarViaje([FromBody] ViajesViewModel item)
        {

            var mapped = _mapper.Map<tbViajes>(item);
            var result = _viajeServices.DeleteViaje(mapped);
            return Ok(result);
        }







        [HttpGet("ListarColaboradoresPorSucursal/{Sucu_Id}")]
        public IActionResult ListarColaboradoresPorSucursal(int Sucu_Id)
        {
            var item = new SucursalesViewModel { Sucu_Id = Sucu_Id };
            var mapped = _mapper.Map<tbSucursales>(item);
            var result = _viajeServices.ListColaboradoresPorSucursal(mapped);

            return Ok(result);
        }


        [HttpGet("ListarTransportistas")]
        public IActionResult ListarTransportistas()
        {
            var result = _viajeServices.ListTransportistas();

            return Ok(result);
        }



    }
}
