using System;

namespace TrainingSchedule
{
    /// <summary>
    /// Класс, описывающий аттрибут для описания полей
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class NameAttribute : Attribute
    {
        public string Description;
        public NameAttribute(string description)
        {
            Description = description;
        }
    }
}
