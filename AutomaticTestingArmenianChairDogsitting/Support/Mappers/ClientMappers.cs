using AutoMapper;
using AutomaticTestingArmenianChairDogsitting.Models.Request;
using AutomaticTestingArmenianChairDogsitting.Models.Response;
using System;
using System.Collections.Generic;

namespace AutomaticTestingArmenianChairDogsitting.Support.Mappers
{
    public class ClientMappers
    {
        public ClientAllInfoResponseModel MappClientRegistrationRequestModelToClientAllInfoResponseModel
            (int id, DateTime date, ClientRegistrationRequestModel model)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ClientRegistrationRequestModel, ClientAllInfoResponseModel>());
            Mapper mapper = new Mapper(config);
            var responseModel = mapper.Map<ClientAllInfoResponseModel>(model);
            responseModel.Id = id;
            responseModel.RegistrationDate = date;
            responseModel.Dogs = new List<ClientsAnimalsResponseModel>();
            responseModel.Orders = new List<OrderAllInfoResponseModel>();
            responseModel.IsDeleted = false;
            return responseModel;
        }

        public ClientAllInfoResponseModel MappClientUpdateRequestModelToClientAllInfoResponseModel
            (int id, DateTime date, string email, ClientUpdateRequestModel model)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ClientUpdateRequestModel, ClientAllInfoResponseModel>());
            Mapper mapper = new Mapper(config);
            var responseModel = mapper.Map<ClientAllInfoResponseModel>(model);
            responseModel.Id = id;
            responseModel.RegistrationDate = date;
            responseModel.Email = email;
            responseModel.Dogs = new List<ClientsAnimalsResponseModel>();
            responseModel.Orders = new List<OrderAllInfoResponseModel>();
            responseModel.IsDeleted = false;
            return responseModel;
        }

        public ClientUpdateRequestModel MappClientRegistrationRequestModelToClientUpdateRequestModel
            (ClientRegistrationRequestModel model)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ClientRegistrationRequestModel, ClientUpdateRequestModel>());
            Mapper mapper = new Mapper(config);
            var responseModel = mapper.Map<ClientUpdateRequestModel>(model);
            return responseModel;
        }
        public ClientsGetAllResponseModel MappClientRegistrationRequestModelToClientsGetAllResponseModel
            (int id, DateTime date, ClientRegistrationRequestModel model)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ClientRegistrationRequestModel, ClientsGetAllResponseModel>());
            Mapper mapper = new Mapper(config);
            var responseModel = mapper.Map<ClientsGetAllResponseModel>(model);
            responseModel.Id = id;
            responseModel.RegistrationDate = date;
            return responseModel;
        }

        public ChangePasswordRequestModel MappClientRegistrationModelToChangePasswordRequestModel
            (ClientRegistrationRequestModel model, string newPassword)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ClientRegistrationRequestModel, ChangePasswordRequestModel>()
            .ForMember(pts => pts.OldPassword, opt => opt.MapFrom(o => o.Password)));
            Mapper mapper = new Mapper(config);
            var responseModel = mapper.Map<ChangePasswordRequestModel>(model);
            responseModel.Password = newPassword;
            return responseModel;
        }
    }
}
