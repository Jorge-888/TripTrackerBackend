using TripTracker.DataAccess.Repositories;
using TripTracker.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripTracker.Entities.Entities;

namespace TripTracker.BusinessLogic.Services
{
    public class AccesoServices
    {
        public UsuarioRepository _usuarioRepository { get; }
        //public RolRepository _rolRepository { get; }


        public AccesoServices(UsuarioRepository usuarioRepository
            /*, RolRepository rolRepository*/
            )
        {
            _usuarioRepository = usuarioRepository;
            //_rolRepository = rolRepository;

        }

        //#region Usuario

        public IEnumerable<tbUsuarios> ListUsuarios()
        {
            var result = new ServiceResult();
            try
            {
                var list = _usuarioRepository.List();
                return list;
            }
            catch (Exception ex)
            {
                IEnumerable<tbUsuarios> usuarios = [];
                return usuarios;
            }
        }


        public IEnumerable<tbRoles> ListRoles()
        {
            var result = new ServiceResult();
            try
            {
                var list = _usuarioRepository.RolesList();
                return list;
            }
            catch (Exception ex)
            {
                IEnumerable<tbRoles> list = [];
                return list;
            }
        }


        public tbUsuarios Login(tbUsuarios usuario)
        {
            //var result = new ServiceResult();
            try
            {
                var result = _usuarioRepository.Login(usuario);
                return result;

            }
            catch (Exception ex)
            {
                return new tbUsuarios();
            }
        }





        public ServiceResult InsertUsuario(tbUsuarios item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _usuarioRepository.Insert(item);
                return result.Ok(response);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServiceResult UpdateUsuario(tbUsuarios item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _usuarioRepository.Update(item);
                return result.Ok(response);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult DeleteUsuario(tbUsuarios item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _usuarioRepository.Delete(item);
                return result.Ok(response);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ResetUsuario(tbUsuarios item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _usuarioRepository.Reset(item);
                return result.Ok(response);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


    }
}
