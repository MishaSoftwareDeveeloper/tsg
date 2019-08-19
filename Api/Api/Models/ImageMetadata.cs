using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class ImageMetadata
    {

        public int id { get; set; }
        public string name { get; set; }
        public EnumData.Sensor sensor { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public double ClipX { get; set; }
        public double ClipY { get; set; }
        public double ClipW { get; set; }
        public double ClipH { get; set; }

    }
}