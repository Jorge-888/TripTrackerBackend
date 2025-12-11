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
    public class UsuariosController : Controller
    {
        private readonly AccesoServices _accesoServices;
        private readonly IMapper _mapper;

        public UsuariosController(AccesoServices accesoServices, IMapper mapper)
        {
            _accesoServices = accesoServices;
            _mapper = mapper;
        }


        [HttpGet("Listar")]
        public IActionResult Listar()
        {
            var result = _accesoServices.ListUsuarios();
            //var result = new List<dynamic>();
            return Ok(result);
        }


        [HttpGet("ListarRoles")]
        public IActionResult ListarRoles()
        {
            var result = _accesoServices.ListRoles();
            
            return Ok(result);
        }


        [HttpPost("Login")]
        public IActionResult Login([FromBody] UsuariosViewModel usuario)
        {
            var mapped = _mapper.Map<tbUsuarios>(usuario);
            var result = _accesoServices.Login(mapped);
            //var result = new List<dynamic>();
            return Ok(result);
        }

        //[HttpPost("Login")]
        //public IActionResult Login([FromBody] UsuariosViewModel item)
        //{
        //    var mapped = _mapper.Map<tbUsuarios>(item);
        //    var result = _accesoServices.Login(mapped);
        //    return Ok(result);

        //}


        [HttpPost("Insertar")]
        public IActionResult Insertar([FromBody] UsuariosViewModel item)
        {

            var mapped = _mapper.Map<tbUsuarios>(item);
            var result = _accesoServices.InsertUsuario(mapped);
            return Ok(result);
        }



        //[HttpPost("ObtenerUsuario")]
        //public IActionResult Actualizar([FromBody] UsuariosViewModel item)
        //{
        //    var mapped = _mapper.Map<tbUsuarios>(item);
        //    var result = _accesoServices.FindUsuarios(mapped);
        //    return Ok(result);
        //}

        [HttpPut("Actualizar")]
        public IActionResult Update([FromBody] UsuariosViewModel item)
        {

            var mapped = _mapper.Map<tbUsuarios>(item);
            var result = _accesoServices.UpdateUsuario(mapped);
            return Ok(result);
        }


        //[HttpPut("RestablecerUsuario")]
        //public IActionResult Reset([FromBody] UsuariosViewModel item)
        //{
        //    //var tbPrestamosDetalle = await _context.tbPrestamosDetalle.FindAsync(id);

        //    var mapped = _mapper.Map<tbUsuarios>(item);
        //    var result = _accesoServices.ResetUsuario(mapped);
        //    return Ok(result);
        //}


        [HttpPost("Desactivar")]
        public IActionResult Delete([FromBody] UsuariosViewModel item)
        {
            var mapped = _mapper.Map<tbUsuarios>(item);
            var result = _accesoServices.DeleteUsuario(mapped);
            return Ok(result);
        }

        [HttpPost("Reestablecer")]
        public IActionResult Reset([FromBody] UsuariosViewModel item)
        {
            var mapped = _mapper.Map<tbUsuarios>(item);
            var result = _accesoServices.ResetUsuario(mapped);
            return Ok(result);
        }

    }
}
