using System;
using ExercicioJogos.src.Entities;

namespace _04_ExercicioJogos
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 30, "Knight");
            Wizard wizard = new Wizard("Jenica", 30, "White Wizard");
            Archer archer = new Archer("Yuna", 28, "Archer");
            Ninja ninja = new Ninja("Wedge", 25, "Ninja");

            Console.WriteLine(knight);
            Console.WriteLine(knight.Attack());

            Console.WriteLine(wizard);
            Console.WriteLine(wizard.Attack(2));

            Console.WriteLine(archer);
            Console.WriteLine(archer.Attack(7));

            Console.WriteLine(ninja);
            Console.WriteLine(ninja.Attack());
        }
    }
}
