using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class SalesTaxRateService : ISalesTaxRateService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public SalesTaxRateService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private SalesTaxRate FindEntityIfExists(int salesTaxRateId, bool trackChanges)
        {
            var entity = _rep.SalesTaxRateRepository.FindByCondition(
                x => x.SalesTaxRateId == salesTaxRateId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Sales Tax rate not found"); }

            return entity;
        }

        public SalesTaxRateRes? Create(SalesTaxRateReqEdit dto)
        {
            var entity = _mapper.Map<SalesTaxRate>(dto);
            _rep.SalesTaxRateRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<SalesTaxRateRes>(entity);
        }

        public void Delete(int salesTaxRateId)
        {
            var entity = FindEntityIfExists(salesTaxRateId, true);
            _rep.SalesTaxRateRepository.Delete(entity);
            _rep.Save();
        }

        public SalesTaxRateRes? Get(int salesTaxRateId)
        {
            var entity = FindEntityIfExists(salesTaxRateId, false);
            return _mapper.Map<SalesTaxRateRes>(entity);
        }

        public SalesTaxRateRes? Update(int salesTaxRateId, SalesTaxRateReqEdit dto)
        {
            var entity = FindEntityIfExists(salesTaxRateId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<SalesTaxRateRes>(entity);
        }
    }
}
