using System;

namespace Server
{
    public static class ServiceInfo
    {
        public static int RequetCount { private set; get; }
        public static int ClientCount { private set; get; }
        private static object SpinLock = new object();

        public static void NewRequest()
        {
            lock (SpinLock) RequetCount++;
            Console.WriteLine("Got new request.");
        }

        public static void ClientConnected()
        {
            lock (SpinLock) ClientCount++;
            Console.WriteLine("New client connected.");
        }

        public static void ClientDisconnected()
        {
            lock (SpinLock) ClientCount--;
            Console.WriteLine("Client just disconnected.");
        }
    }
}
