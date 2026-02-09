using System.Threading.Tasks;
using MobilApplikation_Grupp_3.Repositories;
using MobilApplikation_Grupp_3.Models;

namespace MobilApplikation_Grupp_3.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<Concert> Concerts { get; }
        IRepository<Performance> Performances { get; }
        IRepository<Booking> Bookings { get; }
        Task SaveAsync();
    }
}
