using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class DesignationService : IDesignationService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public DesignationService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private Designation FindEntityIfExists(int designationId, bool trackChanges)
        {
            var entity = _rep.DesignationRepository.FindByCondition(
                x => x.DesignationId == designationId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Designation not found"); }

            return entity;
        }

        public DesignationRes? Create(DesignationReqEdit dto)
        {
            var entity = _mapper.Map<Designation>(dto);
            _rep.DesignationRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<DesignationRes>(entity);
        }

        public void Delete(int designationId)
        {
            var entity = FindEntityIfExists(designationId, true);
            _rep.DesignationRepository.Delete(entity);
            _rep.Save();
        }

        public DesignationRes? Get(int designationId)
        {
            var entity = FindEntityIfExists(designationId, false);
            return _mapper.Map<DesignationRes>(entity);
        }

        public DesignationRes? Update(int designationId, DesignationReqEdit dto)
        {
            var entity = FindEntityIfExists(designationId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<DesignationRes>(entity);
        }
    }
}
