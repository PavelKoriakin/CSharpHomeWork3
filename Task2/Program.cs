// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

int InputInt(string message)                                            //Название метода
{
    System.Console.Write($"{message}>");                                //Вывод приглашения квводу
    int value;                                                          //Инициализация переменной
    // bool isCorrect = int.TryParse(Console.ReadLine(), out value);
    // if(isCorrect)
    // Или
    if (int.TryParse(Console.ReadLine(), out value))          //Условия корректности ввода + ввод со строки
    {                                                         //если конвертация прошла правильно, то мы попадаем в ветку               
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);                               //Возвращаемся в систему (выход из программы) с кодом ошибки(1)
    return 0;                                           //Для копиляции
}

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)         //Функция поиска расстояния между точками
{
    int deltaX = x2 - x1;                               //Считает расстояние между точками по оси Х
    int deltaY = y2 - y1;
    int deltaZ = z1 - z2;                              //Считает расстояние между точкми по оси У
    return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);    //Функция возвращает значение = квадратный корень суммы квадратов катетов (Пифагор)
}
int x1 = InputInt($"Введите координату X первой точки:");    //Функции ввода координат
int y1 = InputInt($"Введите координату Y первой точки:");    //
int z1 = InputInt($"Введите координату Z первой точки:");    //
int x2 = InputInt($"Введите координату X второй точки:");    //
int y2 = InputInt($"Введите координату Y второй точки:");    //
int z2 = InputInt($"Введите координату Z второй точки:");    //

System.Console.WriteLine($"Расстояние между точками А({x1}, {y1}, {z1}) и B({x2}, {y2}, {z2}) равно {Distance(x1, y1, z1, x2, y2, z2):F2}");

