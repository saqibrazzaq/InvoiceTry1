using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class AddressService : IAddressService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public AddressService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        public AddressRes? Create(AddressReqEdit dto)
        {
            var entity = _mapper.Map<Address>(dto);
            _rep.AddressRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<AddressRes>(entity);
        }

        private Address? FindAddressIfExists(int addressId, bool trackChanges)
        {
            var entity = _rep.AddressRepository.FindByCondition(
                x => x.AddressId == addressId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Address not found."); }

            return entity;
        }

        public void Delete(int addressId)
        {
            var entity = FindAddressIfExists(addressId, true);
            _rep.AddressRepository.Delete(entity);
            _rep.Save();
        }

        public AddressRes? Get(int addressId)
        {
            var entity = FindAddressIfExists(addressId, false);
            return _mapper.Map<AddressRes>(entity);
        }

        public AddressRes? Update(int addressId, AddressReqEdit dto)
        {
            var entity = FindAddressIfExists(addressId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<AddressRes>(entity);
        }
    }
}
