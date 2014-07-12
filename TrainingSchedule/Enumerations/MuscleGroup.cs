using System;

namespace TrainingSchedule
{
    /// <summary>
    /// Перечисление типов мускул
    /// </summary>
    [Flags]
    public enum MuscleGroup
    {
        [Name("Все")]
        All,
        [Name("Бицепс")]
        Biceps,
        [Name("Трицепс")]
        Triceps,
        [Name("Предплечье")]
        Forearm,
        [Name("Грудные мышцы")]
        PectoralMuscle,
        [Name("Мышцы спины")]
        BackMuscles,
        [Name("Плечевые мышцы")]
        ShoulderMuscles,
        [Name("Пресс")]
        Press,
        [Name("Ноги")]
        Feet
    }
}
