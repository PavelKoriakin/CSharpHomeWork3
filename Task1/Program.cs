// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Проверка без применения строк

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int digits = 5;

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
    return 0;
}


bool ValidateDigits(int value)                         //Проверка на пятизначное число
{
    if (value > 99999 || value < 10000)
    {
        System.Console.WriteLine("Вы ввели не пятизначное число");
        return false;
    }
    return true;
}

int Reverse(int value)                                //Разворот числа
{
    int reverse = 0;
    while (value > 0)
    {
        reverse = reverse * 10 + value % 10;
        value = value / 10;
    }
    return reverse;
}
int userNumber = InputInt("Введите пятизначное число >");
if (ValidateDigits(userNumber))
{

    if (userNumber == Reverse(userNumber))                                                        //Проверка числа на палиндрома
    {
        System.Console.WriteLine($"Число {userNumber} является палиндромом");
    }
    else
    {
        System.Console.WriteLine($"Число {userNumber} не является палиндромом");

    }
}