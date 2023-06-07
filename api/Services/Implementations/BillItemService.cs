using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class BillItemService : IBillItemService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public BillItemService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private BillItem FindBillItemIfExists(int billItemId, bool trackChanges)
        {
            var entity = _rep.BillItemRepository.FindByCondition(
                x => x.BillItemId == billItemId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Bill Item not found."); }

            return entity;
        }

        public BillItemRes? Create(BillItemReqEdit dto)
        {
            var entity = _mapper.Map<BillItem> (dto);
            _rep.BillItemRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<BillItemRes>(entity);
        }

        public void Delete(int billItemId)
        {
            var entity = FindBillItemIfExists(billItemId, true);
            _rep.BillItemRepository.Delete(entity);
            _rep.Save();
        }

        public BillItemRes? Get(int billItemId)
        {
            var entity = FindBillItemIfExists (billItemId, false);
            return _mapper.Map<BillItemRes> (entity);
        }

        public BillItemRes? Update(int billItemId, BillItemReqEdit dto)
        {
            var entity = FindBillItemIfExists(billItemId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<BillItemRes>(entity);
        }
    }
}
