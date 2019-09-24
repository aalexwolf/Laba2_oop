using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;
            Console.WriteLine("bool: " + isTrue);

            string name = "Tom";
            Console.WriteLine("string: " + name);

            byte bit1 = 1;
            Console.WriteLine("byte: " + bit1);

            char cymbol = 'A';
            Console.WriteLine("char: " + cymbol);

            int num = 2019;
            Console.WriteLine("int: " + num);

            double k = 9.9999;
            Console.WriteLine("double: " + k);

            int a = 4;
            int b = 6;
            double x = 1234.7;
            byte c = (byte)(a + b); //явное преобразование
            int i = (int)x; //явное преобразование
            double d = a; //неявное преобразование
            long l = b; //неявное преобразование

            int number = 10;
            //boxing
            object obj = number;
            //unboxing
            int j = (int)obj;

            //неявно типизированные переменные
            var surname = "Volchkov";
            var age = 18;
            Console.WriteLine("Тип name: " + surname.GetType());
            Console.WriteLine("Тип age: " + age.GetType());

            //nullable
            int? z1 = null;
            int? z2 = 5;
            Console.WriteLine("Хранит ли z1 нект-е значение? -" + z1.HasValue);
            Console.WriteLine("Хранит ли z2 нект-е значение? -" + z2.HasValue);
            Console.WriteLine("Значение z2: " + z2.Value);

            //сравнить строки
            string s1 = "Hello world!", s2 = "Hello world!";
            if (s1 == s2)
                Console.WriteLine("Строки s1 И s2 равны");
            else Console.WriteLine("Строки s1 И s2 неравны");

            //сцепление, копирование, выделение подстроки, 
            //разделение строки на слова, вставки подстроки в заданную позицию, удаление заданной подстроки
            string str1 = "hello";
            string str2 = "world";
            string str3 = String.Concat(str1, str2); // объединение строк

            string text = "Хороший день";
            string str4 = text.Substring(2); //выделение подстроки
            Console.WriteLine(str4);

            String s = "Разделение строки на слова";
            String[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int ind = 0; ind<words.Length; ind++)
            Console.WriteLine(words[ind]);

            string text2 = "Хороший день";
            string subString = "замечательный ";
            text2 = text2.Insert(8, subString); //вставка подстроки в заданную позицию
            Console.WriteLine(text2);
            text2 = text2.Remove(8, 14); //удаление заданной подстроки
            Console.WriteLine(text2);
          

            //Создайте пустую и null строку. Продемонстрируйте что можно выполнить с такими строками
            string emptystr = "";
            string nullstr = null;
            Console.WriteLine(emptystr.Length); //метод Length для пустой строки
            //сравнение строк
            if (emptystr == nullstr)
                Console.WriteLine("Строки равны");
            else Console.WriteLine("Строки empystr & nullstr неравны");
            string resStr = emptystr + nullstr;
            Console.WriteLine(resStr);


            //Создайте строку на основе StringBuilder. Удалите определенные позиции и добавьте новые символы в начало и конец строки.
            StringBuilder sb = new StringBuilder("Строка на основе StringBuilder");
            Console.WriteLine(sb);
            sb.Remove(8, 2); //удаление позиций
            Console.WriteLine(sb);
            sb.Insert(0, "Это "); //в начало
            Console.WriteLine(sb);
            sb.Insert(sb.Length, ". Конец."); //в конец
            Console.WriteLine(sb);
            

            //a.Создайте целый двумерный массив и выведите его на консоль в отформатированном виде(матрица). 
            int[,] matrix = { { 0, 19, 27 }, { 3, 12, 29 }, { 25, 44, 81 }, { 31, 0, 52 }, { 11, 4, 21 } };
            for (int q = 0; q<5; q++)
            {
                for (int q2 = 0; q2 < 3; q2++)
                    Console.Write(matrix[q, q2] + "\t");
                Console.Write("\n");
            }

            //b.	Создайте одномерный массив строк. Выведите на консоль его содержимое, длину массива.
            //Поменяйте произвольный элемент (пользователь определяет позицию и значение).
            for (int y = 0; y < words.Length; y++)
                Console.Write(words[y] + ", "); Console.WriteLine();
            Console.WriteLine("Введите номер элемента, который хотите заменить(0-3): ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение элемента, который хотите заменить: ");
            words[index] = Console.ReadLine();
            for (int y = 0; y < words.Length; y++)
                Console.Write(words[y] + ", "); Console.WriteLine();

            //c.	Создайте ступечатый (не выровненный) массив вещественных чисел с 3-мя строками,
            //в каждой из которых 2, 3 и 4 столбцов соответственно. Значения массива введите с консоли.
            int[][] steppedArr = { new int[2], new int[3], new int[4] };
            for (int q = 0; q < 3; q++)
            {
                for (int q2 = 0; q2 < steppedArr[q].Length; q2++)
                {
                    Console.WriteLine("Введите элемент [" + q + "]" + "[" + q2 + "]");
                    steppedArr[q][q2] = int.Parse(Console.ReadLine()); 
                }
            }
            for (int q = 0; q < 3; q++)
            {
                for (int q2 = 0; q2 < steppedArr[q].Length; q2++)
                {
                    Console.Write(steppedArr[q][q2] + "\t");
                }
                Console.WriteLine();
            }


            //d.	Создайте неявно типизированные переменные для хранения массива и строки.э
            var myArr = new[] { 1, 3, 4, 5, 6, 6, 35, 56, 24, 23, 1, 0, 7, 43};
            var myStr = "Неявно типизированная строка";




            //a.	Задайте кортеж из 5 элементов с типами int, string, char, string, ulong. 
            (int, string, char, string, ulong) person = (18, "Alexey", 'm', "Volchkov", 2001);

            //b.	Выведите кортеж на консоль целиком и выборочно ( например 1, 3, 4  элементы)
            Console.WriteLine(person);
            Console.WriteLine(person.Item1); Console.WriteLine(person.Item3); Console.WriteLine(person.Item4);

            //c.	Выполните распаковку кортежа в переменные.
            (var number1, var number2) = ("123", 456);

            //d.	Сравните два кортежа.
            (int, string, char, string, ulong) person2 = (17, "Andrew", 'm', "Norris", 2002);
            if (person == person2)
                Console.WriteLine("Кортежи равны");
            else Console.WriteLine("Кортежи неравны");
            Console.WriteLine(myFunction(myArr, myStr));
            Console.Read();

            //5)	Создайте локальную функцию в main и вызовите ее. 
            //Формальные параметры функции – массив целых и строка. 
            //Функция должна вернуть кортеж, содержащий: максимальный 
            //и минимальный элементы массива, сумму элементов массива и первую букву строки.
            (int, int, int, char) myFunction(int[] A, string sst)
            {
                int max = 0, min = 99, summ = 0;
                for (int ik = 0; ik < A.Length; ik++)
                {
                    if (A[ik] > max)
                        max = A[ik];
                    if (A[ik] < min)
                        min = A[ik];
                    summ += A[ik];
                }
                (int, int, int, char) result = (min, max, summ, sst[0]);
                return result;
            }
        }
    }
}
