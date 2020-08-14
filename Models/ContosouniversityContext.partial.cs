using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace hw.Models
{
    public partial class ContosouniversityContext
    {
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSaving();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
           CancellationToken cancellationToken = default(CancellationToken)
        )
        {
            OnBeforeSaving();
            return (await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken));
        }

        private void OnBeforeSaving()
        {
            var entries = ChangeTracker.Entries();
            var utcNow = DateTime.UtcNow;
            dynamic entity = null;
            foreach (var entry in entries)
            {
                entity = entry.Entity;
                if (entity is Course || // If these class is inherited from the same interface, then this will be simpler.
                    entity is Department ||
                    entity is Person)
                {
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                        case EntityState.Added:
                            entity.DateModified = utcNow;
                            break;
                        case EntityState.Deleted:
                            entry.State = EntityState.Modified;
                            entity.IsDeleted = true;
                            break;
                    }
                }
            }
        }
    }
}
