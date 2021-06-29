using System;
using System.Threading;

namespace tpfinalv3
{
    class Program
    {
        static void Main(string[] args)
        {
            carrera();
            //liebre();
            //tortuga();
        }
        static void carrera()
        {
            Console.WriteLine("");
            var ran = new Random();
            int tiempoLiebre = 0;
            int tiempoTortuga = 0;
            int posLiebre = 0;
            int posTortuga = 0;
            while (posLiebre < 70 && posTortuga < 70)
            {
                var probaLiebre = ran.Next(1, 101);
                var probaTortuga = ran.Next(1, 101);
                //Liebre
                if (probaLiebre >= 1 && probaLiebre <= 20)
                {
                    posLiebre = posLiebre + 0; //Duerme
                    if (posLiebre < 1)
                    {
                        posLiebre = 1;
                    }
                }
                else if (probaLiebre >= 21 && probaLiebre <= 40)
                {
                    posLiebre = posLiebre + 9; // Gran salto
                    if (posLiebre < 1)
                    {
                        posLiebre = 1;
                    }


                }
                else if (probaLiebre >= 41 && probaLiebre <= 50)
                {
                    posLiebre = posLiebre - 12; //Resbalón Grande
                    if (posLiebre < 1)
                    {
                        posLiebre = 1;
                    }
                }
                else if (probaLiebre >= 51 && probaLiebre <= 80)
                {
                    posLiebre = posLiebre + 1; //Pequeño salto
                    if (posLiebre < 1)
                    {
                        posLiebre = 1;
                    }

                }
                else if (probaLiebre >= 81 && probaLiebre <= 100)
                {
                    posLiebre = posLiebre - 2; //Resbalón pequeño
                    if (posLiebre < 1)
                    {
                        posLiebre = 1;
                    }
                }
                //Tortuga
                if (probaTortuga >= 1 && probaTortuga <= 50)
                {
                    posTortuga = posTortuga + 3; //Avance rápido
                    if (posTortuga < 1)
                    {
                        posTortuga = 1;
                    }

                }
                else if (probaTortuga >= 51 && probaTortuga <= 70)
                {
                    posTortuga = posTortuga - 6; //Resbaló
                    if (posTortuga < 1)
                    {
                        posTortuga = 1;
                    }
                }
                else if (probaTortuga >= 71 && probaTortuga <= 100)
                {
                    posTortuga = posTortuga + 1; // Avance lento
                    if (posTortuga < 1)
                    {
                        posTortuga = 1;
                    }
                }
                tiempoLiebre = tiempoLiebre + 1;
                tiempoTortuga = tiempoTortuga + 1;
                Console.WriteLine($"Posicion Tortuga: {posTortuga}----------Posición Liebre: {posLiebre}");
                Console.ReadKey();
            }
            if (posTortuga >= 70)
            {
                Console.WriteLine($"------------TORTUGA ES LA GANADORA------------");
                Console.ReadKey();
            }
            else if (posLiebre >= 70)
            {
                Console.WriteLine($"----------LA LIEBRE ES LA GANADORA------------");
                Console.ReadKey();
            }

            if (posLiebre < 70)
            {
                while (posLiebre < 70)
                {
                    tiempoLiebre = tiempoLiebre + 1;
                    var probaLiebre = ran.Next(1, 101);
                    //Liebre
                    if (probaLiebre >= 1 && probaLiebre <= 20)
                    {
                        posLiebre = posLiebre + 0;
                        if (posLiebre < 1)
                        {
                            posLiebre = 1;
                        }
                    }
                    else if (probaLiebre >= 21 && probaLiebre <= 40)
                    {
                        posLiebre = posLiebre + 9;
                        if (posLiebre < 1)
                        {
                            posLiebre = 1;
                        }


                    }
                    else if (probaLiebre >= 41 && probaLiebre <= 50)
                    {
                        posLiebre = posLiebre - 12;
                        if (posLiebre < 1)
                        {
                            posLiebre = 1;
                        }
                    }
                    else if (probaLiebre >= 51 && probaLiebre <= 80)
                    {
                        posLiebre = posLiebre + 1;
                        if (posLiebre < 1)
                        {
                            posLiebre = 1;
                        }

                    }
                    else if (probaLiebre >= 81 && probaLiebre <= 100)
                    {
                        posLiebre = posLiebre - 2;
                        if (posLiebre < 1)
                        {
                            posLiebre = 1;
                        }
                    }
                    Console.WriteLine($"Posicion Tortuga: {posTortuga}----------Posición Liebre: {posLiebre}");
                    Console.ReadKey();
                }
            }
            else if (posTortuga < 70)
            {
                while (posTortuga < 70)
                {
                    tiempoTortuga = tiempoTortuga + 1;
                    var probaTortuga = ran.Next(1, 101);
                    if (probaTortuga >= 1 && probaTortuga <= 50)
                    {
                        posTortuga = posTortuga + 3;
                        if (posTortuga < 1)
                        {
                            posTortuga = 1;
                        }

                    }
                    else if (probaTortuga >= 51 && probaTortuga <= 70)
                    {
                        posTortuga = posTortuga - 6;
                        if (posTortuga < 1)
                        {
                            posTortuga = 1;
                        }
                    }
                    else if (probaTortuga >= 71 && probaTortuga <= 100)
                    {
                        posTortuga = posTortuga + 1;
                        if (posTortuga < 1)
                        {
                            posTortuga = 1;
                        }
                    }
                    Console.WriteLine($"Posicion Tortuga: {posTortuga}----------Posición Liebre: {posLiebre}");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("RESULTADOS:");
            Console.WriteLine($"TORTUGA-----Tiempo = {tiempoTortuga}");
            Console.WriteLine($"LIEBRE------Tiempo = {tiempoLiebre}");
            Console.ReadKey();


        }
        static void tortuga()
        {
            Console.Write("TORTUGA: ");
            int tiempoTortuga = 0;
            var ran = new Random();
            int posicion = 0;
            while (posicion < 70)
            {
                var probabilidad = ran.Next(1, 101);
                if (probabilidad >= 1 && probabilidad <= 50)
                {
                    posicion = posicion + 3;
                    if (posicion < 1)
                    {
                        posicion = 1;
                    }
                    else
                    {
                        Console.WriteLine($"Avance rápido, POSICION {posicion}");
                        Console.ReadKey();
                    }
                }
                else if (probabilidad >= 51 && probabilidad <= 70)
                {
                    posicion = posicion - 6;
                    if (posicion < 1)
                    {
                        posicion = 1;
                    }
                    else
                    {
                        Console.WriteLine($"Resbalo, POSICION {posicion}");
                        Console.ReadKey();
                    }
                }
                else if (probabilidad >= 71 && probabilidad <= 100)
                {
                    posicion = posicion + 1;
                    if (posicion < 1)
                    {
                        posicion = 1;
                    }
                    else
                    {
                        Console.WriteLine($"Avance Lento, POSICION {posicion}");
                        Console.ReadKey();
                    }
                }
                tiempoTortuga = tiempoTortuga + 1;
            }
            Console.WriteLine("TORTUGA HA LLEGADO A LA META");
            Console.WriteLine($"Tiempo Tortuga: {tiempoTortuga}");
        }
        static void liebre()
        {
            Console.Write("LIEBRE:");
            var ran = new Random();
            int tiempoLiebre = 0;
            int posicion = 0;
            while (posicion < 70)
            {
                var probabilidad = ran.Next(1, 101);
                if (probabilidad >= 1 && probabilidad <= 20)
                {
                    posicion = posicion + 0;
                    if (posicion < 1)
                    {
                        posicion = 1;
                    }
                    else
                    {
                        Console.WriteLine($"Duerme, POSICION {posicion}");
                        Console.ReadKey();
                    }
                }
                else if (probabilidad >= 21 && probabilidad <= 40)
                {
                    posicion = posicion + 9;
                    if (posicion < 1)
                    {
                        posicion = 1;
                    }
                    else
                    {
                        Console.WriteLine($"Gran Salto, POSICION {posicion}");
                        Console.ReadKey();
                    }
                }
                else if (probabilidad >= 41 && probabilidad <= 50)
                {
                    posicion = posicion - 12;
                    if (posicion < 1)
                    {
                        posicion = 1;
                    }
                    else
                    {
                        Console.WriteLine($"Resbalón grande, POSICION {posicion}");
                        Console.ReadKey();
                    }
                }
                else if (probabilidad >= 51 && probabilidad <= 80)
                {
                    posicion = posicion + 1;
                    if (posicion < 1)
                    {
                        posicion = 1;
                    }
                    Console.WriteLine($"Pequeño salto, POSICION {posicion}");
                    Console.ReadKey();
                }
                else if (probabilidad >= 81 && probabilidad <= 100)
                {
                    posicion = posicion - 2;
                    if (posicion < 1)
                    {
                        posicion = 1;
                    }
                    else
                    {
                        Console.WriteLine($"Resbalón pequeño, POSICION {posicion}");
                        Console.ReadKey();
                    }
                }
                tiempoLiebre = tiempoLiebre + 1;
            }
            Console.WriteLine("LIEBRE HA LLEGADO A LA META");
            Console.WriteLine($"Tiempo: {tiempoLiebre}");
        }
    }
}
