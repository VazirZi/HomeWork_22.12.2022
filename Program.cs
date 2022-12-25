//==============================Задача_1==============================



/*
int enterNumber(int num)    // Функция повторного ввода числа
{
    while(num > 100000 || num <= 10000)
    {
    Console.Write("Введено не пятизначное число! Введите пятизначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

bool calcucation (int numb) // Функция вычислений
{
    int firstNum = numb / 10000;
    int secondNum = (numb / 1000) % 10;
    int perLastNum = (numb / 10) % 10;
    int lastNum = numb % 10;

    bool yesNo = true;

    if (firstNum == lastNum && secondNum == perLastNum)
    {
        return yesNo;
    }
    else
    {
        yesNo = false;
        return yesNo;
    }
}

string yesNo (bool var)     // Функция получения окончательного ответа
{
    string answer = "";

    if (var == true)
    {
        answer = "Введенное число является полиндормом";  
    }
    else if (var == false)
    {
        answer = "Введенное число НЕявляется полиндормом";
    }
    return answer;
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool answerYesMNo = true;    // Дополнительная переменная для проверки
string  answering = "";      // Переменная, которая будет возвращать ответ в конце

if (number < 100000 && number >= 10000)
{
    answerYesMNo = calcucation(number); // Вызываем функцию подсчета и проверки
    answering = yesNo(answerYesMNo);    // Вызываем функцию для получения окончательного ответа
    
}
else if (number > 100000 || number <= 10000)
{
    number = enterNumber(number);       // Вызываем функцию для повторного ввода числа
    answerYesMNo = calcucation(number); // Вызываем функцию подсчета и проверки
    answering = yesNo(answerYesMNo);    // Вызываем функцию для получения окончательного ответа
}

Console.WriteLine(answering);   // Выводим ответ
*/



//==============================Задача_2==============================



/*
double x, x1, y, y1, z, z1;

Console.WriteLine("Введите координаты первой точки:");

Console.Write("x = ");
x = Convert.ToDouble(Console.ReadLine());

Console.Write("y = ");
y = Convert.ToDouble(Console.ReadLine());

Console.Write("z = ");
z = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");

Console.Write("x = ");
x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("y = ");
y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("z = ");
z1 = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2) + Math.Pow((z1 - z), 2));

Console.WriteLine($"Расстояние между точками в 3D пространстве = {Math.Round(result, 2)}");
*/



//==============================Задача_3==============================



/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

double result = 0;

for (int i = 1; i <= number; i++)
{
    result = i;
    result = Math.Pow(result , 3);
    Console.WriteLine(result);
}
*/