using agenda_live_api.Domain.DTOs;

namespace agenda_live_api.Domain.Models
{
    public interface ILiveRepository
    {
        void Post(LiveDTO live);

        IEnumerable<LiveDTO> Get();

        LiveDTO GetId(int id);
    }
}
