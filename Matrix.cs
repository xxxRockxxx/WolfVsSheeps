using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolfsVsSheeps
{
    class Matrix:Animal
    {
        public void DrawMatrix()
        {
            Console.Clear();
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Количество живых овец на поле:" + _countSheeps);
            Console.WriteLine("Количество живых волков на поле:" + _countWolfs+"\nнажмите Enter,чтобы сделать следующий ход");
            Console.WriteLine("Check:" + _numberOfmoves);
            Console.ReadKey();
        }
        public bool Work 
        {
            get
            {
                return _WokrGame;
            }
            
        }
    }
}
