using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public CustomerService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private Customer FindEntityIfExists(int customerId, bool trackChanges)
        {
            var entity = _rep.CustomerRepository.FindByCondition(
                x => x.CustomerId == customerId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Customer not found"); }

            return entity;
        }

        public CustomerRes? Create(CustomerReqEdit dto)
        {
            var entity = _mapper.Map<Customer>(dto);
            _rep.CustomerRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<CustomerRes>(entity);
        }

        public void Delete(int customerId)
        {
            var entity = FindEntityIfExists(customerId, true);
            _rep.CustomerRepository.Delete(entity);
            _rep.Save();
        }

        public CustomerRes? Get(int customerId)
        {
            var entity = FindEntityIfExists(customerId, false);
            return _mapper.Map<CustomerRes>(entity);
        }

        public CustomerRes? Update(int customerId, CustomerReqEdit dto)
        {
            var entity = FindEntityIfExists(customerId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<CustomerRes> (entity);
        }
    }
}
