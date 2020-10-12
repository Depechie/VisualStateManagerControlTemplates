using System;
namespace VisualStateTriggers.Models
{
    public enum AnimalType
    {
        Dog,
        Cat,
        Bird
    }

    /// <summary>
    /// Now you can use Generics to have cleaner code when enum parsing!
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <example>
    /// CT.Organ organNewParse = Enum<CT.Organ>.Parse("LENS");
    /// </example>
    public static class Enum<T>
    {
        public static T Parse(string value, bool ignoreCase = true)
        {
            return (T)Enum.Parse(typeof(T), value, ignoreCase);
        }
    }
}