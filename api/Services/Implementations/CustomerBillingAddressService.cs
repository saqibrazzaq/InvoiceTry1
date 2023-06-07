using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class CustomerBillingAddressService : ICustomerBillingAddressService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public CustomerBillingAddressService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private CustomerBillingAddress FindEntityIfExists(int customerBillindAddressId, bool trakChanges)
        {
            var entity = _rep.CustomerBillingAddressRepository.FindByCondition(
                x => x.CustomerBillingAddressId == customerBillindAddressId,
                trakChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Customer Billing Address not found"); }

            return entity;
        }

        public CustomerBillingAddressRes? Create(CustomerBillingAddressReqEdit dto)
        {
            var entity = _mapper.Map<CustomerBillingAddress>(dto);
            _rep.CustomerBillingAddressRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<CustomerBillingAddressRes>(entity);
        }

        public void Delete(int customerBillindAddressId)
        {
            var entity = FindEntityIfExists(customerBillindAddressId, true);
            _rep.CustomerBillingAddressRepository.Delete(entity);
            _rep.Save();
        }

        public CustomerBillingAddressRes? Get(int customerBillindAddressId)
        {
            var entity = FindEntityIfExists(customerBillindAddressId, false);
            return _mapper.Map<CustomerBillingAddressRes> (entity);
        }

        public CustomerBillingAddressRes? Update(int customerBillindAddressId, CustomerBillingAddressReqEdit dto)
        {
            var entity = FindEntityIfExists(customerBillindAddressId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<CustomerBillingAddressRes>(entity);
        }
    }
}
