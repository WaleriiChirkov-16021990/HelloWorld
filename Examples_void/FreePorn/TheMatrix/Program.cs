// using System;
// using System.Linq;
using System.Text;
// using System.Threading;

namespace ConsoleMatrixEffect
{

    // для того, чтобы растянуть консоль на весь экран, нажмите Alt+Enter
    static class Program
    {

        private const int delay = 40;

        static void Main(string[] args)
        {
            Console.ReadKey();
            SetConsoleParams();

            // задаю Матрицу в размер консольного окна
            var consoleMatrix = new ConsoleMatrix(Console.WindowWidth, Console.WindowHeight);

            var cycle = 1; // счетчик цикла. Нужен для регулирования скорости различных столбцов
            do
            {
                consoleMatrix.ShowMatrix();
                Thread.Sleep(delay);
                consoleMatrix.ShiftMatrixElements(cycle);
                cycle = ((cycle + 1) % 1000); // ограничиваю переменную, чтобы не случилось переполнение int
            } while (!Console.KeyAvailable);
        }

        private static void SetConsoleParams()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = false;
        }
    }

    public class ConsoleMatrix
    {
        // символы которые будут использоваться для матрицы
        //private static readonly char[] _symbols = "¢£¥§gYhjHwWÞßĦŠŊŁþøðÖ ".ToCharArray(); //если консольный шрифт поддерживает Unicode
        private static readonly char[] _symbols = "&%#$@*(@YyuUjJhwLHFfsqVNnv ".ToCharArray();
        private readonly int _symbolsLen = _symbols.Length;

        // матрица
        private char[][] _matrix;
        private readonly int _width;
        private readonly int _height;

        private readonly Random _rand = new Random(); // задаю глобальный рандомизатор для символов.
        private const int period = 26; // для вычисления скорости столбцов

        /// <summary>
        ///
        /// </summary>
        /// <param name="width">Ширина окна консоли</param>
        /// <param name="height">Высота окна консоли</param>
        public ConsoleMatrix(int width, int height)
        {
            _width = width;
            _height = height;
            CreateMatrix();
        }

        /// <summary>
        /// Заполняю первоначальную матрицу
        /// </summary>
        private void CreateMatrix()
        {
            // матрица - массив с массивами символов
            _matrix = new char[_height][];

            for (var h = 0; h < _height; h++)
            {
                // заполняю строки символами. Каждый второй символ - пробел, формирования пустых столбцов
                _matrix[h] =
                    // Создание последовательности 1..N. Можно использовать вместо стандартных циклов
                    Enumerable.Range(0, _width)
                        .Select(position => (position + 1) % 2 == 0
                                ? ' ' // пробел нужен для формирования пустых столбцов
                                : _symbols[_rand.Next(0, _symbolsLen)])
                        .ToArray();
            }
        }

        /// <summary>
        /// Печатаю матрицу в консоли
        /// </summary>
        public void ShowMatrix()
        {
            // сбрасываю позицию курсока в начальную позицию
            Console.SetCursorPosition(0, 0);

            // вывожу символы построчно
            for (var h = 0; h < _height; h++)
            {
                var s = new string(_matrix[h]); // делаю из массива символов одну строку, т.к. печать одной строки намного быстрее, чем печать символов по одному
                if (h < _height - 1) Console.WriteLine(s);
                else Console.Write(s); // последнюю строку печатаю без переноса, чтобы не образовалась пустая строка внизу
            }
        }

        /// <summary>
        /// Метод для сдвига символов в столбцах
        /// </summary>
        /// <param name="cycle"></param>
        public void ShiftMatrixElements(int cycle)
        {
            for (var w = 0; w < _width; w += 2) // каждый второй столбец пустой
            {
                if (w % period > cycle % period) continue; // регулирую скорость для разных столбцов

                // сдвигаю все символы в столбце вниз на один символ
                for (var h = _height - 1; h >= 0; h--)
                {
                    // для первой строки добавляю случайный символ
                    if (h == 0)
                    {
                        _matrix[h][w] = _symbols[_rand.Next(0, _symbolsLen)];
                        continue;
                    }
                    // перемещаю вышестоящий символ в текущую строку
                    _matrix[h][w] = _matrix[h - 1][w];
                }
            }
        }
    }
}