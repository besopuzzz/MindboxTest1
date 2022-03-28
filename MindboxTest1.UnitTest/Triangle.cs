using MindboxTest1.Library;
using System;
using System.Linq;

namespace MindboxTest1.UnitTest
{
    /// <summary>
    /// Демонстрационный класс начальных параметров треугольника, где известны только три стороны: <see cref="A"/>, <see cref="B"/>, <see cref="C"/>
    /// </summary>
    internal class TriangleParameter : IFigureParameter
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        /// <summary>
        /// Конструктор с начальными параметрами
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public TriangleParameter(double a, double b, double c)
        {
            if (a <= 0 | b <= 0 | c <= 0)
                throw new ArgumentOutOfRangeException("Параметры a, b, c должны быть больше 0!"); // Проверка на передаваемые параметры

            this.A = a;
            this.B = b;
            this.C = c;
        }

    }

    /// <summary>
    /// Демонстрационный класс итогов треугольника
    /// </summary>
    internal class TriangleCalculator : IFigureCalculator<TriangleParameter>
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
        /// Вернет true, если треугольник прямоугольный. Иначе - false
        /// </summary>
        public bool IsRightTriangle { get; private set; }

        /// <summary>
        /// Функция для подсчета итогов
        /// </summary>
        /// <param name="parameter">Начальные параметры треугольника</param>
        void IFigureCalculator<TriangleParameter>.Calculate(TriangleParameter parameter)
        {
            Perimeter = parameter.A + parameter.B + parameter.C;

            double halfPerimeter = Perimeter / 2;
            Area = Math.Sqrt(halfPerimeter * (halfPerimeter - parameter.A) * (halfPerimeter - parameter.B) * (halfPerimeter - parameter.C));

            IsRightTriangle = IsRightTriangleFromArea(parameter);
        }

        /// <summary>
        /// Вернет true, если треугольник прямоугольный. Иначе - false
        /// </summary>
        /// <param name="parameter">Начальные параметры треугольника</param>
        /// <returns></returns>
        private bool IsRightTriangleFromArea(TriangleParameter parameter)
        {
            double[] sorted = new double[3] { parameter.A, parameter.B, parameter.C }.OrderBy(x => x).ToArray(); // Добавляем в массив для сортировки по возрастанию

            if (Area == (sorted[0] * sorted[1]) / 2) // Первых два элемента самые маленькие, то есть (преположительно) катеты. Если площадь равна 1/2 произведению катетов, то это прямоугольник
                return true;
            return false;
        }
    }
}
