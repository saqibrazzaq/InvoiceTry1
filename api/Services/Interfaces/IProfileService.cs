using api.Dtos;

namespace api.Services.Interfaces
{
    public interface IProfileService
    {
        ProfileRes? Get(int profileId);
        ProfileRes? Create(ProfileReqEdit dto);
        ProfileRes? Update(int profileId, ProfileReqEdit dto);
        void Delete(int profileId);
    }
}
