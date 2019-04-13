using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.IO;

namespace Server
{
    /* Using Haberman's Survival Data Set 
     * https://archive.ics.uci.edu/ml/datasets/Haberman%27s+Survival
     */
    
    class Program
    {
        private const string DatasetFile = @"../../../Dataset/haberman.data";
        private const string Uri = "http://localhost:8080/knn";

        static void Main(string[] args)
        {
            // Itinialize KNN
            using (StreamReader reader = new StreamReader(DatasetFile))
            {
                while (!reader.EndOfStream)
                {
                    string[] strValues = reader.ReadLine().Split(',');
                    int[] intValues = Array.ConvertAll<string, int>(strValues, int.Parse);
                    Patient p = new Patient() {
                        Age = intValues[0],
                        OperationYear = intValues[1],
                        NodesNumber = intValues[2]
                    };
                    bool c = intValues[3] == 1;
                    KNN.Add(p, c);
                }
            }

            // Start service
            ServiceHost host = new ServiceHost(typeof(KNNService), new Uri(Uri));
            host.AddServiceEndpoint(typeof(IKNNService), new WSHttpBinding(), "");
            
            ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
            behavior.HttpGetEnabled = true;
            host.Description.Behaviors.Add(behavior);
            host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

            host.Open();
            Console.WriteLine("Server runing at " + Uri);

            // Waiting for interrupt
            Console.ReadKey();
            host.Close();
        }
    }
}
