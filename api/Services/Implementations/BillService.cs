using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class BillService : IBillService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public BillService(IRepositoryManager r, 
            IMapper mapper)
        {
            _rep = r;
            _mapper = mapper;
        }

        private Bill FindBillIfExists(int billId, bool trackChanges)
        {
            var entity = _rep.BillRepository.FindByCondition(
                x => x.BillId == billId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Bill not found."); }

            return entity;
        }

        public BillRes? Create(BillReqEdit dto)
        {
            var entity = _mapper.Map<Bill>(dto);
            _rep.BillRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<BillRes>(entity);
        }

        public void Delete(int billId)
        {
            var entity = FindBillIfExists(billId, true);
            _rep.BillRepository.Delete(entity);
        }

        public BillRes? Get(int billId)
        {
            var entity = FindBillIfExists(billId, false);
            return _mapper.Map<BillRes>(entity);
        }

        public BillRes? Update(int billId, BillReqEdit dto)
        {
            var entity = FindBillIfExists(billId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<BillRes> (entity);
        }
    }
}
