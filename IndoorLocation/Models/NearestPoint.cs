namespace IndoorLocation.Models
{
    public class NearestPoint
    {
        public int Index { get; set; }
        public Coordinates Coordinates { get; set; } = new Coordinates();
        public double Distance { get; set; }
        public double Weighting { get; set; }
    }
}
