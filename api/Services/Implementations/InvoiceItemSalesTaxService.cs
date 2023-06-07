using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class InvoiceItemSalesTaxService : IInvoiceItemSalesTaxService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public InvoiceItemSalesTaxService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private InvoiceItemSalesTax FindEntityIfExists(int invoiceItemSalesTaxId, bool trackChanges)
        {
            var entity = _rep.InvoiceItemSalesTaxRepository.FindByCondition(
                x => x.InvoiceItemSalesTaxId == invoiceItemSalesTaxId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Invoice item sales tax not found"); }

            return entity;
        }

        public InvoiceItemSalesTaxRes? Create(InvoiceItemSalesTaxReqEdit dto)
        {
            var entity = _mapper.Map<InvoiceItemSalesTax>(dto);
            _rep.InvoiceItemSalesTaxRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<InvoiceItemSalesTaxRes>(entity);
        }

        public void Delete(int invoiceItemSalesTaxId)
        {
            var entity = FindEntityIfExists(invoiceItemSalesTaxId, true);
            _rep.InvoiceItemSalesTaxRepository.Delete(entity);
            _rep.Save();
        }

        public InvoiceItemSalesTaxRes? Get(int invoiceItemSalesTaxId)
        {
            var entity = FindEntityIfExists(invoiceItemSalesTaxId, false);
            return _mapper.Map<InvoiceItemSalesTaxRes>(entity);
        }

        public InvoiceItemSalesTaxRes? Update(int invoiceItemSalesTaxId, InvoiceItemSalesTaxReqEdit dto)
        {
            var entity = FindEntityIfExists(invoiceItemSalesTaxId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<InvoiceItemSalesTaxRes>(entity);
        }
    }
}
