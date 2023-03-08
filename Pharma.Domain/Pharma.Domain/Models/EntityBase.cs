using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pharma.Domain.Models
{
    public class EntityBase
    {
        [JsonIgnore]
        public ulong Id { get; set; }
    }
}
