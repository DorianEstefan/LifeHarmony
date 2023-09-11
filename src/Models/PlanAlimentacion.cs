using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeHarmony.src.Models
{
    public class PlanAlimentacion
    {
        public string? Id { get; set; } = null!;
        public string? nombre { get; set; }
        public string? recomendacion { get; set; }
        public List<string>? alimentos{ get; set; }
        public List<string>? restricciones { get; set; }
        public int status { get; set; }
    }
}
