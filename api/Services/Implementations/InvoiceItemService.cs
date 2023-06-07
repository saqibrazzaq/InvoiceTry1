using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;
using System.Diagnostics.Eventing.Reader;

namespace api.Services.Implementations
{
    public class InvoiceItemService : IInvoiceItemService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public InvoiceItemService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private InvoiceItem FindEntityIfExists(int invoiceItemId, bool trackChanges)
        {
            var entity = _rep.InvoiceItemRepository.FindByCondition(
                x => x.InvoiceItemId == invoiceItemId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Invoice item not found"); }

            return entity;
        }

        public InvoiceItemRes? Create(InvoiceItemReqEdit dto)
        {
            var entity = _mapper.Map<InvoiceItem> (dto);
            _rep.InvoiceItemRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<InvoiceItemRes>(entity);
        }

        public void Delete(int invoiceItemId)
        {
            var entity = FindEntityIfExists(invoiceItemId, true);
            _rep.InvoiceItemRepository.Delete(entity);
            _rep.Save();
        }

        public InvoiceItemRes? Get(int invoiceItemId)
        {
            var entity = FindEntityIfExists(invoiceItemId, false);
            return _mapper.Map<InvoiceItemRes>(entity);
        }

        public InvoiceItemRes? Update(int invoiceItemId, InvoiceItemReqEdit dto)
        {
            var entity = FindEntityIfExists (invoiceItemId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<InvoiceItemRes>(entity);
        }
    }
}
