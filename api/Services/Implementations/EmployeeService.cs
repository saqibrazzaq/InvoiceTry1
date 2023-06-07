using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public EmployeeService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private Employee FindEntityIfExists(int employeeId, bool trackChanges)
        {
            var entity = _rep.EmployeeRepository.FindByCondition(
                x => x.EmployeeId == employeeId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Employee not found"); }

            return entity;
        }

        public EmployeeRes? Create(EmployeeReqEdit dto)
        {
            var entity = _mapper.Map<Employee> (dto);
            _rep.EmployeeRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<EmployeeRes>(entity);
        }

        public void Delete(int employeeId)
        {
            var entity = FindEntityIfExists(employeeId, true);
            _rep.EmployeeRepository.Delete(entity);
            _rep.Save();
        }

        public EmployeeRes? Get(int employeeId)
        {
            var entity = FindEntityIfExists(employeeId, false);
            return _mapper.Map<EmployeeRes>(entity);
        }

        public EmployeeRes? Update(int employeeId, EmployeeReqEdit dto)
        {
            var entity = FindEntityIfExists (employeeId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<EmployeeRes>(entity);
        }
    }
}
