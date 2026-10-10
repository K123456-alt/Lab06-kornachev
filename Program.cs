// Console.WriteLine("Hello, World!");
// for (int i = 1; i <= 5; i++){   // цикл for
//     Console.WriteLine(i);
// }
// int n = 1;  // цикл while
// while (n <= 5)
// {
//     Console.WriteLine(n);
//     n++;
// }
// int answer;   //Цикл do while
// do
// {
//     Console.Write("Введите число больше 0: ");
//     answer = Convert.ToInt32(Console.ReadLine());
// }
// while (answer <= 0);
// for (int i = 1; i <= 10; i++)  //break и continue
// {
//     if (i == 3) continue;
//     if (i == 7) break;
//     Console.WriteLine(i);
// }

// Задание 1.1
// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine(i);
// }
// for (int i = 10; i >= 1; i--)
// {
//     Console.WriteLine(i);
// }
//Задание 1.2
// for (int i = 2; i <= 50; i += 2)
// {
//     Console.WriteLine(i);
// }
//Задание 2
// int sum = 0;
// int count = 0;

// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0) sum += i;
//     if (i % 7 == 0) count++;
// }
// Console.WriteLine($"Сумма кратных 3: {sum}");
// Console.WriteLine($"Количество кратных 7: {count}");
// Задание 3
// int number = Convert.ToInt32(Console.ReadLine());
// int positive = 0;
// int negative = 0;

// while (number != 0)
// {
//     if (number > 0) positive++;
//     else negative++;

//     number = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Положительных: {positive}");
// Console.WriteLine($"Отрицательных: {negative}");

// Задание 4
// bool ass = false;
// for (int i = 1; i <= 3; i++)
// {
//     Console.Write($"Попытка {i}. Введите пароль: ");
//     string password = Console.ReadLine();

//     if (password == "qwerty")
//     {
//         Console.WriteLine("Доступ разрешён");
//         ass = true;
//         break;
//     }
// }
// if (!ass)
// {
//     Console.WriteLine("Доступ заблокирован");
// }

// Задание 5
// Console.Write("Введите число от 1 до 9: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{n} x {i} = {n * i}");
// }
//Задание 6
// for (int i = 1; i <= 30; i++)
// {
//     if (i % 3 == 0) continue;
//     if (i % 10 == 0 && i > 20) break;
//     Console.WriteLine(i);
// }

//Задание "Угадай число"
// int secret = 42;
// int attempts = 0;
// bool win = false;
// for (int i = 1; i <= 5; i++)
// {
//     Console.Write($"Попытка {i}. Введите число: ");
//     int guess = Convert.ToInt32(Console.ReadLine());
//     attempts++;
//     if (guess == secret)
//     {
//         Console.WriteLine($"Победа! Попыток: {attempts}");
//         win = true;
//         break;
//     }
//     else if (guess < secret)
//     {
//         Console.WriteLine("Больше");
//     }
//     else
//     {
//         Console.WriteLine("Меньше");
//     }
// }
// if (!win)
// {
//     Console.WriteLine($"Вы проиграли, число было {secret}");
// }

// Доп задание
// Console.Write("Введите целое положительное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int count = 0;

// while (n > 0)
// {
//     int digit = n % 10;
//     sum += digit;
//     count++;
//     n = n / 10;
// }
// Console.WriteLine($"Сумма цифр: {sum}");
// Console.WriteLine($"Количество цифр: {count}");
