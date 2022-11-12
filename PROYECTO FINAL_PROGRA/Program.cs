using System;

namespace Sistema_Automatizado
// Integrantes del grupo
// José Alejandro Palacios Padilla - carné:1129522
// Favio André Gutiérrez del Aguila - carné:1088322
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int temperatura = 22, niveles_humedad = 80;
            bool presencia = false, luces = false;
            bool i = true;

            Console.WriteLine("Bienvenido a su sistema Automatizado");
            Console.Write("Porfavor Ingrese su Nombre: ");
            Nombre = Console.ReadLine();

            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido a su sistema Automatizado - " + Nombre);
                Console.WriteLine(" ");
                Console.WriteLine("Seleccione una opcion: ");
                Console.WriteLine("1. Ventilacion.");
                Console.WriteLine("2. Calefaccion.");
                Console.WriteLine("3. Iluminacion.");
                Console.WriteLine("4. Panel de Control.");
                Console.WriteLine("5 Salir.");
                int opcion = Convert.ToInt32(Console.ReadLine());
                bool m = true;
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ventilacion - " + Nombre);
                        if (niveles_humedad < 70)
                        {
                            Console.WriteLine("Sistemas en correcto estado");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Sistemas con excesiva humedad, porfavor indique su hora de encendido: ");
                            int Encendido_Ventilacion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Indique su hora de apagado: ");
                            int Apagado_Ventilacion = Convert.ToInt32(Console.ReadLine());
                            while (Encendido_Ventilacion < Apagado_Ventilacion)
                            {
                                Encendido_Ventilacion++;
                                niveles_humedad = niveles_humedad - 10;
                            }

                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Calefacción - " + Nombre);
                        if (18 < temperatura && temperatura < 22)
                        {
                            Console.WriteLine("Temperatura optima");
                        }
                        else
                        {
                            if (temperatura < 18)
                            {
                                Console.WriteLine("Temperatura baja");
                            }
                            else
                            {
                                Console.WriteLine("Temperatura alta");
                            }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Iluminación - " + Nombre);
                        if (luces == true)
                        {

                            Console.WriteLine("Luces Encendidas.");
                        }
                        else
                        {
                            Console.WriteLine("Luces Apagadas.");
                        }
                        break;
                    case 4:
                        Console.Clear();
                        int[] Maxima_Calefaccion = new int[100];
                        int[] Minima_Calefaccion = new int[100];
                        Console.WriteLine("Panel de Control - " + Nombre);
                        Console.WriteLine("Seleccione una opcion: ");
                        Console.WriteLine("1. Programar Ventilación.");
                        Console.WriteLine("2. Modificar Calefaccion.");
                        Console.WriteLine("3. Modificar Iluminacion.");
                        Console.WriteLine("4. Salir.");
                        int opcion2 = Convert.ToInt32(Console.ReadLine());
                        switch (opcion2)
                        {
                            case 1:
                                Console.Clear();
                                int Encendido_Ventilacion;
                                int Apagado_Ventilacion;
                                int x;
                                Console.WriteLine("Programar Ventilación - " + Nombre);
                                do
                                {
                                    Console.WriteLine("Porfavor indique su hora de encendido: ");
                                    Encendido_Ventilacion = Convert.ToInt32(Console.ReadLine());
                                    x = Encendido_Ventilacion;
                                    if (Encendido_Ventilacion > 24)
                                    {
                                        Console.WriteLine("--------------------------------------------------");
                                        Console.WriteLine("Hora fuera de los parámetros");
                                    }
                                } while (Encendido_Ventilacion > 24);

                                do
                                {
                                    Console.WriteLine("Indique su hora de apagado: ");
                                    Apagado_Ventilacion = Convert.ToInt32(Console.ReadLine());
                                    if (Apagado_Ventilacion > 24)
                                    {
                                        Console.WriteLine("--------------------------------------------------");
                                        Console.WriteLine("Hora fuera de los parámetros.");
                                    }
                                } while (Apagado_Ventilacion > 24);

                                while (x < Apagado_Ventilacion)
                                {
                                    x = x + 1;
                                    niveles_humedad = niveles_humedad - 10;
                                }
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Programar Calefaccón - " + Nombre);
                                int a = 0;
                                bool k = true;
                                do
                                {
                                    Console.Clear();
                                    a++;
                                    do
                                    {
                                        Console.WriteLine("Porfavor indique la temperatura Maxima: ");
                                        Maxima_Calefaccion[a] = Convert.ToInt32(Console.ReadLine());
                                        if (Maxima_Calefaccion[a] < 18 || Maxima_Calefaccion[a] > 22)
                                        {
                                            Console.WriteLine("--------------------------------------------------");
                                            Console.WriteLine("Temperatura fuera de los límites.");
                                        }
                                    } while (Maxima_Calefaccion[a] < 18 || Maxima_Calefaccion[a] > 22);

                                    do
                                    {
                                        Console.WriteLine("Porfavor indique la temperatura Minima: ");
                                        Minima_Calefaccion[a] = Convert.ToInt32(Console.ReadLine());
                                        if (Minima_Calefaccion[a] < 18 || Minima_Calefaccion[a] > 22)
                                        {
                                            Console.WriteLine("--------------------------------------------------");
                                            Console.WriteLine("Temperatura fuera de los límites.");
                                        }
                                        if (Minima_Calefaccion[a] > Maxima_Calefaccion[a])
                                        {
                                            Console.WriteLine("--------------------------------------------------");
                                            Console.WriteLine("La temperatura minima debe ser menor que la temperatura maxima.");
                                        }
                                    } while (Minima_Calefaccion[a] < 18 || Minima_Calefaccion[a] > 22 || Minima_Calefaccion[a] > Maxima_Calefaccion[a]);
                                    bool l = true;
                                    do
                                    {
                                        Console.WriteLine("--------------------------------------------------");
                                        Console.WriteLine("Desea Ingresar otra temperatura? S/N");
                                        string respuesta3 = Console.ReadLine();
                                        if (respuesta3 == "S")
                                        {
                                            l = false;
                                            break;
                                        }
                                        else if (respuesta3 == "N")
                                        {
                                            l = false;
                                            k = false;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Ingrese una respuesta correcta.");
                                        }
                                    } while (l == true);
                                } while (k == true);
                                int promedio = 0;
                                for (int K = 1; K <= a; K++)
                                {
                                    temperatura++;
                                    promedio = Maxima_Calefaccion[K] + Minima_Calefaccion[K];
                                    promedio = promedio / 2;
                                    Console.WriteLine("El promedio de la calefaccion " + K + " es: " + promedio);
                                }
                                int promedio2 = 0;
                                int promedio3 = 0;
                                int promedio4 = 0;
                                for (int M = 1; M <= a; M++)
                                {
                                    promedio2 = promedio2 + Maxima_Calefaccion[M];
                                    promedio3 = promedio3 + Minima_Calefaccion[M];
                                }
                                promedio2 = promedio2 / a;
                                promedio3 = promedio3 / a;
                                promedio4 = (promedio2 + promedio3) / 2;
                                Console.WriteLine("--------------------------------------------------");
                                Console.WriteLine("El promedio total de la calefaccion es: " + promedio4);
                                break;
                            case 3:
                                Console.WriteLine("Encender(1) o Apagar la Iluminacion(2)?");
                                int instruccion = System.Convert.ToInt32(Console.ReadLine());
                                if (instruccion == 1)
                                {
                                    Console.WriteLine("Luces encendidas");
                                    luces = true;
                                }
                                if (instruccion == 2)
                                {
                                    Console.WriteLine("Luces apagadas");
                                    luces = false;
                                }
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Saliendo...");
                                i = false;
                                break;
                            default:
                                Console.WriteLine("Seleecione una opcion valida");
                                break;
                        }

                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Saliendo...");
                        i = false;
                        m = false;
                        break;
                    default:
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("Seleccione una opcion del 1 al 4.");
                        break;
                }

                while (m == true)
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("¿Desea realizar otra accion? S/N");
                    string respuesta1 = Console.ReadLine();
                    if (respuesta1 == "S")
                    {
                        m = false;
                        break;
                    }
                    else if (respuesta1 == "N")
                    {
                        m = false;
                        i = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ingrese una respuesta correcta.");
                    }
                }
            } while (i == true);
        }
    }
}