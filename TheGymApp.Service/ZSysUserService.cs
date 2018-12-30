using AutoMapper;
using System;
using System.Threading.Tasks;
using TheGymApp.Data;
using TheGymApp.Service.Models;
using System.Linq;

namespace TheGymApp.Service
{
    public class ZSysUserService : IZsysUserService
    {
        private readonly IZSysUserRepository _zsysUserRepository;
        private readonly IMapper _mapper;

        public ZSysUserService(IZSysUserRepository zsysUserRepository, IMapper mapper)
        {
            _zsysUserRepository = zsysUserRepository;
            _mapper = mapper;
        }        

        public async Task<bool> CreateNewMember(ZSysUserDTO Member)
        {
            var model = _mapper.Map<ZSysUser>(Member);
            return await _zsysUserRepository.CreateNewMember(model) ;
            
        }

        public async Task<ZSysUserDTO> GetMemberDetails(int MemberId)
        {
            var memberDetails =  await _zsysUserRepository.GetMember(MemberId);
            
              return new ZSysUserDTO
              {
                  AddressLine1 = memberDetails.AddressLine1,
                  AddressLine2 = memberDetails.AddressLine2,
                  DOB = memberDetails.DOB,
                  Email = memberDetails.Email,
                  FirstName = memberDetails.FirstName,
                  LastName = memberDetails.LastName,
                  Id = memberDetails.Id,
                  Notes = memberDetails.Notes
              };
            
        }

    }
}
