using Newtonsoft.Json;
using System;

namespace IndoorLocation.Models
{
    public class Coordinates
    {
        public double x { get; set; }
        public double y { get; set; }

        public Coordinates() { }
        public Coordinates(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static string ConvertToJsonString(Coordinates point)
        {
            return JsonConvert.SerializeObject(point);
        }

        public static double Distance(Coordinates p1, Coordinates p2)
        {
            return Math.Sqrt((p1.x - p2.x) * (p1.x - p2.x) + (p1.y - p2.y) * (p1.y - p2.y));
        }
    }
}
