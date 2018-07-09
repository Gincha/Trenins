using System;
using System.Collections.Generic;
using System.Text;

namespace Trenins
{
    class Uzdevumi
    {
        public void Izsauc()
        {
            Uzdevums48();
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
                a += 2;
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

            for (int i = 0; i < ievade; i++)
            {
                arrays[i] = atmina + zvaigzne;
                atmina = arrays[i];
            }

            for (int i = 0; i < ievade; i++)
            {
                Console.WriteLine(arrays[i]);
            }

            for (int i = ievade - 1; i >= 0; i--)
            {
                Console.WriteLine(arrays[i]);
            }
        }

        private void Uzdevums28()
        {

            Console.WriteLine("Ievadi vardu");
            string ievade = Console.ReadLine();
            char[] vards = ievade.ToCharArray();
            char[] svitras = ievade.ToCharArray();

            for (int i = 0; i < vards.Length; i++)  //sadala minamo vardu pa burtiem
            {
                // Get character from array.
                char burts = vards[i];
            }

            char stripa = '-';
            //pec copy/paste vairs kludu nerada
            for (int i = 0; i < vards.Length; i++)   // tads pats garums ka minamajam vardam 
            {
                svitras[i] = stripa;
                char stripBurts = svitras[i];

            }

            Console.WriteLine("Sakam");

            int skaititajs = 0;                  //minesim 10 reizes
            do
            {
                skaititajs++;
                Console.WriteLine("Ievadi minejumu");
                string ievade2 = Console.ReadLine();
                char minejums = Convert.ToChar(ievade2);        //ievada burtu

                string virkne = "";
                string atmina = "";
                for (int i = 0; i < vards.Length; i++)      //katram minejumam jaiet cauri visam arrayam ar minamo vardu
                {
                    char burts = vards[i];      //bez rindinas neatpazist mainigo if`a

                    if (minejums == burts)          //ja minejums sakrit ar burtu minamaja varda
                    {
                        virkne = virkne + vards[i];     //ja sakrit burti tad parada burtu istaja vieta
                    }
                    else
                    {
                        virkne = virkne + svitras[i];       //ja nesakrit burti tad ieliek svitrinu burta vieta
                    }
                }

                atmina = atmina + virkne;
                Console.WriteLine(atmina);          //parada tikai 1 ciklu, nesaglaba ieprieksejos


            } while (skaititajs != 10);     //iet cauri kamer nav 10 reizes

            Console.WriteLine("Meginajumu skaits beidzies. Minamais vards bija - " + ievade);
            Console.ReadLine();
        }

        private void Uzdevums29()
        {
            string[] kopa = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ievadi " + (i + 1) + ". elementu");
                string ievade = Console.ReadLine();
                kopa[i] = ievade;
            }

            for (int i = 9; i >= 0; i--)
            {
                Console.Write(kopa[i] + " ");
            }

        }

        private void Uzdevums30()
        {
            Console.WriteLine("Ievadi robezu");
            string ievade = Console.ReadLine();
            int robeza = Convert.ToInt32(ievade);

            int summa = 0;
            for (int i = 1; i <= robeza; i += 2)
            {
                summa = summa + i;
            }

            Console.Write("Summa ir " + summa);
        }

        private void Uzdevums31()
        {
            Console.WriteLine("Ievadi pirmo skaitli");
            string ievade = Console.ReadLine();
            int a = Convert.ToInt32(ievade);

            Console.WriteLine("Ievadi otro skaitli");
            string ievade2 = Console.ReadLine();
            int b = Convert.ToInt32(ievade);

            for (int i = (a - b); i < a; i++)
            {
                Console.Write(i);           //nerada tikai starpibas skaitlus ???
            }
        }

        private void Uzdevums32()
        {
            float[] temp = new float[7];
            float MaxVertiba = int.MinValue;
            float MinVertiba = int.MaxValue;

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Ieraksti temperaturu");
                string input = Console.ReadLine();
                float cipars;
                Single.TryParse(input, out cipars);

                temp[i] = cipars;

                if (cipars > MaxVertiba)
                {
                    MaxVertiba = cipars;
                }
                if (cipars < MinVertiba)
                {
                    MinVertiba = cipars;
                }
            }

            Console.WriteLine("Lielaka vertiba ir " + MaxVertiba);
            Console.WriteLine("Mazaka vertiba ir " + MinVertiba);
        }

        private void Uzdevums33()
        {
            int LastInt = 0;
            Console.WriteLine("Ieraksti temperaturu");
            string input = Console.ReadLine();
            int ievade = Convert.ToInt32(input);

            for (int i = 0; i <= ievade; i++)
            {
                for (int a = 0; a < i; a++)
                {
                    if (LastInt == 1)
                    {
                        Console.Write(0);
                        LastInt = 0;

                    } else
                    {
                        Console.Write(1);
                        LastInt = 1;
                    }

                }
                Console.WriteLine();
            }

        }

        private void Uzdevums34()
        {
            int result = 0;
            Console.WriteLine("Ieraksti skaitli");
            string input = Console.ReadLine();
            char[] cipari = input.ToCharArray();

            for (int i = 0; i < cipari.Length; i++)
            {
                char cipars = cipari[i];
            }

            Console.WriteLine("Ieraksti ciparu kuru meklet");
            string meklet = Console.ReadLine();
            char mekle = Convert.ToChar(meklet);

            for (int i = 0; i < cipari.Length; i++)
            {
                if (mekle == cipari[i])
                {
                    result++;
                }
            }

            Console.WriteLine("Dotais cipars paradas " + result + " reizes.");
        }

        private void Uzdevums35()
        {
            Console.WriteLine("Ieraksti skaitli");
            string input = Console.ReadLine();
            int garums = Convert.ToInt32(input);

            Console.WriteLine("Ieraksti skaitli");
            string input2 = Console.ReadLine();
            int augstums = Convert.ToInt32(input2);

            string zvaigzne = "*";
            string atstarpe = " ";
            string atmina = "";
            int j;

            for (int i = 0; i < garums; i++)
            {
                Console.Write(zvaigzne);
            }
            Console.WriteLine();
            for (int b = 0; b < augstums - 2; b++)
            {
                Console.Write(zvaigzne);

                for (j = 1; j < garums; j++)
                {
                    if (j < garums - 1)
                    {
                        Console.Write(atstarpe);
                    } else
                    {
                        Console.Write(zvaigzne);
                    }
                } Console.WriteLine();
            }
            for (int i = 0; i < garums; i++)
            {
                Console.Write(zvaigzne);
            }
        }

        private void Uzdevums36()
        {
            int[] cipari = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ieraksti skaitli");
                string input1 = Console.ReadLine();
                cipari[i] = Convert.ToInt32(input1);

            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    if (cipari[i] > cipari[j])
                    {
                        int temp = cipari[i];
                        cipari[i] = cipari[j];
                        cipari[j] = temp;
                    }
                }
            }
            Console.WriteLine("Pec sakartosanas");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(cipari[i]);
            }


        }

        private void Uzdevums37()
        {
            int[] skaitli = new int[10];
            int atmina;
            atmina = int.MinValue;
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Ievadi skaitlus no 1 lidz 100");
                string ievade = Console.ReadLine();
                skaitli[i] = Convert.ToInt32(ievade);

                if (skaitli[i] >= 1 & skaitli[i] <= 100)
                {
                    if (skaitli[i] > atmina)
                    {
                        atmina = skaitli[i];
                    }
                    else
                    {
                        Console.WriteLine("Nepareiza ievade");
                    }
                }

            }

            Console.WriteLine("Lielakais skaitlis ir " + atmina);
        }

        private void Uzdevums38()                               
        {
            int[] skaitli = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ievadi skaitli no 1 lidz 50");
                string ievade1 = Console.ReadLine();
                skaitli[i] = Convert.ToInt32(ievade1);
            }

            Console.WriteLine("Ievadi skaitli kuru atrast");
            string ievade = Console.ReadLine();
            int skaitlis = Convert.ToInt32(ievade);

            for (int i = 0; i < 10; i++)
            {
                if (skaitlis == skaitli[i])
                {
                    Console.WriteLine(skaitlis + " is in the array");

                }
            }
        }

        private void Uzdevums39()
        {

            int[] kopa = new int[10];
            int i;

            for( i=0; i<10; i++)
            {
                kopa[i] = - 113;
            }
            for (i=0; i<10; i++)
            {
                Console.WriteLine("Slota " + i + " vertiba ir " + kopa[i]);
            }
            
        }

        private void Uzdevums40()
        {
            int[] kopa = new int[10];
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Iedode vertibu arrayam");
                string input = Console.ReadLine();
                kopa[i] = Convert.ToInt32(input);
            }

            Array.Sort(kopa);

            for (i=0; i<10; i++)
            {
                Console.Write(kopa[i]);
            }
        }

        private void Uzdevums41()
        {
            int a = 0;
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 7, 9, 14 };
            Console.Write("Array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine("");
            Console.Write("Value to find:");
            int tofind = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                if (tofind == arr[i])
                {
                    a++;
                }
            }
            Console.WriteLine(tofind + " was found " + a + " times");
        }

        private void Uzdevums43()           //saskaitit vardus ar pedejo burtu y vai z.
        {
            int count = 0;
            Console.WriteLine("Enter a string to check");
            string Sinput = Console.ReadLine();
            string[] Words = Sinput.Split(' ');
            for (int i = 0; i < Words.Length; i++)
            {
                if ((Words[i] != "") && ((Words[i][Words[i].Length - 1] == 'y') || (Words[i][Words[i].Length - 1] == 'Y') || (Words[i][Words[i].Length - 1] == 'z') || (Words[i][Words[i].Length - 1] == 'Z')))
                    count++;
            }
            Console.WriteLine("count :" + count);
        }

        private void Uzdevums44()
        {
            int summa = 0;
            Console.WriteLine("Ieraksti ciparu");
            string input = Console.ReadLine();
            int ievade = Convert.ToInt32(input);
            if (ievade != 0)
            {
                for (int i = 0; i <= ievade; i++)
                {
                    Console.Write(i);
                    summa = summa + i;
                }
            }

            Console.WriteLine(summa);
        }

        private void Uzdevums45()
        {

            Console.WriteLine("Ieraksti vardu");
            string input = Console.ReadLine();
            if (input == "Mitchell")
            {
                for (int i=0; i<5; i++)
                {
                    Console.WriteLine(input);
                }
            }
            for (int i=0; i<10; i++)
            {
                Console.WriteLine(input);
            }
        }

        private void Uzdevums46()
        {
            int randomNum;
            randomNum = 18;

            int numOfTries = 0;
            int guess;
            Console.Write("I am thinking of a number between 1-100. You have 7 guesses:\n");

            while (numOfTries != 8)
            {
                numOfTries++;
                if (numOfTries == 8)
                {
                    Console.WriteLine("Sorry you didn't guess it in 7 tries. You lose.");
                    break;
                }
                string input =Console.ReadLine();
                guess = Convert.ToInt32(input);

                if (guess < randomNum)
                {
                    Console.WriteLine("Too Low");
                    
                }
                else
                {
                    if (guess > randomNum)
                    {
                        Console.WriteLine("Too high");
                        
                    }
                    else
                    {
                        Console.WriteLine("Correct.You won!");
                        break;
                    }
                }

            }
        }

        private void Uzdevums47()
        {

            for (double x=-10; x<=10; x+=0.5)
            {
                double y = x * x;
                Console.WriteLine(x + " " + y);
            }
        }

        private void Uzdevums48()
        {
            for (double x = 1; x <= 20; x ++)
            {
                if (x % 2 != 0)
                {
                    Console.WriteLine(x);
                }
                else 
                {
                    Console.WriteLine(x +"<");
                }

            }
        }
    }
}

