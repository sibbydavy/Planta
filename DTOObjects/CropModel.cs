using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planta.Models
{
    public class CropModel : ModelBase
    {
        public string Name { get; set; }

        public List<YieldModel> YieldDetails { get; set; }
    }
}
