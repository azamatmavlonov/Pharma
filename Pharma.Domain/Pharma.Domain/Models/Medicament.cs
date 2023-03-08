using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharma.Domain.Models
{
    public class Medicament : EntityBase
    {
        public string Name { get; set; } = "";
        public string Type { get; set; }
        public string Form { get; set; }
        public string Category { get; set; }
        public int Volume { get; set; }
        public DateOnly ProductionData { get; set; }
        public int ShelfLife { get; set; }
        public string Producer { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public bool WithPrescription { get; set; }
        public string? Description { get; set; }
    }
}
