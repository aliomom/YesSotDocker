using Data.Entity;
using System.Threading;
using System.Threading.Tasks;

namespace infra.UnitOfWork
{
   public interface IUnitOfWork
    {
        IRepository<User> UserRepository { get; }

        void Dispose();
        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}