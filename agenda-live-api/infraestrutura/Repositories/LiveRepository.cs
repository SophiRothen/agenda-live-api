using agenda_live_api.Domain.Models;

namespace agenda_live_api.infraestrutura.Repositories
{
    public class LiveRepository : ILiveRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Live live)
        {
            _context.Lives.Add(live);
            _context.SaveChanges();
        }

        public List<Live> Get()
        {
            return _context.Lives.ToList();   //depois fazer o dto talvez
        }

        public Live Get(int id)
        {
           return _context.Lives.Find(id);
        }
    }
}
