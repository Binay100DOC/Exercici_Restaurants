using System;
using System.Collections.Generic;

namespace Exercici_Restaurants
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fase 1
            int billetCinc = 5;
            int billetDeu = 10;
            int billetVint = 20;
            int billetCinquanta = 50;
            int billetCent = 100;
            int billetDosCents = 200;
            int billetCincCents = 500;

            int preuTotalMenjar = 0;

            string[] plats = new string[5];
            int[] preus = new int[5];

            //Fase 2
            var keepDoing = true;

            for(int i = 0; i<plats.Length; i++)
            {
                Console.WriteLine("Escriu el nom de {0} plat:", i + 1);
                plats[i] = Console.ReadLine().ToLower();
            }
            for(int i = 0; i< preus.Length; i++)
            {
                Console.WriteLine("Escriu els preus dels plats corresponents:");
                int preusComInt;
                Int32.TryParse(Console.ReadLine(), out preusComInt);
                preus[i] = preusComInt;
            }

            for(int i = 0; i<preus.Length; i++)
            {
                Console.WriteLine("{0} Plat= {1} i el preu= {2}", i + 1, plats[i], preus[i]);
            }

            var llistaDePlatsDemanats = new List<string>();
            
            while (keepDoing)
            {
                Console.WriteLine("Que es el que voleu menjar?\n Presiona 1 per parar de demanar.");
                var platsDemanats = Console.ReadLine();
                int pararDeDemanar = 1;
                if(platsDemanats == pararDeDemanar.ToString())
                {
                    keepDoing = false;
                }
                else
                {
                    var esUnNumero = 0;
                    if(int.TryParse(platsDemanats,out esUnNumero))
                    {
                        Console.WriteLine("Siusplau només poseu el nom com string i no un numero.");
                    }
                    else
                    {
                        llistaDePlatsDemanats.Add(platsDemanats.ToLower());
                    }
                    
                }
            }

            int precioTotal=0;
            for (int i = 0; i < llistaDePlatsDemanats.Count; i++)
            {
                int counter = 0;
                int valueOfJ = 0;
                for(int j = 0; j < plats.Length; j++)
                {
                    if(llistaDePlatsDemanats[i] == plats[j])
                    {
                        counter++;
                        valueOfJ = j;
                    }
                }
                
                if (counter.Equals(0))
                {
                    Console.WriteLine("El plato {0} no existe", llistaDePlatsDemanats[i]);
                }
                else
                {
                    Console.WriteLine("El plato {0} si existe. El precio total de este plato es de {1}",llistaDePlatsDemanats[i], preus[valueOfJ]);
                }
                precioTotal += counter * preus[valueOfJ];
            }
            Console.WriteLine("El precio total de toda la comida es de {0} euro.", precioTotal);
            if (precioTotal <= 5)
            {
                Console.WriteLine("El precio total de platos es de {0} y puedes pagar con billete de 5 euro.", precioTotal);
            }
            else if(precioTotal>5 && 10 >= precioTotal)
            {
                Console.WriteLine("El precio total de platos es de {0} y puedes pagar con billete de 10 euro.", precioTotal);
            }
            else if (precioTotal > 10 && 20 >= precioTotal)
            {
                Console.WriteLine("El precio total de platos es de {0} y puedes pagar con billete de 20 euro.", precioTotal);
            }
            else if (precioTotal > 20 && 50 >= precioTotal)
            {
                Console.WriteLine("El precio total de platos es de {0} y puedes pagar con billete de 50 euro.", precioTotal);
            }
            else if (precioTotal > 50 && 100 >= precioTotal)
            {
                Console.WriteLine("El precio total de platos es de {0} y puedes pagar con billete de 100 euro.", precioTotal);
            }
            else if (precioTotal > 100 && 200 >= precioTotal)
            {
                Console.WriteLine("El precio total de platos es de {0} y puedes pagar con billete de 200 euro.", precioTotal);
            }
            else if (precioTotal > 200 && 500 >= precioTotal)
            {
                Console.WriteLine("El precio total de platos es de {0} y puedes pagar con billete de 500 euro.", precioTotal);
            }
            else
            {
                Console.WriteLine("Tendrá que pagar con billete de 500 euro + {0} euro con el billete correspondiente.", precioTotal
                    );
            }
            Console.ReadLine();
        }
        
    }
}
