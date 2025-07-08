using Microsoft.EntityFrameworkCore;
using studentattendanceapi.Models;

namespace studentattendanceapi.Data
{
    public class applicationdbcontext:DbContext
    {
        public applicationdbcontext(DbContextOptions<applicationdbcontext> options) : base(options) { } 

        public DbSet<student> students {  get; set; }
    }
}
