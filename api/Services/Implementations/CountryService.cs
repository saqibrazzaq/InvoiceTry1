using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class CountryService : ICountryService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public CountryService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private Country FindEntityIfExists(int countryId, bool trackChanges)
        {
            var entity = _rep.CountryRepository.FindByCondition(
                x => x.CountryId == countryId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Country not found"); }

            return entity;
        }

        public CountryRes? Create(CountryReqEdit dto)
        {
            var entity = _mapper.Map<Country>(dto);
            _rep.CountryRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<CountryRes>(entity);
        }

        public void Delete(int countryId)
        {
            var entity = FindEntityIfExists(countryId, true);
            _rep.CountryRepository.Delete(entity);
            _rep.Save();
        }

        public CountryRes? Get(int countryId)
        {
            var entity = FindEntityIfExists(countryId, false);
            return _mapper.Map<CountryRes>(entity);
        }

        public CountryRes? Update(int countryId, CountryReqEdit dto)
        {
            var entity = FindEntityIfExists(countryId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<CountryRes> (entity);
        }
    }
}
