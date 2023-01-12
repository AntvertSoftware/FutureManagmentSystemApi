using AutoMapper;
using FutureManagmentSystemApi.Models.Bussiness;
using FutureManagmentSystemApi.Models.Dtos;

namespace FutureManagmentSystemApi.Helpers
{
    public class Class:Profile
    {
        public Class()
        {
                     
                CreateMap<Admission, AdmissionDto>().ReverseMap();
            
        }
    }
}
