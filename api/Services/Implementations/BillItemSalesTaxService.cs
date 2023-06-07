using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class BillItemSalesTaxService : IBillItemSalesTaxService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public BillItemSalesTaxService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private BillItemSalesTax FindEntityIfExists(int billItemSalesTaxId, bool trackChanges)
        {
            var entity = _rep.BillItemSalesTaxRepository.FindByCondition(
                x => x.BillItemSalesTaxId == billItemSalesTaxId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Bill Item Sales Tax not found"); }

            return entity;
        }

        public BillItemSalesTaxRes? Create(BillItemSalesTaxReqEdit dto)
        {
            var entity = _mapper.Map<BillItemSalesTax>(dto);
            _rep.BillItemSalesTaxRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<BillItemSalesTaxRes>(entity);
        }

        public void Delete(int billItemSalesTaxId)
        {
            var entity = FindEntityIfExists(billItemSalesTaxId, true);
            _rep.BillItemSalesTaxRepository.Delete(entity);
            _rep.Save();
        }

        public BillItemSalesTaxRes? Get(int billItemSalesTaxId)
        {
            var entity = FindEntityIfExists(billItemSalesTaxId, false);
            return _mapper.Map<BillItemSalesTaxRes>(entity);
        }

        public BillItemSalesTaxRes? Update(int billItemSalesTaxId, BillItemSalesTaxReqEdit dto)
        {
            var entity = FindEntityIfExists(billItemSalesTaxId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<BillItemSalesTaxRes>(entity);
        }
    }
}
