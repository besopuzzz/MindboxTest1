using MindboxTest1.Library;
using System;

namespace MindboxTest1.UnitTest
{
    /// <summary>
    /// Демонстрационный класс начальных параметров круга, где известен только радиус <see cref="Radius"/>
    /// </summary>
    internal class CircleParameter : IFigureParameter
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Конструктор с начальными параметрами
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public CircleParameter(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("Параметр radius должно быть больше 0!");

            Radius = radius;
        }
    }

    /// <summary>
    /// Демонстрационный класс итогов круга
    /// </summary>
    internal class CircleCalculator : IFigureCalculator<CircleParameter>
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
        /// <param name="parameter">Начальные параметры круга</param>
        void IFigureCalculator<CircleParameter>.Calculate(CircleParameter parameter)
        {
            Perimeter = 2 * Math.PI * parameter.Radius;
            Area = Math.PI * Math.Pow(parameter.Radius, 2);
        }
    }
}
