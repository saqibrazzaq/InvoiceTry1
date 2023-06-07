using api.Dtos;

namespace api.Services.Interfaces
{
    public interface IInvoiceItemService
    {
        InvoiceItemRes? Get(int invoiceItemId);
        InvoiceItemRes? Create(InvoiceItemReqEdit dto);
        InvoiceItemRes? Update(int invoiceItemId, InvoiceItemReqEdit dto);
        void Delete(int invoiceItemId);
    }
}
