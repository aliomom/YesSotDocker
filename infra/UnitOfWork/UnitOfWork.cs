using Data;
using Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace infra.UnitOfWork
{
   public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork()
        {
            _context = new ApplicationDbContext();

        }
        

        private IRepository<User> _UserRepository;
        public IRepository<User> UserRepository
        {
            get { return _UserRepository ?? (_UserRepository = new Repository<User>(_context)); }

        }



        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }


        #region IDisposable Members
        public void Dispose()
        {

            _context.Dispose();
        }
        #endregion

    }
}
