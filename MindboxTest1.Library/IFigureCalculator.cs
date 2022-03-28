namespace MindboxTest1.Library
{
    /// <summary>
    /// Базовый интерфейс итогов фигуры
    /// </summary>
    /// <typeparam name="T">Тип начальных параметров</typeparam>
    public interface IFigureCalculator<T>
        where T : IFigureParameter
    {
        /// <summary>
        /// Периметр фигуры
        /// </summary>
        double Perimeter { get; }

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        double Area { get; }

        /// <summary>
        /// Функция подведения итогов
        /// </summary>
        /// <param name="parameter">Начальные параметры фигуры</param>
        void Calculate(T parameter);
    }
}
