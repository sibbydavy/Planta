using System;
using System.Collections.Generic;
using System.Text;

namespace PlantaModels
{
   public class FarmDetailModel
    {
        private Int32 _id;
        public Int32 ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private String _name;
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private List<CropDetailModel> _cropDetailModels;
        public List<CropDetailModel> CropDetailModels
        {
            get { return _cropDetailModels; }
            set { _cropDetailModels = value; }
        }
    }
}
