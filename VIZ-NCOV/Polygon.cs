using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIZ_NCOV
{
    public class PointD
    {
        public double lat;
        public double lng;
        public PointD(double latitude, double longitude)
        {
            this.lat = latitude;
            this.lng = longitude;
        }
    }
    public class Polygon
    {
        public List<PointD> polygonPoints = new List<PointD>();
        public void AddPoint(PointD point)
        {
            polygonPoints.Add(point);
        }
    }
}
