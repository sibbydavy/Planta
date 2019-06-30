using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planta.Models
{
    public class FarmModel : ModelBase
    {
        public string Name { get; set; }

        public List<CropModel> CropDetails { get; set; }
       // public List<User> Partners { get; set; }

        //public Location FarmLocation { get; set; }

       // public LocationAddress FarmLocationAddress { get; set; }
    }
}
