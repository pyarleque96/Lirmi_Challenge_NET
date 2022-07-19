using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Lirmi.Challenge.Data.Context
{
    public partial class LirmiContext
    {
        public LirmiContext(DbContextOptions<LirmiContext> options, IConfiguration configuration)
            : base(options, configuration)
        {
        }
    }
}
