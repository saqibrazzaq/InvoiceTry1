using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public DepartmentService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private Department FindEntityIfExists(int departmentId, bool trackChanges)
        {
            var entity = _rep.DepartmentRepository.FindByCondition(
                x => x.DepartmentId == departmentId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Department not found"); }

            return entity;
        }

        public DepartmentRes? Create(DepartmentReqEdit dto)
        {
            var entity = _mapper.Map<Department>(dto);
            _rep.DepartmentRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<DepartmentRes>(entity);
        }

        public void Delete(int departmentId)
        {
            var entity = FindEntityIfExists(departmentId, true);
            _rep.DepartmentRepository.Delete(entity);
            _rep.Save();
        }

        public DepartmentRes? Get(int departmentId)
        {
            var entity = FindEntityIfExists(departmentId, false);
            return _mapper.Map<DepartmentRes>(entity);
        }

        public DepartmentRes? Update(int departmentId, DepartmentReqEdit dto)
        {
            var entity = FindEntityIfExists(departmentId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<DepartmentRes>(entity);
        }
    }
}
