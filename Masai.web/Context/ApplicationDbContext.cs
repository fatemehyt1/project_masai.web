using Microsoft.EntityFrameworkCore;

namespace Masai.web.Context;

public class ApplicationDbContext : DbContext
{
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

    
    
}

