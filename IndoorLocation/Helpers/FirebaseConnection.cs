using Firebase.Database;
using IndoorLocation.Configs;
using IndoorLocation.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IndoorLocation.Helpers
{
    public class FirebaseConnection
    {
        private FirebaseClient Client;

        public FirebaseConnection()
        {
            Client = new FirebaseClient(
                baseUrl: FirebaseConfig.Authentication.Url,
                new FirebaseOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(FirebaseConfig.Authentication.Secret_Key)
                });
        }

        public void Destroy()
        {
            Client.Dispose();
        }

        #region Get data from firebase
        public async Task<IReadOnlyCollection<FirebaseObject<List<RSSI>>>> GetCollectedData()
        {
            var collectedData = await Client.Child(FirebaseConfig.Key.Collected_Data).OnceAsync<List<RSSI>>();
            return collectedData;
        }

        public async Task<RSSI> GetDataInCurrentPoint()
        {
            var data = await Client.Child(FirebaseConfig.Key.Data_In_Current_Point).OnceSingleAsync<RSSI>();
            return data;
        }

        public async Task<List<DataPoint>> GetProcessedData()
        {
            var data = await Client.Child(FirebaseConfig.Key.Processed_Data).OnceAsync<RSSI>();
            var response = new List<DataPoint>();

            foreach (var item in data)
            {
                var dataPoint = new DataPoint
                {
                    Coordinates = new Coordinates(double.Parse(item.Key[6].ToString()), double.Parse(item.Key[7].ToString())),
                    RSSI = item.Object
                };
                response.Add(dataPoint);
            }

            return response;
        }
        #endregion

        #region Put data to firebase
        public async Task PutDataInCurrentPoint(RSSI data)
        {
            await Client.Child(FirebaseConfig.Key.Data_In_Current_Point).PutAsync(RSSI.ConvertToJsonString(data));
        }

        public async Task PutCoordinates(Coordinates point, string key)
        {
            await Client.Child(key).PutAsync(Coordinates.ConvertToJsonString(point));
        }

        public async Task PutProcessedData(List<DataPoint> dataPoints)
        {
            foreach (var data in dataPoints)
            {
                await Client.Child(FirebaseConfig.Key.Processed_Data + "/Point_" + data.Coordinates.x.ToString() + data.Coordinates.y.ToString())
                    .PutAsync(RSSI.ConvertToJsonString(data.RSSI));
            }
        }

        public async Task PutCollectedData(List<DataPoint> listDataPoints)
        {
            var count = 0;
            foreach (var data in listDataPoints)
            {
                await Client.Child(FirebaseConfig.Key.Collected_Data + "/Point_" + data.Coordinates.x.ToString() + data.Coordinates.y.ToString() + "/" + count.ToString()).PutAsync(RSSI.ConvertToJsonString(data.RSSI));
                count++;
                if (count == 100)
                {
                    await Client.Child(FirebaseConfig.Key.Collected_Data
                        + "/Point_" + data.Coordinates.x.ToString() + data.Coordinates.y.ToString()
                        + "/" + count.ToString()).DeleteAsync();

                    count = 0;
                }
            }
        }
        #endregion
    }
}
