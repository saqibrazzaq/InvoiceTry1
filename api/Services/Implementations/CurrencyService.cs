using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class CurrencyService : ICurrencyService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public CurrencyService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private Currency FindEntityIfExists(int currencyId, bool trackChanges)
        {
            var entity = _rep.CurrencyRepository.FindByCondition(
                x => x.CurrencyId == currencyId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Currency not found"); }

            return entity;
        }

        public CurrencyRes? Create(CurrencyReqEdit dto)
        {
            var entity = _mapper.Map<Currency>(dto);
            _rep.CurrencyRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<CurrencyRes>(entity);
        }

        public void Delete(int currencyId)
        {
            var entity = FindEntityIfExists(currencyId, true);
            _rep.CurrencyRepository.Delete(entity);
            _rep.Save();
        }

        public CurrencyRes? Get(int currencyId)
        {
            var entity = FindEntityIfExists(currencyId, false);
            return _mapper.Map<CurrencyRes> (entity);
        }

        public CurrencyRes? Update(int currencyId, CurrencyReqEdit dto)
        {
            var entity = FindEntityIfExists (currencyId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<CurrencyRes>(entity);
        }
    }
}
