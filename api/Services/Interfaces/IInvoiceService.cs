using api.Dtos;

namespace api.Services.Interfaces
{
    public interface IInvoiceService
    {
        InvoiceRes? Get(int invoiceId);
        InvoiceRes? Create(InvoiceReqEdit dto);
        InvoiceRes? Update(int invoiecId, InvoiceReqEdit dto);
        void Delete(int invoiceId);
    }
}
