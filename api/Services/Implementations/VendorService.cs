using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class VendorService : IVendorService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public VendorService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private Vendor FindEntityIfExists(int vendorId, bool trackChanges)
        {
            var entity = _rep.VendorRepository.FindByCondition(
                x => x.VendorId == vendorId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Vendor not found"); }

            return entity;
        }

        public VendorRes? Create(VendorReqEdit dto)
        {
            var entity = _mapper.Map<Vendor>(dto);
            _rep.VendorRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<VendorRes>(entity);
        }

        public void Delete(int vendorId)
        {
            var entity = FindEntityIfExists(vendorId, true);
            _rep.VendorRepository.Delete(entity);
            _rep.Save();
        }

        public VendorRes? Get(int vendorId)
        {
            var entity = FindEntityIfExists(vendorId, false);
            return _mapper.Map<VendorRes>(entity);
        }

        public VendorRes? Update(int vendorId, VendorReqEdit dto)
        {
            var entity = FindEntityIfExists(vendorId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<VendorRes>(entity);
        }
    }
}
