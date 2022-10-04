using System;
using System.IO;

namespace CatAndMouse
{
    class Program
    {
        static int fieldSize;
        static int catMove;
        static int mouseMove;
        static int catPosition = -1;
        static int mousePosition = -1;

        static void ReadAndProcessData(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            fieldSize = int.Parse(reader.ReadLine()); //читаем размер поля
            char command;
            while (!reader.EndOfStream)
            {
                command = Convert.ToChar(reader.Read()); //читаем команду из файла
                switch (command)
                {
                    case 'M' : mouseMove = int.Parse(reader.ReadLine());
                               //вывод  - для проверки правильности чтения данных из файла
                               Console.WriteLine($"{command}    {mouseMove}"); 
                               MoveMouse(mouseMove); //двигаем мышь
                               break;
                    case 'C' : catMove = int.Parse(reader.ReadLine());
                               Console.WriteLine($"{command}    {catMove}");
                               MoveCat(catMove); //двигаем кота
                        break;
                    case 'P' : Print(catPosition, mousePosition);
                               reader.ReadLine();
                               Console.WriteLine($"{command}");
                               break;
                }
            }
            reader.Close();
        }

        static void Print(int catPosition, int mousePosition) { }
        static void MoveCat(int steps) { }
        static void MoveMouse(int steps) { }

        static void Main(string[] args)
        {
            ReadAndProcessData("2.ChaseData.txt");
        }
    }
}
