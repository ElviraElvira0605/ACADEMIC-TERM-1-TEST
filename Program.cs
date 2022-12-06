//Написать программу, которая из имеющегося массива
//строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма.
//При решении   использовать  исключительно массивы.

// НАПРИМЕР: 
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


using System;

namespace Word3
{
    class Program
    {
        // Для входного массива строк src вернуть
        // массив строк, длина которых не больше 3
        static string[] Func(string[] src)
        {
            // Результирующий массив строк
            string[] res;

            // Размер результирующего массива
            int size;

            // Определяем количество подходящих строк для результирующего массива
            size = 0;
            foreach (string v in src)
            {
                if (v.Length <= 3)
                    ++size;
            }

            // Результат пуст?
            if (size == 0)
                return null;

            // Создаем результирующий массив
            res = new string[size];

            // Копируем в него соответствующие строки
            size = 0;
            foreach (string v in src)
            {
                if (v.Length <= 3)
                    res[size++] = v;
            }

            return res;
        }

        // Информация о задании
        private readonly static string info =
        "Написать  программу, которая из имеющегося  массива строк  формирует\n" +
        "новый массив из строк, длина которых меньше, либо  равна 3 символам.\n" +
        "Первоначальный массив ввести с клавиатуры с предварительным заданием\n" +
        "количества слов исходного массива\n";

        static void Main()
        {
            // Размер исходного массива
            int size;

            // Исходный массив строк
            string[] src;

            // Результирующий массив строк
            string[] res;

            // Строка ввода
            string str;

            // Печать информации о задании
            Console.WriteLine(info);

            // Вводим и контролируем размер исходного массива
            for (;;)
            {
                // Приглашение для ввода
                Console.Write("Размер исходного массива: ");

                if ((str = Console.ReadLine()).TrimEnd() == "")
                {
                    Console.WriteLine("Размер не введен");
                    continue;
                }

                if (!Int32.TryParse(str, out size))
                {
                    Console.WriteLine("Размер ошибочен");
                    continue;
                }

                if (size >= 1 && size <= 20)
                    break;

                Console.WriteLine("Размер не в диапазоне [1...20]");
            }

            // Создаем исходный массив
            src = new string[size];

            // Вводим непустые строки с удаленными
            // хвостовыми пустыми символами
            Console.WriteLine("");
            for (int i = 0; i < size; ++i)
            {
                for (;;)
                {
                    Console.Write(String.Format("[{0,2}] = ", i));
                    if ((str = Console.ReadLine()).TrimEnd() != "")
                        break;
                    Console.WriteLine("Строка не введена");
                }
                src[i] = str;
            }

            // Выполним исходное задание
            res = Func(src);

            // Печатаем результат
            if (res == null)
                Console.WriteLine("\nРезультирующий массив пуст");
            else
            {
                Console.WriteLine("\nРезультирующий массив:\n");
                foreach (string v in res)
                    Console.WriteLine(v);
            }

            // Пауза перед завершением работы
            Console.Write("\nДля завершения работы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}


