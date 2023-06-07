using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class BusinessService : IBusinessService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public BusinessService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private Business FindEntityIfExists(int businessId, bool trackChanges)
        {
            var entity = _rep.BusinessRepository.FindByCondition(
                x => x.BusinessId == businessId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Business not found"); }

            return entity;
        }

        public BusinessRes? Create(BusinessReqEdit dto)
        {
            var entity = _mapper.Map<Business>(dto);
            _rep.BusinessRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<BusinessRes>(entity);
        }

        public void Delete(int businessId)
        {
            var entity = FindEntityIfExists(businessId, true);
            _rep.BusinessRepository.Delete(entity);
            _rep.Save();
        }

        public BusinessRes? Get(int businessId)
        {
            var entity = FindEntityIfExists(businessId, false);
            return _mapper.Map<BusinessRes>(entity);
        }

        public BusinessRes? Update(int businessId, BusinessReqEdit dto)
        {
            var entity = FindEntityIfExists(businessId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<BusinessRes> (entity);
        }
    }
}
