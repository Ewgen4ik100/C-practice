using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab31
{
    public class AppConfig : DbContext
    {
        public DbSet<Students> Students { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Diszipline> Disziplines { get; set; }
        public AppConfig()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\manic\\Desktop\\КПЯП\\КПЯП\\КПиЯП\\Lab31\\Lab31\\Lab31\\Database1.mdf;Integrated Security=True");
        }
    }

}
