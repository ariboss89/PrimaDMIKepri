
using System;
using Microsoft.EntityFrameworkCore;

namespace PrimaDMIKepri.Data
{
	public class ApplicationDbContext:DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //public DbSet<Supplier> Suppliers { get; set; }
        //public DbSet<Kriteria> Kriterias { get; set; }
        //public DbSet<Subkriteria> Subkriterias { get; set; }
        //public DbSet<Penilaian> Penilaians { get; set; }
        //public DbSet<Pengguna> Penggunas { get; set; }
        //public DbSet<Config> Configs { get; set; }
        //public DbSet<Riwayat> Riwayats { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Pengguna>().HasData(

        //    new Pengguna()
        //    {
        //        Username = "kevin",
        //        Password = "pancarasa123",
        //        Role = "Superadmin"
        //    },

        //    new Pengguna()
        //    {
        //        Username = "admin",
        //        Password = "pancarasa123",
        //        Role = "Admin"
        //    });

        //    //    modelBuilder.Entity<Config>().HasData(
        //    //       new Config()
        //    //       {
        //    //           Id = 1,
        //    //           config_key = "Keputusan",
        //    //           config_value = 0
        //    //       });
        //    //}
        //}
    }
}

