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
    public class GeneralServices
    {
        public GeneralRepository _generalRepository { get; }
        


        public GeneralServices(GeneralRepository generalRepository
            
            )
        {
            _generalRepository = generalRepository;
            
        }

        #region Colaboradores


        public IEnumerable<tbColaboradores> ListColaboradores()
        {
            var result = new ServiceResult();
            try
            {
                var list = _generalRepository.ColaboradoresList();
                return list;
            }
            catch (Exception ex)
            {
                IEnumerable<tbColaboradores> list = [];
                return list;
            }
        }


        public ServiceResult InsertColaborador(tbColaboradores item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _generalRepository.InsertColaborador(item);
                return result.Ok(response);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        #endregion


        #region Lists Generales

        public IEnumerable<tbCargos> ListCargos()
        {
            var result = new ServiceResult();
            try
            {
                var list = _generalRepository.CargosList();
                return list;
            }
            catch (Exception ex)
            {
                IEnumerable<tbCargos> list = [];
                return list;
            }
        }

        public IEnumerable<tbAreas> ListAreas()
        {
            var result = new ServiceResult();
            try
            {
                var list = _generalRepository.AreasList();
                return list;
            }
            catch (Exception ex)
            {
                IEnumerable<tbAreas> list = [];
                return list;
            }
        }

        public IEnumerable<tbEstadosCiviles> ListEstadosCiviles()
        {
            var result = new ServiceResult();
            try
            {
                var list = _generalRepository.EstadosCivilesList();
                return list;
            }
            catch (Exception ex)
            {
                IEnumerable<tbEstadosCiviles> list = [];
                return list;
            }
        }

        public IEnumerable<tbMunicipios> ListMunicipios()
        {
            var result = new ServiceResult();
            try
            {
                var list = _generalRepository.MunicipiosList();
                return list;
            }
            catch (Exception ex)
            {
                IEnumerable<tbMunicipios> list = [];
                return list;
            }
        }

        public IEnumerable<tbDepartamentos> ListDepartamentos()
        {
            var result = new ServiceResult();
            try
            {
                var list = _generalRepository.DepartamentosList();
                return list;
            }
            catch (Exception ex)
            {
                IEnumerable<tbDepartamentos> list = [];
                return list;
            }
        }

        public IEnumerable<tbSucursales> ListSucursales()
        {
            var result = new ServiceResult();
            try
            {
                var list = _generalRepository.SucursalesList();
                return list;
            }
            catch (Exception ex)
            {
                IEnumerable<tbSucursales> list = [];
                return list;
            }
        }


        #endregion




        //public ServiceResult InsertUsuario(tbUsuarios item)
        //{
        //    var result = new ServiceResult();
        //    try
        //    {
        //        var response = _usuarioRepository.Insert(item);
        //        return result.Ok(response);
        //    }
        //    catch (Exception ex)
        //    {
        //        return result.Error(ex.Message);
        //    }
        //}





    }
}
