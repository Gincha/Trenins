using System;
using System.Collections.Generic;
using System.Text;

namespace Trenins
{
    class Uzdevumi
    {
        public void Izsauc()
        {
            Uzdevums27();
        }
        private void Uzdevums1()
        {
            int temp;

            Console.WriteLine("Ievadi pirmo nummuru ");
            string pirmais = Console.ReadLine();
            Console.WriteLine("Ievadi otro nummuru ");
            string otrais = Console.ReadLine();

            int pirmais1 = Convert.ToInt16(pirmais);
            int otrais2 = Convert.ToInt16(otrais);

            temp = pirmais1;
            pirmais1 = otrais2;
            otrais2 = temp;

            Console.WriteLine("Pec apmainisanas: ");
            Console.WriteLine("Pirmais nummmurs ir " + pirmais1);
            Console.WriteLine("Otrais nummurs ir " + otrais2);
            Console.ReadLine();
        }

        private void Uzdevums2()
        {
            Console.WriteLine("Ievadi pirmo nummuru");
            String pirmais = Console.ReadLine();
            Console.WriteLine("Ievadi otro nummuru");
            String otrais = Console.ReadLine();
            Console.WriteLine("Ievadi treso nummuru");
            String tresais = Console.ReadLine();

            int viens = Convert.ToInt32(pirmais);
            int divi = Convert.ToInt32(otrais);
            int tris = Convert.ToInt32(tresais);


            Console.WriteLine(viens + "x" + divi + "x" + tris + "=" + (viens * divi * tris));
            Console.ReadLine();
        }
        private void Uzdevums3()
        {

            Console.WriteLine("Ievadi pirmo ciparu");
            String pirmais = Console.ReadLine();
            Console.WriteLine("Ievadi otro ciparu");
            String otrais = Console.ReadLine();


            int viens = Convert.ToInt32(pirmais);
            int divi = Convert.ToInt32(otrais);

            Console.WriteLine(viens + "x" + divi + "=" + (viens * divi));
            Console.WriteLine(viens + "-" + divi + "=" + (viens - divi));
            Console.WriteLine(viens + "/" + divi + "=" + (viens / divi));
            Console.WriteLine(viens + "+" + divi + "=" + (viens + divi));

            Console.ReadLine();
        }

        private void Uzdevums4()
        {

            Console.WriteLine("Ievadi ciparu lai redzetu reizrekina tabulu");
            int cipars = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(cipars + "x" + 1 + "=" + (cipars * 1));
            Console.WriteLine(cipars + "x" + 2 + "=" + (cipars * 2));
            Console.WriteLine(cipars + "x" + 3 + "=" + (cipars * 3));
            Console.WriteLine(cipars + "x" + 4 + "=" + (cipars * 4));
            Console.WriteLine(cipars + "x" + 5 + "=" + (cipars * 5));
            Console.WriteLine(cipars + "x" + 6 + "=" + (cipars * 6));
            Console.WriteLine(cipars + "x" + 7 + "=" + (cipars * 7));
            Console.WriteLine(cipars + "x" + 8 + "=" + (cipars * 8));
            Console.WriteLine(cipars + "x" + 9 + "=" + (cipars * 9));
            Console.WriteLine(cipars + "x" + 10 + "=" + (cipars * 10));

            Console.ReadLine();
        }

        private void Uzdevums5()
        {

            Console.WriteLine("Ievadi 1 no 4 cipariem lai redzetu videjo");
            int cipars1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi 2 no 4 cipariem lai redzetu videjo");
            int cipars2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi 3 no 4 cipariem lai redzetu videjo");
            int cipars3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ievadi 4 no 4 cipariem lai redzetu videjo");
            int cipars4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Videjais no cipariem " + cipars1 + "," + cipars2 + "," + cipars3 + "," + cipars4 + "ir" + ((cipars1 + cipars2 + cipars3 + cipars4) / 4));

            Console.ReadLine();
        }

        private void Uzdevums6()
        {

            Console.WriteLine("Ievadi ciparu");
            string a = Console.ReadLine();

            Console.WriteLine(a + a + a + a);
            Console.WriteLine(a + " " + a + " " + a + " " + a);
            Console.WriteLine(a + a + a + a);
            Console.WriteLine(a + " " + a + " " + a + " " + a);

            Console.ReadLine();
        }

        private void Uzdevums7()
        {

            Console.WriteLine("Ievadi celsija gradus");
            int gradi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvina gradi " + (gradi + 273));
            Console.WriteLine("Farenheita gradi " + (gradi * 18 / 10 + 32));

            Console.ReadLine();



        }

        private void Uzdevums8()
        {
            Console.WriteLine("Ievadied pirmo ciparu");
            String pirmaisCipars = Console.ReadLine();
            double pirmais = Convert.ToDouble(pirmaisCipars);

            Console.WriteLine("Ievadied otro ciparu");
            String otraisCipars = Console.ReadLine();
            double otrais = Convert.ToDouble(otraisCipars);

            Matematika objekts = new Matematika();

            double rezinat = objekts.Saskaitit(pirmais, otrais);
            Console.WriteLine(rezinat);

            Console.ReadLine();
        }

        private void Uzdevums9()
        {

            Console.WriteLine("Ludzu ievadi pirmo skaitli");
            String pirmais = Console.ReadLine();
            int cipars1 = Convert.ToInt32(pirmais);

            Console.WriteLine("Ludzu ievadi otroo skaitli");
            String otraiss = Console.ReadLine();
            int cipars2 = Convert.ToInt32(otraiss);

            if (cipars1 < 0 && cipars2 > 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                if (cipars1 > 0 && cipars2 < 0)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }


        private void Uzdevums10()
        {
            Console.WriteLine("Ludzu ievadi pirmo skaitli");
            String pirmais = Console.ReadLine();
            int cipars1 = Convert.ToInt32(pirmais);

            Console.WriteLine("Ludzu ievadi otroo skaitli");
            String otraiss = Console.ReadLine();
            int cipars2 = Convert.ToInt32(otraiss);

            int rezultats = cipars1 + cipars2;

            if (cipars1 == cipars2)
            {
                Console.WriteLine(rezultats * 3);
            }
            else
            {
                Console.WriteLine(rezultats);
            }
            Console.ReadLine();
        }

        private void Uzdevums11()
        {

            for (int a = 1; a < 100; a++)
            {
                if (a % 2 == 0)
                {
                    Console.Write(a + " , ");
                }
                while (a <= 10)
                {
                    Console.WriteLine(a);
                    a += 2;
                }
            }
        }


        private void Uzdevums12()
        {
            Random numGen = new Random();

            int numOfAttempts = 0;
            int attempt = 0;

            while (attempt != 6)
            {
                attempt = numGen.Next(1, 7);
                Console.WriteLine("Soreiz uzmetam " + attempt + ".");
                numOfAttempts++;

            }
            Console.WriteLine("Mums vajadzeja " + numOfAttempts + "reizes lai uzmestu 6");
            Console.ReadLine();
        }

        private void Uzdevums13()
        {
            Console.WriteLine("Ievadi pirmo ciparu");
            string ievade = Console.ReadLine();
            int cipars1 = Convert.ToInt32(ievade);

            Console.WriteLine("Ievadi pirmo ciparu");
            string ievade2 = Console.ReadLine();
            int cipars2 = Convert.ToInt32(ievade2);

            if (cipars1 > cipars2)
            {
                Console.WriteLine(cipars1);
            }
            else
            {
                Console.WriteLine(cipars2);
            }
        }

        private void Uzdevums14() {
            int temp;

            Console.WriteLine("Ievadi pirmo nummuru ");
            string pirmais = Console.ReadLine();
            Console.WriteLine("Ievadi otro nummuru ");
            string otrais = Console.ReadLine();

            int pirmais1 = Convert.ToInt16(pirmais);
            int otrais2 = Convert.ToInt16(otrais);

            temp = pirmais1;
            pirmais1 = otrais2;
            otrais2 = temp;

            Console.WriteLine("Pec apmainisanas: ");
            Console.WriteLine("Pirmais nummmurs ir " + pirmais1);
            Console.WriteLine("Otrais nummurs ir " + otrais2);
            Console.ReadLine();
        }

        private void Uzdevums15() {
            Console.WriteLine("Ievadi pirmo nummuru");
            String pirmais = Console.ReadLine();
            Console.WriteLine("Ievadi otro nummuru");
            String otrais = Console.ReadLine();
            Console.WriteLine("Ievadi treso nummuru");
            String tresais = Console.ReadLine();

            int viens = Convert.ToInt32(pirmais);
            int divi = Convert.ToInt32(otrais);
            int tris = Convert.ToInt32(tresais);


            Console.WriteLine(viens + "x" + divi + "x" + tris + "=" + (viens * divi * tris));
            Console.ReadLine();
        }

        private void Uzdevums16() {

            Console.WriteLine("Ievadi pirmo ciparu");
            String pirmais = Console.ReadLine();
            Console.WriteLine("Ievadi otro ciparu");
            String otrais = Console.ReadLine();


            int viens = Convert.ToInt32(pirmais);
            int divi = Convert.ToInt32(otrais);

            Console.WriteLine(viens + "x" + divi + "=" + (viens * divi));
            Console.WriteLine(viens + "-" + divi + "=" + (viens - divi));
            Console.WriteLine(viens + "/" + divi + "=" + (viens / divi));
            Console.WriteLine(viens + "+" + divi + "=" + (viens + divi));

            Console.ReadLine();
        }

        private void Uzdevums17() {
            Console.WriteLine("Ievadi ciparu lai redzetu reizrekina tabulu");
            int cipars = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(cipars + "x" + 1 + "=" + (cipars * 1));
            Console.WriteLine(cipars + "x" + 2 + "=" + (cipars * 2));
            Console.WriteLine(cipars + "x" + 3 + "=" + (cipars * 3));
            Console.WriteLine(cipars + "x" + 4 + "=" + (cipars * 4));
            Console.WriteLine(cipars + "x" + 5 + "=" + (cipars * 5));
            Console.WriteLine(cipars + "x" + 6 + "=" + (cipars * 6));
            Console.WriteLine(cipars + "x" + 7 + "=" + (cipars * 7));
            Console.WriteLine(cipars + "x" + 8 + "=" + (cipars * 8));
            Console.WriteLine(cipars + "x" + 9 + "=" + (cipars * 9));
            Console.WriteLine(cipars + "x" + 10 + "=" + (cipars * 10));

            Console.ReadLine();
        }

        private void Uzdevums18() { 
        Console.WriteLine("Ievadi 1 no 4 cipariem lai redzetu videjo");
        int cipars1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ievadi 2 no 4 cipariem lai redzetu videjo");
        int cipars2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ievadi 3 no 4 cipariem lai redzetu videjo");
        int cipars3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ievadi 4 no 4 cipariem lai redzetu videjo");
        int cipars4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Videjais no cipariem " + cipars1 + "," + cipars2 + "," + cipars3 + "," + cipars4 + "ir" + ((cipars1 + cipars2 + cipars3 + cipars4) / 4));

        Console.ReadLine();
        }

        private void Uzdevums19() {
            Console.WriteLine("Ievadi ciparu");
            string a = Console.ReadLine();

            Console.WriteLine(a + a + a + a);
            Console.WriteLine(a + " " + a + " " + a + " " + a);
            Console.WriteLine(a + a + a + a);
            Console.WriteLine(a + " " + a + " " + a + " " + a);

            Console.ReadLine();
        }
        private void Uzdevums20()
        {
            Console.WriteLine("Ievadi celsija gradus");
            int gradi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvina gradi " + (gradi + 273));
            Console.WriteLine("Farenheita gradi " + (gradi * 18 / 10 + 32));

            Console.ReadLine();


            
          }

        private void Uzdevums21()
        {
            Console.WriteLine("Ievadied pirmo ciparu");
            String pirmaisCipars = Console.ReadLine();
            double pirmais = Convert.ToDouble(pirmaisCipars);

            Console.WriteLine("Ievadied otro ciparu");
            String otraisCipars = Console.ReadLine();
            double otrais = Convert.ToDouble(otraisCipars);

            Matematika objekts = new Matematika();

            double rezinat = objekts.Saskaitit(pirmais, otrais);
            Console.WriteLine(rezinat);

            Console.ReadLine();
        }

        private void Uzdevums22()
        {
            Console.WriteLine("Ludzu ievadi pirmo skaitli");
            String pirmais = Console.ReadLine();
            int cipars1 = Convert.ToInt32(pirmais);

            Console.WriteLine("Ludzu ievadi otroo skaitli");
            String otraiss = Console.ReadLine();
            int cipars2 = Convert.ToInt32(otraiss);

            if (cipars1 < 0 && cipars2 > 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                if (cipars1 > 0 && cipars2 < 0)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }

        }

        private void Uzdevums23()
        {
            Console.WriteLine("Ludzu ievadi pirmo skaitli");
            String pirmais = Console.ReadLine();
            int cipars1 = Convert.ToInt32(pirmais);

            Console.WriteLine("Ludzu ievadi otroo skaitli");
            String otraiss = Console.ReadLine();
            int cipars2 = Convert.ToInt32(otraiss);

            int rezultats = cipars1 + cipars2;

            if (cipars1 == cipars2)
            {
                Console.WriteLine(rezultats * 3);
            }
            else
            {
                Console.WriteLine(rezultats);
            }
            
        }

        private void Uzdevums24()
        {

            for (int a = 1; a < 100; a++)
            {
                if (a % 2 == 0) {
                    Console.Write(a + " , ");
                }


                Console.ReadLine();
            }
        }

        private void Uzdevums25()
        {
            
            int a = 1;
            while (a <= 10)
            {
                Console.WriteLine(a);
                a+=2; 
            }
         }


        private void Uzdevums26()
        {

            Random numGen = new Random();

        int numOfAttempts = 0;
        int attempt = 0;

            while (attempt != 6)
            {
                attempt = numGen.Next(1, 7);
                Console.WriteLine("Soreiz uzmetam " + attempt + ".");
                numOfAttempts++;

            }
    Console.WriteLine("Mums vajadzeja " + numOfAttempts + "reizes lai uzmestu 6");
            
        }

        private void Uzdevums27()
        {
            string zvaigzne = "*";
            string atmina = "";
            Console.WriteLine("Ievadi rindu skaitu");
            string input = Console.ReadLine();
            int ievade = Convert.ToInt32(input);
            string[] arrays = new string[ievade];

            for (int i=0; i<ievade; i++)
            {
                arrays[i] = atmina + zvaigzne;
                atmina = arrays[i];
            }

            for (int i=0; i<ievade; i++)
            {
                Console.WriteLine(arrays[i]);
            }

            for (int i = ievade-1; i >= 0; i--)
            {
                Console.WriteLine(arrays[i]);
            }
        }

    }


}

