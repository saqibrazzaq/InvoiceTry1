using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class StateService : IStateService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public StateService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private State FindEntityIfExists(int stateId, bool trackChanges)
        {
            var entity = _rep.StateRepository.FindByCondition(
                x => x.StateId == stateId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("State not found"); }

            return entity;
        }

        public StateRes? Create(StateReqEdit dto)
        {
            var entity = _mapper.Map<State>(dto);
            _rep.StateRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<StateRes>(entity);
        }

        public void Delete(int stateId)
        {
            var entity = FindEntityIfExists(stateId, true);
            _rep.StateRepository.Delete(entity);
            _rep.Save();
        }

        public StateRes? Get(int stateId)
        {
            var entity = FindEntityIfExists(stateId, false);
            return _mapper.Map<StateRes>(entity);
        }

        public StateRes? Update(int stateId, StateReqEdit dto)
        {
            var entity = FindEntityIfExists(stateId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<StateRes>(entity);
        }
    }
}
