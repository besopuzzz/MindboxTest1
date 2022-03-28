using System;

namespace MindboxTest1.Library
{

    /// <summary>
    /// Базовый класс фигуры
    /// </summary>
    /// <typeparam name="T">Тип параметров и итогов фигуры</typeparam>
    public class Figure<TParameter, TCalculator>
        where TParameter : IFigureParameter
        where TCalculator : IFigureCalculator<TParameter>, new()
    {
        /// <summary>
        /// Начальные параметры <typeparamref name="TParameter"/> типа
        /// </summary>
        public TParameter Parameter { get; private set; }


        /// <summary>
        /// Конструктор базовой фигуры
        /// </summary>
        /// <param name="calculator">Экземпляр первоначальных параметров</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Figure(TParameter parameter)
        {
            if (parameter == null)
                throw new ArgumentNullException("Начальные параметры не могут быть равны null!");

            Parameter = parameter;
        }

        /// <summary>
        /// Подсчитывает и возвращает <see cref="TCalculator"/> итоги
        /// </summary>
        /// <returns></returns>
        public virtual TCalculator GetResults()
        {
            TCalculator calculator = new TCalculator();
            calculator.Calculate(Parameter);

            return calculator;
        }
    }
}
