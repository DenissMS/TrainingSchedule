namespace TrainingSchedule
{
    /// <summary>
    /// Перечисление типов упражнений
    /// </summary>
    public enum ExerciseType
    {
        [Name("Гибкость")]
        Flexibility,

        [Name("Динамическая сила")]
        DynamicStrength,

        [Name("Статическая сила")]
        StaticStrength,

        [Name("Аэробика")]
        Aerobic,

        [Name("Контур")]
        Circuit
    }
}
