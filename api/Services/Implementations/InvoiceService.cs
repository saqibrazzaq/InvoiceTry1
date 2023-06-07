using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public InvoiceService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private Invoice FindEntityIfExists(int invoiceId, bool trackchanges)
        {
            var entity = _rep.InvoiceRepository.FindByCondition(
                x => x.InvoiceId == invoiceId,
                trackchanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Invoice not found"); }

            return entity;
        }

        public InvoiceRes? Create(InvoiceReqEdit dto)
        {
            var entity = _mapper.Map<Invoice> (dto);
            _rep.InvoiceRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<InvoiceRes> (entity);
        }

        public void Delete(int invoiceId)
        {
            var entity = FindEntityIfExists(invoiceId, true);
            _rep.InvoiceRepository.Delete(entity);
            _rep.Save();
        }

        public InvoiceRes? Get(int invoiceId)
        {
            var entity = FindEntityIfExists(invoiceId, false);
            return _mapper.Map<InvoiceRes>(entity);
        }

        public InvoiceRes? Update(int invoiecId, InvoiceReqEdit dto)
        {
            var entity = FindEntityIfExists(invoiecId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<InvoiceRes>(entity);
        }
    }
}
