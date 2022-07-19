using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;

namespace Lirmi.Challenge.Data.Context.Core
{
    public class BaseContext : DbContext
    {
        private readonly IConfiguration _config;

        public BaseContext()
        {
        }

        public BaseContext(DbContextOptions options) : base(options)
        {
        }

        public BaseContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        public override int SaveChanges()
        {
            AuditEntities();

            return base.SaveChanges();
        }

        private void AuditEntities()
        {
            var currentDateTime = DateTime.Now;

            foreach (var entry in ChangeTracker.Entries())
            {
                const StringComparison currentCultureIgnoreCase = StringComparison.CurrentCultureIgnoreCase;

                if (entry.State == EntityState.Added)
                {
                    if (entry.Properties.Any(p => string.Equals(p.Metadata.Name, "CreatedDate", currentCultureIgnoreCase)))
                        entry.Property("CreatedDate").CurrentValue = currentDateTime;
                }

                if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
                {
                    if (entry.Properties.Any(p => string.Equals(p.Metadata.Name, "UpdatedDate", currentCultureIgnoreCase)))
                        entry.Property("UpdatedDate").CurrentValue = currentDateTime;
                }
            }
        }
    }
}
