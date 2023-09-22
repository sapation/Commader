
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> options) : base(options)
        {

        }
        public DbSet<Command> Commands { get; set; }
    }
}