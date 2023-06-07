using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class CustomerShippingAddressService : ICustomerShippingAddressService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public CustomerShippingAddressService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private CustomerShippingAddress FindEntityIfExists(int customerShippingAddressId, bool trackChanges)
        {
            var entity = _rep.CustomerShippingAddressRepository.FindByCondition(
                x => x.CustomerShippingAddressId == customerShippingAddressId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Customer shipping address not found"); }

            return entity;
        }

        public CustomerShippingAddressRes? Create(CustomerShippingAddressReqEdit dto)
        {
            var entity = _mapper.Map<CustomerShippingAddress>(dto);
            _rep.CustomerShippingAddressRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<CustomerShippingAddressRes>(entity);
        }

        public void Delete(int customerShippingAddressId)
        {
            var entity = FindEntityIfExists(customerShippingAddressId, true);
            _rep.CustomerShippingAddressRepository.Delete(entity);
            _rep.Save();
        }

        public CustomerShippingAddressRes? Get(int customerShippingAddressId)
        {
            var entity = FindEntityIfExists(customerShippingAddressId, false);
            return _mapper.Map<CustomerShippingAddressRes>(entity);
        }

        public CustomerShippingAddressRes? Update(int customerShippingAddressId, CustomerShippingAddressReqEdit dto)
        {
            var entity = FindEntityIfExists(customerShippingAddressId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<CustomerShippingAddressRes>(entity);
        }
    }
}
