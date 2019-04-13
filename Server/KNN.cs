using System;
using System.Collections.Generic;
using System.Linq;

namespace Server
{
    /// <summary>
    /// Реализация алгоритма KNN.
    /// </summary>
    public static class KNN
    {
        private static List<Tuple<Patient, bool>> patients = new List<Tuple<Patient, bool>>();
        public const int N = 5;
        private static object SpinLock = new object();

        /// <summary>
        /// Возвращает класс, к которому принадлежит объект.
        /// </summary>
        public static bool Classify(Patient p)
        {
            if (Count() < N) throw new Exception("Too few examples");

            List<Tuple<double, bool>> distances = new List<Tuple<double, bool>>();
            lock (patients)
            {
                patients.ForEach(tuple =>
                    distances.Add(new Tuple<double, bool>(dist(p, tuple.Item1), tuple.Item2))
                );
            }

            return N / 2 < distances
                .OrderBy(tuple => tuple.Item1)
                .Take(N)
                .Where(tuple => tuple.Item2 == true)
                .Count();
        }

        /// <summary>
        /// Добавляет новый объект к набору данных.
        /// </summary>
        public static void Add(Patient p, bool c)
        {
            lock (patients)
            {
                patients.Add(new Tuple<Patient, bool>(p, c));
            }
        }

        /// <summary>
        /// Возвращает число объектов в наборе данных.
        /// </summary>
        public static int Count()
        {
            lock (patients)
            {
                return patients.Count;
            }
        }

        /// <summary>
        /// Возвращает число объектов в наборе данных, принадлежащих к определенному классу.
        /// </summary>
        public static int Count(bool c)
        {
            lock (patients)
            {
                return patients.Where(tuple => tuple.Item2 == c).Count();
            }
        }

        /// <summary>
        /// Возвращает расстояние между двумя объектами.
        /// </summary>
        private static double dist(Patient p1, Patient p2)
        {
            return Math.Sqrt(
                Math.Pow(p1.Age - p2.Age, 2) +
                Math.Pow(p1.OperationYear - p2.OperationYear, 2) +
                Math.Pow(p1.NodesNumber - p2.NodesNumber, 2)
            );
        }
    }
}
