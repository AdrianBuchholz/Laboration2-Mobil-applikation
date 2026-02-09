using System.Threading.Tasks;
using MobilApplikation_Grupp_3.Models;
using MobilApplikation_Grupp_3.Repositories;
using MobilApplikation_Grupp_3.Data;

namespace MobilApplikation_Grupp_3.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IRepository<Concert> Concerts { get; }
        public IRepository<Performance> Performances { get; }
        public IRepository<Booking> Bookings { get; }
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Concerts = new Repository<Concert>(context);
            Performances = new Repository<Performance>(context);
            Bookings = new Repository<Booking>(context);
        }
        public async Task SaveAsync() =>
            await _context.SaveChangesAsync();
        
    }
}
