using api.Dtos;

namespace api.Services.Interfaces
{
    public interface ICurrencyService
    {
        CurrencyRes? Get(int currencyId);
        CurrencyRes? Create(CurrencyReqEdit dto);
        CurrencyRes? Update(int currencyId, CurrencyReqEdit dto);
        void Delete(int currencyId);
    }
}
