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
    public class ViajeServices
    {
        public ViajeRepository _viajeRepository { get; }
        


        public ViajeServices(ViajeRepository viajeRepository
            
            )
        {
            _viajeRepository = viajeRepository;
            
        }

        #region Colaboradores


        public IEnumerable<tbViajes> ListViajesCompleto()
        {
            var result = new ServiceResult();
            try
            {
                var list = _viajeRepository.ViajesListCompleto();
                return list;
            }
            catch (Exception ex)
            {
                IEnumerable<tbViajes> list = [];
                return list;
            }
        }


        public ServiceResult InsertViajeCompleto(tbViajes item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _viajeRepository.InsertViajeCompleto(item);
                return result.Ok(response);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult UpdateViajeCompleto(tbViajes item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _viajeRepository.UpdateViajeCompleto(item);
                return result.Ok(response);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult DeleteViaje(tbViajes item)
        {
            var result = new ServiceResult();
            try
            {
                var response = _viajeRepository.DeleteViaje(item);
                return result.Ok(response);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }










        #endregion


        #region Lists

        public IEnumerable<tbColaboradores> ListColaboradoresPorSucursal(tbSucursales item)
        {
            var result = new ServiceResult();
            try
            {
                var list = _viajeRepository.ColaboradoresListPorSucursal(item);
                return list;
            }
            catch (Exception ex)
            {
                IEnumerable<tbColaboradores> list = [];
                return list;
            }
        }

        public IEnumerable<tbTransportistas> ListTransportistas()
        {
            var result = new ServiceResult();
            try
            {
                var list = _viajeRepository.TransportistasList();
                return list;
            }
            catch (Exception ex)
            {
                IEnumerable<tbTransportistas> list = [];
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
