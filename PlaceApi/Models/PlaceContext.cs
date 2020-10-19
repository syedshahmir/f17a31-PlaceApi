using Microsoft.EntityFrameworkCore;

namespace PlaceApi.Models
{
    public class PlaceContext : DbContext
    {
        public PlaceContext(DbContextOptions<PlaceContext> options)
            : base(options)
        {
        }

        public DbSet<Place> TodoItems { get; set; }
    }
}