// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

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

int number = InputInt("Введите число N, до которого выдадим кубы");
for (int i = 1; i <= number; i++) //у цикла for 3 параметра: инициализация, условие продолжения, команда в конце каждого цикла
{
    int cube = i * i * i;
    System.Console.Write($"{cube} ");
}