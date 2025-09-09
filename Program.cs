using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //double a = 10;
            //double b = 3;
            //double c = a/b;
            //Console.WriteLine(c);

            //double x = 10 / 3;
            //Console.WriteLine(x);

            //int x1 = 4;
            //int y1 = ++x1;
            //Console.WriteLine(x1);
            //Console.WriteLine(y1);

            //int x2 = 5;
            //int y2 = x2++;
            //Console.WriteLine(x2);
            //Console.WriteLine(y2);

            //int x = 1;
            //Console.WriteLine(x++ + ++x);

            //логические операции

            //bool x1 = (5 > 6) | (4 < 7); 
            //bool x2 = (5 > 6) & (4 < 7);

            //double num = 2.4234234;
            //Console.WriteLine($"{num:F2}"); //сколько я хочу числа после запятой
            //Console.WriteLine($"{num:C}");
            //Console.WriteLine($"{num:P}");


            //Console.WriteLine("введите");
            //int num = int.Parse(Console.ReadLine());

            //if (num > 0)
            //{
            //    Console.WriteLine("Число положительное");
            //}
            //else
            //{
            //    Console.WriteLine("число отрецательное ");
            //}

            //Console.WriteLine();
            //int num = int.Parse(Console.ReadLine());
            //if (num > 0)
            //{
            //    Console.WriteLine("Число положительное");
            //}
            //else if (num == 0)
            //{
            //    Console.WriteLine("число отрецательное ");
            //}
            //else
            //{
            //    Console.WriteLine("e");
            //}



            //int x = 3;
            //int y = 2;
            //int z = (x > y) ? (x+y) : (x-y); //сокрощеная версия если и иначе 
            //Console.WriteLine(z);



            //Console.WriteLine("Введите игру");
            //string nam = Console.ReadLine().ToLower();

            //switch (nam)
            //{
            //    case "dota2": Console.WriteLine("Ваша игра дота "); break;
            //    case "майн": Console.WriteLine("Ваша игра это майн"); break;
            //    default: Console.WriteLine("Игра не найденнв"); break;
            //}


            //Самостоятельные задания 

            //1 задания 
            //Console.WriteLine("Введите введите число");
            //int num = int.Parse(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Число четное");
            //}
            //else
            //{
            //    Console.WriteLine("Число не четное");
            //}


            //2 задания 

            //Console.WriteLine("Введите 1 пароль ");
            //string p1 = Console.ReadLine();
            //Console.WriteLine("Введите 2 пароль ");
            //string p2 = Console.ReadLine();

            //if (p1 == p2)
            //{
            //    Console.WriteLine("Пароль принят");
            //}
            //else
            //{
            //    Console.WriteLine("Пароль не приянь");
            //}


            //3 задания
            //Console.WriteLine("Введите четырехзначное число ");
            //int num = int.Parse(Console.ReadLine());

            //int n3 = (num % 10) + (num / 1000);

            //Console.WriteLine(num);


            //4 задания 
            //int age;

            //Console.WriteLine("Введите свой возраст ");
            //age = int.Parse(Console.ReadLine());

            //if (age > 17)
            //{
            //    Console.WriteLine("Доступ разрешен");
            //}
            //else
            //{
            //    Console.WriteLine("Доступ запрещен");
            //}

            //5 задания 
            //Console.WriteLine("Введите первое число  ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введите второе число  ");
            //int num2 = int.Parse(Console.ReadLine());

            //if (num1 > num2)
            //{
            //    Console.WriteLine(num2);
            //}
            //else
            //{
            //    Console.WriteLine(num1);
            //}

            //6 задания 

            //Console.WriteLine("===Мини калькулятор===");
            //Console.WriteLine("Первое число ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Второе число ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Операция (+,-,*,/)");
            //string ti = Console.ReadLine();

            //if (ti == "+")
            //{
            //    Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));
            //}
            //else if (ti == "-")
            //{
            //    Console.WriteLine(num1 + "-" + num2 + "=" + (num1 - num2));
            //}
            //else if (ti == "*")
            //{
            //    Console.WriteLine(num1 + "*" + num2 + "=" + (num1 * num2));
            //}
            //else
            //{
            //    Console.WriteLine(num1 + "/" + num2 + "=" + (num1 / num2));
            //}


            //7 задания
            //Console.WriteLine("===Дни недели===");

            //Console.WriteLine("Введите порядковый номер дня недели ");
            //int n = int.Parse(Console.ReadLine());
            //switch (n)
            //{
            //    case 1: Console.WriteLine("Понедельник");break;
            //    case 2: Console.WriteLine("Вторник"); break;
            //    case 3: Console.WriteLine("Среда"); break;
            //    case 4: Console.WriteLine("Четверг"); break;
            //    case 5: Console.WriteLine("Пятница"); break;
            //    case 6: Console.WriteLine("Суббота"); break;
            //    case 7: Console.WriteLine("Воскресения"); break;
            //}


            //8 задания

            //Console.WriteLine("===Мини калькулятор===");
            //Console.WriteLine("Первое число ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Второе число ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Операция (+,-,*,/)");
            //string ti = Console.ReadLine();

            //switch (ti)
            //{
            //    case "+": Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2)); break;
            //    case "-": Console.WriteLine(num1 + "-" + num2 + "=" + (num1 - num2)); break;
            //    case "*": Console.WriteLine(num1 + "*" + num2 + "=" + (num1 * num2)); break;
            //    case "/": Console.WriteLine(num1 + "/" + num2 + "=" + (num1 / num2)); break;
            //}

            //9 задания
            //Console.WriteLine("Введите сложность игры (1-легкий, 2-средний, 3-сложный ");
            //int lvl = int.Parse(Console.ReadLine());

            //switch (lvl)
            //{
            //    case 1: Console.WriteLine("Уровень сложности легкий"); break;
            //    case 2: Console.WriteLine("Уровень сложности средний"); break;
            //    case 3: Console.WriteLine("Уровень сложности сложный"); break;
            //}


            //10 задания
            //static int health = 100; //статическа переменная health с значением 100. Кол-во здоровья игрока.

            //static void Main(string[] args) //статический метод Main. Главная точка входа в программу.
            //{
            //    Console.WriteLine($"Здоровья персонажа: {health}"); //вывод здоровья игрока 
            //    TakeDamage(30); //тут мы вызываем 2 метод и говорим уменьшай здоровья персонажа на 30
            //}
            //static void TakeDamage(int damage) //второй метод когда игрок получит урон
            //{
            //    health -= damage; //уменьшаем значения здоровья на кол-во урона 
            //    Console.WriteLine($"Персонаж получил {damage} урона. Текущее здоровья {health}"); //выводит сколько человек получил урона и текщее здоровья
            //}

            //11 задания 

            //Console.WriteLine("Вебери класс");
            //Console.WriteLine("Воин, маг, разбойник, паладин, варвар, охотник, друид, жрец");
            //string lvl = Console.ReadLine().ToLower();

            //switch (lvl)
            //{
            //    case "воин": Console.WriteLine("Вы ближний бой"); break;
            //    case "маг": Console.WriteLine("Вы дальний бой"); break;
            //    case "разбойник": Console.WriteLine("Вы ближний бой"); break;
            //    case "паладин": Console.WriteLine("Вы ближний бой"); break;
            //    case "варвар": Console.WriteLine("Вы ближний бой"); break;
            //    case "охотник": Console.WriteLine("Вы дальний бой"); break;
            //    case "друид": Console.WriteLine("Вы ближний и дальний бой"); break;
            //    case "жрец": Console.WriteLine("Вы дальний бой"); break;
            //}

            //12 задания 
            
            int s = 0;
            int i = 0;
            for (i = 0; i < 3; i++)  {
                





        }
    }
}