using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIZ_NCOV
{
    public static class HelperFunctions
    {

        public static bool IsConnectedToInternet() => System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        static readonly Random rnd = new Random();

        public static PointF CoordinateToPoint(PointD point, Size box)
        {
            var x = (float)((point.lng + 180) * (box.Width / 360));
            var latRad = point.lat * Math.PI / 180;
            var mercN = Math.Log(Math.Tan((Math.PI / 4) + (latRad / 2)));
            var y = (float)((box.Height / 2) - (box.Width * mercN / (2 * Math.PI)));

            return new PointF((float)Math.Max(0, Math.Min(x, box.Width)), (float)Math.Max(0, Math.Min(y, box.Height)));
        }
        public static List<PointF> PolygonToImagePoly(Polygon poly, Size box)
        {
            List<PointF> points = new List<PointF>();
            poly.polygonPoints.ForEach((point) => points.Add(CoordinateToPoint(point, box)));
            return points;
        }
        public static bool IsPointInPolygon(Polygon polygon, PointF testPoint, Size box)
        {
            bool result = false;
            int j = polygon.polygonPoints.Count() - 1;
            for (int i = 0; i < polygon.polygonPoints.Count(); i++)
            {
                PointF leftPoint = HelperFunctions.CoordinateToPoint(polygon.polygonPoints[i], box);
                PointF rightPoint = HelperFunctions.CoordinateToPoint(polygon.polygonPoints[j], box);
                if (leftPoint.Y < testPoint.Y && rightPoint.Y >= testPoint.Y || rightPoint.Y < testPoint.Y && leftPoint.Y >= testPoint.Y)
                {
                    if (leftPoint.X + (testPoint.Y - leftPoint.Y) / (rightPoint.Y - leftPoint.Y) * (rightPoint.X - leftPoint.X) < testPoint.X)
                    {
                        result = !result;
                    }
                }
                j = i;
            }
            return result;
        }
        public static List<string> SplitCsv(string line)
        {
            List<string> result = new List<string>();
            StringBuilder currentStr = new StringBuilder("");
            bool inQuotes = false;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '\"')
                    inQuotes = !inQuotes;
                else if (line[i] == ',')
                {
                    if (!inQuotes)
                    {
                        result.Add(currentStr.ToString());
                        currentStr.Clear();
                    }
                    else
                        currentStr.Append(line[i]);
                }
                else
                    currentStr.Append(line[i]);
            }
            result.Add(currentStr.ToString());
            return result;
        }
        public static Color GetRandomColor()
        {
            return Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
        }
    }
}
