using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class CustomerContactService : ICustomerContactService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public CustomerContactService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private CustomerContact FindEntityIfExists(int customerContactId, bool trackChanges)
        {
            var entity = _rep.CustomerContactRepository.FindByCondition(
                x => x.CustomerContactId == customerContactId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Customer Contact not found"); }

            return entity;
        }

        public CustomerContactRes? Create(CustomerContactReqEdit dto)
        {
            var entity = _mapper.Map<CustomerContact>(dto);
            _rep.CustomerContactRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<CustomerContactRes>(entity);
        }

        public void Delete(int customerContactId)
        {
            var entity = FindEntityIfExists(customerContactId, true);
            _rep.CustomerContactRepository.Delete(entity);
            _rep.Save();
        }

        public CustomerContactRes? Get(int customerContactId)
        {
            var entity = FindEntityIfExists(customerContactId, false);
            return _mapper.Map<CustomerContactRes> (entity);
        }

        public CustomerContactRes? Update(int customerContactId, CustomerContactReqEdit dto)
        {
            var entity = FindEntityIfExists(customerContactId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<CustomerContactRes>(entity);
        }
    }
}
