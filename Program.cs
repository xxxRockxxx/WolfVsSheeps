using System;

namespace WolfsVsSheeps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру <Овцы против волков>.\nПравила очень просты." +
                "Вы будете наблюдать процесс как овцы пытаются выжить а волки съесть их.Кто вымрет а кто останется жить решит рандом\n" +
                "Введите количество овец:");
            int Sheeps = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество волков");
            int Woolfs = int.Parse(Console.ReadLine());
            Animal animal = new Animal();
            Sheeps sheep = new Sheeps();
            Wolfs wolf = new Wolfs();
            Matrix matrix = new Matrix();
            int numberOfAnimals = Sheeps + Woolfs;
            animal.GenerationMatrix(numberOfAnimals);
            sheep.GenerationSheepinMatrix(Sheeps);
            wolf.GenerationWolfsinMatrix(Woolfs);
            matrix.DrawMatrix();
            bool work = matrix.Work;
            while (work)
            {
                sheep.MoveSheeps();
                wolf.MoveWolfs();
                matrix.DrawMatrix();
                work = matrix.Work;
            }
            if (work == false)
            {
                Console.WriteLine("Игра закончилась");
            }
        }
    }
}
