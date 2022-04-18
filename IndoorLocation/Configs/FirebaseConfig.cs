namespace IndoorLocation.Configs
{
    public static class FirebaseConfig
    {
        public static class Authentication
        {
            public const string Url = "https://ils-development-default-rtdb.asia-southeast1.firebasedatabase.app/";
            public const string Secret_Key = "jMXCpJSNYbaJvAj9i7eWnUvfNPIRFu6Y4Veq3M4z";
        }

        public static class Key
        {
            public const string Collected_Data = "CollectedData";
            public const string Current_Point = "CurrentPoint";
            public const string Data_In_Current_Point = "DataInCurrentPoint";
            public const string Destination_Point = "DestinationPoint";
            public const string Next_Point = "NextPoint";
            public const string Processed_Data = "ProcessedData";
        }
    }
}
