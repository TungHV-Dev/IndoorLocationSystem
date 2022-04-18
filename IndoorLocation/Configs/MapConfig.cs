namespace IndoorLocation.Configs
{
    public class MapConfig
    {
        // Config for WKNN algorithms
        public const int max_X = 7;
        public const int max_Y = 4;
        public const int max_DataRSSI_In_One_Point = 100;
        public const int max_Point = (max_X + 1) * (max_Y + 1);
        public const int K_Nearest_Point = 3;

        // Config for BFS algorithms in graph
        public const int VertexNumberInWidth = 9;
        public const int VertexNumberInLength = 15;
        public const double StopDistance = 0.2;     // 10cm

        // Config for map drawing
        public const int BarrierType = 1;

        public const double PointWidth = 0.15;
        public const double PointHeigh = 0.15;

        public const float BorderMapWidth = 3.0f;
        public const float DashLineGridWidth = 1.0f;
        public const float SolidLineGridWidth = 1.5f;
        public const float BorderPointWidth = 1.5f;
        public const float BarrierLineWidth = 2.5f;
        public const float PathWidth = 1.75f;
    }
}
