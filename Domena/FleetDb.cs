using Domena.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domena
{
    // ORM - Object Relation Mapper
    // Code First
    public class FleetDb:DbContext
    {
        
        public FleetDb()
        {
            
        }

        public FleetDb(DbContextOptions<FleetDb> options):base(options)
        {

        }

        // 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            { 
                optionsBuilder.UseNpgsql("User ID =postgres;Password=\"123\";Server=127.0.0.1;Port=5432;Database=Fleet;");
            }
        }

        // 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vehicle>().HasIndex(b => b.PlateNumber).IsUnique();

            // 1:wielu - nie musimy nic więcej konfigurować

            // 1:1
            modelBuilder.Entity<Driver>()
                .HasOne(a => a.License)
                .WithOne(b => b.Driver)
                .HasForeignKey<License>(b => b.DriverId);


            // wiele:wielu
            modelBuilder.Entity<CustomersPermamentJob>()
                .HasKey(bc => new { bc.CustomerId, bc.JobId });

            modelBuilder.Entity<CustomersPermamentJob>()
                .HasOne(bc => bc.Customer)
                .WithMany(b => b.Jobs)
                .HasForeignKey(bc => bc.CustomerId);

            modelBuilder.Entity<CustomersPermamentJob>()
                .HasOne(bc => bc.Job)
                .WithMany(b => b.Customers)
                .HasForeignKey(bc => bc.JobId);


            // Drivers x Vehicles - wiele:wielu
            modelBuilder.Entity<DriverVehicleAssingment>()
              .HasKey(bc => new { bc.DriverId, bc.VehicleId });

            modelBuilder.Entity<DriverVehicleAssingment>()
                .HasOne(bc => bc.Vehicle)
                .WithMany(b => b.Drivers)
                .HasForeignKey(bc => bc.VehicleId);

            modelBuilder.Entity<DriverVehicleAssingment>()
                .HasOne(bc => bc.Driver)
                .WithMany(b => b.Vehicles)
                .HasForeignKey(bc => bc.DriverId);





            this.SeedBaseData(modelBuilder);
        }


        public virtual DbSet<Driver> Drivers { get; set; }
        //public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<VehicleType> VehicleTypes { get; set; }
        public virtual DbSet<License> Licenses{ get; set; }
        public virtual DbSet<CustomersPermamentJob> CustomersPermamentJobs{ get; set; }
        public virtual DbSet<PermamentJob> PermamentJobs { get; set; }
        public virtual DbSet<DriverVehicleAssingment> DriverVehicleAssingments { get; set; }
        public virtual DbSet<Fuel> Fuel { get; set; }
        public virtual DbSet<Tire> Tires { get; set; }
        public virtual DbSet<Issue> Issues { get; set; }

        private void SeedBaseData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleType>().HasData(new VehicleType[]
            {
                new VehicleType
                {
                    Id = 1,
                    Name = "Ciężarówka"
                },
                new VehicleType
                {
                    Id = 2,
                    Name = "Osobowy"
                }
            });

            modelBuilder.Entity<UserType>().HasData(new UserType[]
            {
                new UserType
                {
                    Id = 1,
                    Name = "User"
                },
                new UserType
                {
                    Id = 2,
                    Name = "Admin"
                }
            });

        }
    }
}
