using agenda_live_api.Domain.DTOs;
using agenda_live_api.Domain.Models;

namespace agenda_live_api.infraestrutura.Repositories
{
    public class LiveRepository : ILiveRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Post(LiveDTO live)
        {
            _context.Lives.Add(live);
            _context.SaveChanges();
        }

        public IEnumerable<LiveDTO> Get()
        {
            return _context.Lives.ToList();   
        }

        public LiveDTO GetId(int id)
        {
           return _context.Lives.Find(id);
        }
    }
}
