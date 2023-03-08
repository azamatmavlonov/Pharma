using Microsoft.EntityFrameworkCore;
using Pharma.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharma.Infrastructure.Persistence.Database
{
    public class EFContext : DbContext
    {
        public DbSet<Medicament> Medicaments { get; set; } = null;
        public EFContext(DbContextOptions<EFContext> options) : base(options) 
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Ignore<EntityBase>();
            modelBuilder.Entity<Medicament>().HasData(
                new Medicament
                {
                    Id = 1,
                    Name = "Парацетамол",
                    Type = "Неизвестный",
                    Category = "Взрослый",
                    Form = "Таблетка",
                    Volume = 5,
                    ProductionData = "01/03/2023",
                    ShelfLife = 30,
                    Producer = "Berlin-Chemie",
                    Price = 2.50,
                    IsActive = true,
                    WithPrescription = true,
                    Description = "Против головной боли"
                },
                new Medicament
                {
                    Id = 2,
                    Name = "Тримол",
                    Type = "Неизвестный",
                    Category = "Взрослый",
                    Form = "Таблетка",
                    Volume = 5,
                    ProductionData = "01/03/2023",
                    ShelfLife = 30,
                    Producer = "Berlin-Chemie",
                    Price = 1.50,
                    IsActive = true,
                    WithPrescription = true,
                    Description = "Снижает температуру"
                });
        }
    }
}
