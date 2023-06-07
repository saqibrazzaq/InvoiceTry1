using api.Dtos;
using api.Entities;
using api.Repositories.Interfaces;
using api.Services.Interfaces;
using AutoMapper;

namespace api.Services.Implementations
{
    public class ProfileService : IProfileService
    {
        private readonly IRepositoryManager _rep;
        private readonly IMapper _mapper;
        public ProfileService(IRepositoryManager rep, 
            IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        private Entities.Profile FindEntityIfExists(int profileId, bool trackChanges)
        {
            var entity = _rep.ProfileRepository.FindByCondition(
                x => x.ProfileId == profileId,
                trackChanges)
                .FirstOrDefault();
            if (entity == null) { throw new Exception("Profile not found"); }

            return entity;
        }

        public ProfileRes? Create(ProfileReqEdit dto)
        {
            var entity = _mapper.Map<Entities.Profile>(dto);
            _rep.ProfileRepository.Create(entity);
            _rep.Save();
            return _mapper.Map<ProfileRes>(entity);
        }

        public void Delete(int profileId)
        {
            var entity = FindEntityIfExists(profileId, true);
            _rep.ProfileRepository.Delete(entity);
            _rep.Save();
        }

        public ProfileRes? Get(int profileId)
        {
            var entity = FindEntityIfExists(profileId, false);
            return _mapper.Map<ProfileRes>(entity);
        }

        public ProfileRes? Update(int profileId, ProfileReqEdit dto)
        {
            var entity = FindEntityIfExists(profileId, true);
            _mapper.Map(dto, entity);
            _rep.Save();
            return _mapper.Map<ProfileRes>(entity);
        }
    }
}
