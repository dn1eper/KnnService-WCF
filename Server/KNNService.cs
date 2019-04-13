using System;
using System.ServiceModel;
using System.Threading;

namespace Server
{
    [ServiceContract(SessionMode = SessionMode.Allowed)]
    public interface IKNNService
    {
        /// <summary>
        /// Возвращает класс, к которому принадлежит объект.
        /// </summary>
        [OperationContract]
        bool GetClass(Patient p);
        /// <summary>
        /// Добавляет новый объект к набору данных.
        /// </summary>
        [OperationContract]
        void AddPatient(Patient p, bool c);
        /// <summary>
        /// Возвращает информацию о сервисе.
        /// </summary>
        [OperationContract]
        string GetServiceInfo();
        /// <summary>
        /// Возвращает информацию о наборе данных.
        /// </summary>
        [OperationContract]
        string GetDatasetInfo();
        /// <summary>
        /// Отключение от сервиса.
        /// </summary>
        [OperationContract]
        void Exit();
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class KNNService : IKNNService, IDisposable
    {
        public bool GetClass(Patient p)
        {
            ServiceInfo.NewRequest();
            return KNN.Classify(p);
        }

        public void AddPatient(Patient p, bool c)
        {
            ServiceInfo.NewRequest();
            KNN.Add(p, c);
        }

        public string GetServiceInfo() =>
            string.Concat(
                "Clients - ",
                ServiceInfo.ClientCount,
                "\nRequests - ",
                ServiceInfo.RequetCount
            );

        public string GetDatasetInfo() =>
            string.Concat(
                "Data set contains ",
                KNN.Count(),
                " instances.\n",
                KNN.Count(true),
                " - positive survival status,\n",
                KNN.Count(false),
                " - negative."
            );

        public KNNService() =>
            ServiceInfo.ClientConnected();
        public void Dispose() =>
            ServiceInfo.ClientDisconnected();
        public void Exit() =>
            Dispose();
    }
}
