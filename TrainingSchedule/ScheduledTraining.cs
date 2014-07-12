using System;
using System.Xml.Serialization;

namespace TrainingSchedule
{
    /// <summary>
    /// Модель данных, содеращая данных о тренировке и о времени ее выполнения.
    /// </summary>
    public class ScheduledTraining
    {
        [XmlElement(Global.INFO)]
        public Training Training { get; set; }
        public DateTime Date { get; set; }
    }
}