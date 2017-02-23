using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pruebafebrero2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, total=0;  //declaro una variable o defino.
            Console.Clear();     //limpio la pantalla.
            Console.SetCursorPosition(5, 3);
            Console.Write("entre un numero ");
            num1 = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(5, 4);
            Console.Write("digite otro numero ");
            num2 = int.Parse(Console.ReadLine());
            total = num1 + num2;
            Console.SetCursorPosition(5, 7);
            Console.Write("el resultado de la suma es = ", total); Console.Write(total);
            Console.SetCursorPosition(5, 9);
            Console.Write("fin de la operacion");
            Console.ReadLine();
        }
    }
}
