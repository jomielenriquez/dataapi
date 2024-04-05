namespace dataapi.Model
{
    using Microsoft.EntityFrameworkCore;
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public virtual DbSet<TBL_DISPENSELOG> TBL_DISPENSELOG { get; set; }
    }
}
