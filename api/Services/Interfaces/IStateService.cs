using api.Dtos;

namespace api.Services.Interfaces
{
    public interface IStateService
    {
        StateRes? Get(int stateId);
        StateRes? Create(StateReqEdit dto);
        StateRes? Update(int stateId, StateReqEdit dto);
        void Delete(int stateId);
    }
}
