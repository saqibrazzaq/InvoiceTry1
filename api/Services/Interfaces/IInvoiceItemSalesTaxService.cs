using api.Dtos;

namespace api.Services.Interfaces
{
    public interface IInvoiceItemSalesTaxService
    {
        InvoiceItemSalesTaxRes? Get(int invoiceItemSalesTaxId);
        InvoiceItemSalesTaxRes? Create(InvoiceItemSalesTaxReqEdit dto);
        InvoiceItemSalesTaxRes? Update(int invoiceItemSalesTaxId, InvoiceItemSalesTaxReqEdit dto);
        void Delete(int invoiceItemSalesTaxId);
    }
}
