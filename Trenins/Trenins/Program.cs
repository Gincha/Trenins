using System;

namespace Trenins
{
    class Program
    {
        static void Main(string[] args)
        {
             Matematika darbibas = new Matematika();
             Uzdevumi uzd = new Uzdevumi();
            Pokemoni uzdevums = new Pokemoni();

            uzd.Izsauc();

            Console.ReadLine();
        }
    }
}
