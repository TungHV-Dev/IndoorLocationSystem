using Newtonsoft.Json;
using System;

namespace IndoorLocation.Models
{
    public class RSSI
    {
        public double RSSI_A { get; set; }
        public double RSSI_B { get; set; }
        public double RSSI_C { get; set; }
        public double RSSI_D { get; set; }

        public RSSI() { }
        public RSSI(double rssi_A, double rssi_B, double rssi_C, double rssi_D)
        {
            RSSI_A = rssi_A;
            RSSI_B = rssi_B;
            RSSI_C = rssi_C;
            RSSI_D = rssi_D;
        }

        public static string ConvertToJsonString(RSSI rssiData)
        {
            return JsonConvert.SerializeObject(rssiData);
        }

        public static double Distance(RSSI data1, RSSI data2)
        {
            return Math.Sqrt((data1.RSSI_A - data2.RSSI_A) * (data1.RSSI_A - data2.RSSI_A)
                    + (data1.RSSI_B - data2.RSSI_B) * (data1.RSSI_B - data2.RSSI_B)
                    + (data1.RSSI_C - data2.RSSI_C) * (data1.RSSI_C - data2.RSSI_C)
                    + (data1.RSSI_D - data2.RSSI_D) * (data1.RSSI_D - data2.RSSI_D));
        }
    }
}
