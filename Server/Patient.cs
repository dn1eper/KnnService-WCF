using System;
using System.Runtime.Serialization;

namespace Server
{
    /// <summary>
    /// Пациент.
    /// </summary>
    [DataContract]
    public class Patient : Object
    {
        /// <summary>
        /// Возраст пациента на момент операции.
        /// </summary>
        [DataMember]
        public int Age { get; set; }
        /// <summary>
        /// Год в котором была проведена операция.
        /// </summary>
        [DataMember]
        public int OperationYear { get; set; }
        /// <summary>
        /// Количество обнаруженных положительных подмышечных узлов.
        /// </summary>
        [DataMember]
        public int NodesNumber { get; set; }
    }
}
