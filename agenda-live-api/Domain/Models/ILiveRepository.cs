namespace agenda_live_api.Domain.Models
{
    public interface ILiveRepository
    {
        void Add(Live live);

        List<Live> Get();

        Live Get (int id);
    }
}
