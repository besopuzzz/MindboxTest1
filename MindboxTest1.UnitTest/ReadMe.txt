Практический тест #1: Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

    1. Юнит-тесты

    2. Легкость добавления других фигур

    3. Вычисление площади фигуры без знания типа фигуры в compile-time

    4. Проверку на то, является ли треугольник прямоугольным


    Ответы и решения:
    1. Юнит-тесты описаны в классе FigureTest.cs. Тесты делал впервые, однако понял их значимость
    2. Не знаю, легкий это способ или нет, но добавление фигур происходят в проекте UnitTest, файлы Circle.cs, Ellipse.cs, Traingle.cs
    3. А разве возможно подсчитать площадь, не зная тип фигуры? Либо я недопонимаю)
    4. Сделал этот в демонстрационном классе Triangle проекта UnitTest




Практический тест #2: Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
    Ответ и решение: Скрипт создания тестовой БД с Продуктами и Категориями, а так же сам SQL запрос выборки, лежит в UnitTest/SQL