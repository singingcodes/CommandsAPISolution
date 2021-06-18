using Microsoft.EntityFrameworkCore;
using CommandAPILibrary.Models;

namespace CommandAPI.Data
{
    public class CommandContext:DbContext
    {
        

        // public CommandContext(DbContextOptions options):base(options)
        // {

        // }
        public CommandContext(DbContextOptions<CommandContext> options): base(options)
        {

        }
        public DbSet<Command> CommandItems { get; set; }
    }
}