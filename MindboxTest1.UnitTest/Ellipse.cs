using MindboxTest1.Library;
using System;

namespace MindboxTest1.UnitTest
{
    /// <summary>
    /// Демонстрационный класс эллипса, обернутый вокруг базового класса для строгой типизации
    /// </summary>
    internal class Ellipse : Figure<EllipseParameter, EllipseCalculator>
    {
        /// <summary>
        /// Конструктор с начальными параметрами
        /// </summary>
        /// <param name="radius1">Первый радиус</param>
        /// <param name="radius2">Второй радиус</param>
        public Ellipse(double radius1, double radius2) : base(new EllipseParameter(radius1, radius2))
        {
        }

        /// <summary>
        /// Унаследованный метод получения итогов
        /// </summary>
        /// <returns>Экземпляр итогов</returns>
        public override EllipseCalculator GetResults()
        {
            return base.GetResults();
        }
    }

    /// <summary>
    /// Демонстрационный класс начальных параметров эллипса, где известны только два радиуса двух полукругов: <see cref="Radius1"/> и <see cref="Radius2"/>
    /// </summary>
    internal class EllipseParameter : IFigureParameter
    {
        public double Radius1 { get; }
        public double Radius2 { get; }

        /// <summary>
        /// Конструктор с начальными параметрами
        /// </summary>
        /// <param name="radius1">Первый радиус</param>
        /// <param name="radius2">Второй радиус</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public EllipseParameter(double radius1, double radius2)
        {
            if (radius1 <= 0 | radius2 <= 0)
                throw new ArgumentOutOfRangeException("Параметры radius1 и radius2 должны быть больше 0!"); // Проверка на передаваемые параметры

            Radius1 = radius1;
            Radius2 = radius2;
        }
    }

    /// <summary>
    /// Демонстрационный класс итогов эллипса
    /// </summary>
    internal class EllipseCalculator : IFigureCalculator<EllipseParameter>
    {
        /// <summary>
        /// Периметр
        /// </summary>
        public double Perimeter { get; private set; }

        /// <summary>
        /// Площадь
        /// </summary>
        public double Area { get; private set; }

        /// <summary>
        /// Функция для подсчета итогов
        /// </summary>
        /// <param name="parameter">Начальные параметры эллипса</param>
        void IFigureCalculator<EllipseParameter>.Calculate(EllipseParameter parameter)
        {
            Perimeter = 2 * Math.PI * Math.Sqrt((Math.Pow(parameter.Radius1, 2) + Math.Pow(parameter.Radius2, 2)) / 2);
            Area = Math.PI * parameter.Radius1 * parameter.Radius2;
        }

    }
}
