using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace TrainingSchedule
{
    /// <summary>
    /// Класс методов расширения для класса Enum
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Конвертировать Enum в Dictionary.
        /// </summary>
        /// <param name="value">Значение в перечислении</param>
        /// <param name="useDescriptionAttribute">Использовать ли данные атрибута Description</param>
        /// <returns>Объект Dictionary<int, string></returns>
        public static IDictionary<int, string> ToDictionary(this Enum value, bool useDescriptionAttribute = false)
        {
            var type = value.GetType();
            return type.GetEnumValues().Cast<int>().ToDictionary(e => e, e => useDescriptionAttribute ? GetDescription((Enum)Enum.Parse(type, e.ToString(CultureInfo.InvariantCulture), true)) : Enum.GetName(type, e));
        }

        /// <summary>
        /// Конвертировать Enum в массив имен.
        /// </summary>
        /// <param name="value">Значение в перечислении</param>
        /// <param name="useDescriptionAttribute">Использовать ли данные атрибута Description</param>
        /// <returns>Массив строковых значений</returns>
        public static IEnumerable<string> ToListNames(this Enum value, bool useDescriptionAttribute = false)
        {
            var type = value.GetType();
            return type.GetEnumNames().Select(e => useDescriptionAttribute ? GetDescription((Enum)Enum.Parse(type, e.ToString(CultureInfo.InvariantCulture), true)) : e);
        }

        /// <summary>
        /// Конвертировать Enum в массив имен.
        /// </summary>
        /// <param name="type"></param>
        /// <returns>Массив строковых значений</returns>
        public static IEnumerable<string> GetDescriptions(Type type)
        {
            return type.GetEnumNames().Select(e => GetDescription((Enum)Enum.Parse(type, e.ToString(CultureInfo.InvariantCulture), true)));
        }
        /// <summary>
        /// Конвертировать Enum в массив числовых значений.
        /// </summary>
        /// <param name="value">Значение в перечислении</param>
        /// <returns>Массив числовых значений</returns>
        public static IEnumerable<int> ToListValues(this Enum value)
        {
            var type = value.GetType();
            return type.GetEnumValues().OfType<int>();
        }

        /// <summary>
        /// Значение Enum в число.
        /// </summary>
        /// <param name="value">Значение в перечислении</param>
        /// <returns>Значение int</returns>
        public static int ToInt(this Enum value)
        {
            var type = value.GetType();
            return (int)Enum.Parse(type, value.ToString());
        }

        /// <summary>
        /// Значение атрибута Description выбранного элемента Enum.
        /// </summary>
        /// <param name="value">Значение в перечислении</param>
        /// <returns>Значение атрибута Description</returns>
        public static string GetDescription(this Enum value)
        {
            var type = value.GetType();
            var fieldInfo = type.GetField(value.ToString(CultureInfo.InvariantCulture));
            var attribs = fieldInfo.GetCustomAttributes(typeof(NameAttribute), false) as NameAttribute[];
            return attribs != null && attribs.Length > 0 ? attribs[0].Description : null;
        }

        /// <summary>
        /// Определено ли значение.
        /// </summary>
        /// <param name="value">Значение в перечислении</param>
        /// <returns>True/False</returns>
        public static bool IsDefined(this Enum value)
        {
            return IndexOf(value) > -1;
        }

        /// <summary>
        /// Индекс выбранного значения в перечислении Enum. Начиная с нуля.
        /// </summary>
        /// <param name="value">Значение в перечислении</param>
        /// <returns>Значение int</returns>
        public static int IndexOf(this Enum value)
        {
            return Array.IndexOf(value.ToListNames().ToArray(), value.ToString());
        }
        /// <summary>
        /// Значение Enum по значению атрибута Description.
        /// </summary>
        /// <typeparam name="T">Тип Enum</typeparam>
        /// <param name="description">Значение в атрибуте Description</param>
        /// <returns>Значение Enum</returns>
        public static T GetValue<T>(this string description)
        {
            var type = typeof(T);
            if (!type.IsEnum) throw new InvalidOperationException();
            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(NameAttribute)) as NameAttribute;
                if (attribute != null)
                {
                    if (attribute.Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T)field.GetValue(null);
                }
            }
            return default(T);
        }
    }
}
