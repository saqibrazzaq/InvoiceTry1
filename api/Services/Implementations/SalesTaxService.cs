using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class SalesTaxService : ISalesTaxService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public SalesTaxService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private SalesTax FindEntityIfExists(int salesTaxId, bool trackChanges)
        {
            var entity = _rep.SalesTaxRepository.FindByCondition(
                x => x.SalesTaxId == salesTaxId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Sales Tax not found"); }

            return entity;
        }

        public SalesTaxRes? Create(SalesTaxReqEdit dto)
        {
            var entity = _mapper.Map<SalesTax> (dto);
            _rep.SalesTaxRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<SalesTaxRes>(entity);
        }

        public void Delete(int salesTaxId)
        {
            var entity = FindEntityIfExists(salesTaxId, false);
            _rep.SalesTaxRepository.Delete(entity);
            _rep.Save();
        }

        public SalesTaxRes? Get(int salesTaxId)
        {
            var entity = FindEntityIfExists (salesTaxId, false);
            return _mapper.Map<SalesTaxRes>(entity);
        }

        public SalesTaxRes? Update(int salesTaxId, SalesTaxReqEdit dto)
        {
            var entity = FindEntityIfExists(salesTaxId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<SalesTaxRes>(entity);
        }
    }
}
