using api.Dtos;

namespace api.Services.Interfaces
{
    public interface ICountryService
    {
        CountryRes? Get(int countryId);
        CountryRes? Create(CountryReqEdit dto);
        CountryRes? Update(int countryId, CountryReqEdit dto);
        void Delete(int countryId);
    }
}
