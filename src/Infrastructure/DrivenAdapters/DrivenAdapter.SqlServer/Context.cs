using Microsoft.EntityFrameworkCore;
using Soldaria.TemplateSolidaria.Domain.Model;

namespace Soldaria.TemplateSolidaria.DrivenAdapter.SqlServer;

public class Context : DbContext
{
    public Context()
    {
    }

    public Context(DbContextOptions options) : base(options)
    {
    }

    public virtual DbSet<User> User { get; set; }
}